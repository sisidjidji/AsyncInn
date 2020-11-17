using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Repository
{
    public class IRoomAmenitiesReoisitory
    {
        Task<RoomAmenities> GetAllAmenities(int roomId);
        Task<RoomAmenities> SaveNewAmenitie(int roomId, int amenitieId , RoomAmenities roomAmenitie);
        Task<RoomAmenities> DeleteRoomAminitie(int roomId, int amenitieId);
        
    }
}
