using AsyncInn.Models;
using AsyncInn.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Repository
{
    public class IRoomRepository
    {
        Task<IEnumerable<RoomDTO>> GetAllRooms();
        Task<RoomDTO> GetOneRoom(int id);

        Task<RoomDTO> DeleteRoom(int id);
        Task<RoomDTO> SaveNewRoom(Room room);
        Task<RoomDTO> UpdateRoom(int id, Room room);

        Task AddAminityToRoom(int amenitieId , int roomId);
        Task DeleteAminityFromRoom(int amenitieId, int roomId);
    }
}
