using AsyncInn.Models;
using AsyncInn.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Repository
{
    public class IHotelRoomRepository
    {
        Task<IEnumerable<HotelRoomsDTO>> GetAllHotelRooms(int hotelId);
        Task<HotelRoomsDTO> CreateHotelRoom(int hotelId, HotelRooms hotelRooms);
        Task<HotelRoomsDTO> UpdateHotelRoom(int hotelId, HotelRooms hotelRooms);
        Task<HotelRoomsDTO> DeleteHotelRoom(int hotelId, int roomNumber);


    }
}
