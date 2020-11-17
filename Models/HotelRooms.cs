using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class HotelRooms
    {
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public Hotel Hotel { get; set; }
        public Room Room { get; set; }
        public int RoomNumber { get; set; }
        public decimal Rate { get; set; }
        
        public enum PetFreindly
        {
            yes,
            no
        }
    }
}
