using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.DTO
{
    public class HotelDTO
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }

        public List<HotelRoomsDTO> HotelRoomsList { get; set; }
    }
}
