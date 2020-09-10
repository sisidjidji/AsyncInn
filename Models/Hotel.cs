using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Hotel
    {
        public int HotelId { get; set;}
        public decimal Rate { get; set; }
        public Room RoomId { get; set; }
        public  enum PetFreindly {
            yes,
            no
        }
    }
}
