using HBS.Core.Entities;
using HBS.Core.Web.Models;

using Refit;

namespace HBS.Core.Web.Interfaces;

public interface IBookingService
{
    [Get("/availableRooms?coordinates={coordinates}")]
    Task<HotelRoomAvailableInfo[]> GetAvailableRoomsAsync(IEnumerable<Coordinates> coordinates);
}