using AsyncInn.Models;
using AsyncInn.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Repository
{
    public class IAmenitiesRepository
    {
        Task<IEnumerable<AmenitiesDTO>> GetAllAmenities();
        Task<AmenitiesDTO> GetOneAmenitie(int id);
        Task<AmenitiesDTO> SaveNewAmenitie(Amenities amenitie);
        Task<AmenitiesDTO> UpdateAmenitie(int id, Amenities amenitie);
        Task<AmenitiesDTO> DeleteAmenitie(int id);
    }
}
