using AsyncInn.Models;
using AsyncInn.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Repository
{
    public class IHotelRepository
    {
        Task<IEnumerable<HotelDTO>> GetAllHotels();
        Task<HotelDTO> GetOneHotel(int id);
        Task<HotelDTO> SaveOneHotel( Hotel hotel);
        Task<HotelDTO> UpdateHotel(int id, Hotel hotel);
        Task<HotelDTO> DeleteHotel(int id);
    }
}
