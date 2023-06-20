using HBS.Core.Common.Repositories.Interfaces;
using HBS.Core.Models;

using Microsoft.Extensions.Logging;

namespace HBS.Core.BusinessLogic
{
    public class HotelManager : IHotelManager
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly ILogger<HotelManager> _logger;

        public HotelManager(IHotelRepository hotelRepository, ILogger<HotelManager> logger)
        {
            _hotelRepository = hotelRepository;
            _logger = logger;
        }

        
        public IAsyncEnumerable<HotelModel> GetNearbyHotels(Coordinate coordinate, double radius){
            
            var hotels = _hotelRepository.GetNearbyHotels(coordinate, radius);
            _logger.LogInformation("return list hotels");//TODO вписать в логгер количество найденных отелей
            return hotels;
        }
        
        public IAsyncEnumerable<HotelModel> OrderHotelsByRating(){
            
            var hotels = _hotelRepository.OrderHotelsByRating();
            _logger.LogInformation("return ordered list hotels by rating");//TODO вписать в логгер количество найденных отелей
            return hotels;
        }
     
        public async Task<HotelModel> GetBestHotel(Coordinate coordinate, double radius)
        {
            //TODO как то сделать асинхронно
            var hotel = await _hotelRepository.GetBestHotel(coordinate, radius);
            _logger.LogInformation("return best hotel {hotel}", hotel);
            return hotel;
        }

        public async Task<HotelModel> GetNearestHotel(Coordinate coordinate){
            //TODO как то сделать асинхронно
             var hotel = await _hotelRepository.GetNearestHotel(coordinate);
            _logger.LogInformation("return nearest hotel {hotel}", hotel);
            return  hotel;
        }

    }
}