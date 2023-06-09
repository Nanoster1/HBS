using HBS.Core.Entities;
using HBS.Core.Models;

namespace HBS.Core.Services.HotelManagerService;

public interface IHotelManager
{
    Task<IEnumerable<HotelModel>> ListHotelsAsync(HotelOrdering order, string city, CancellationToken token);
    Task<HotelModel?> GetByIdAsync(long id, CancellationToken token);
}