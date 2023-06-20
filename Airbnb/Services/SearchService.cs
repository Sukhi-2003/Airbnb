using Airbnb.Models;
using Airbnb.Models.DTO;
using Airbnb.Repositories;
using AutoMapper;

namespace Airbnb.Services;

public class SearchService : ISearchService
{
    private readonly IAirbnbRepository _repository;
    private readonly IMapper _mapper;
    public SearchService(IAirbnbRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<Location>> GetLocations(CancellationToken cancellationToken)
    {
        return await _repository.GetAllLocations(cancellationToken);
    }

    public async Task<UnAvailableDatesReponseDTO> GetUnAvailableDates(int locationId, CancellationToken cancellationToken)
    {
        var location = (await _repository.GetLocation(locationId, cancellationToken));

        var unAvailableDates = new UnAvailableDatesReponseDTO();

        foreach (var reservation in location.Reservations)
        {
            unAvailableDates.UnAvailableDates.AddRange(GetDatesBetween(reservation.StartDate, reservation.EndDate));
        }

        return unAvailableDates;
    }

    public List<DateTime> GetDatesBetween(DateTime startDate, DateTime endDate)
    {
        List<DateTime> allDates = new();

        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            allDates.Add(date);
        }

        return allDates;
    }

    public async Task<IEnumerable<LocationDTOWithPrice>> Search(LocationRequestDTO? locationRequest, CancellationToken cancellationToken)
    {
        var locations = await _repository.GetAllLocations(cancellationToken);

        if (!locationRequest.Type.HasValue
            && !locationRequest.Features.HasValue
            && !locationRequest.MinPrice.HasValue
            && !locationRequest.MaxPrice.HasValue)
        {
            return locations.Select(location => _mapper.Map<LocationDTOWithPrice>(location));
        }

        if (locationRequest.Features.HasValue)
        {
            // the input in the where clause will be the int value of the request DTO.
            // by parsing the int value into a string value we can retrieve the enum value of that specific enum value
            // therefore getting the correct type for the hasFlag method 
            locations = locations.Where(location => location.FeaturesList.HasFlag(
                                                                          (Location.Features)Enum.Parse(typeof(Location.Features), 
                                                                          locationRequest.Features.ToString())));
        }

        if (locationRequest.Type.HasValue)
        {
            locations = locations.Where(location => (int)location.Type == locationRequest.Type.Value);
            var filterd = locations.ToList();
        }

        if (locationRequest.Rooms.HasValue)
        {
            locations = locations.Where(location => location.Rooms == locationRequest.Rooms.Value);
        }

        if (locationRequest.MinPrice.HasValue)
        {
            locations = locations.Where(location => location.PricePerDay >= locationRequest.MinPrice.Value);
        }

        if (locationRequest.MaxPrice.HasValue)
        {
            locations = locations.Where(location => location.PricePerDay <= locationRequest.MaxPrice.Value);
        }

        return locations.ToList().Select(location => _mapper.Map<LocationDTOWithPrice>(location)); 
    }
}