﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.DTO
{
    public class HotelRoomsDTO
    {
        public int HotelId { get; set; }
        public int RoomID { get; set; }
        public int RoomNumber { get; set; }
        public decimal Rate { get; set; }
        public RoomDTO Room { get; set; }
        
        
    }
}
