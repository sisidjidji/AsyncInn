﻿using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AsyncInn.Data
{
    public class AsyncInnDbContext : DbContext
    {
        public AsyncInnDbContext(DbContextOptions options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<HotelRooms>().HasKey(HotelRooms => new
            {
                HotelRooms.HotelId,
                HotelRooms.RoomId
            });

            modelBuilder.Entity<RoomAmenities>().HasKey(RoomAmenities => new
            {
                
                RoomAmenities.AmenitiesId,
                RoomAmenities.RoomId,
            });
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
        public DbSet<HotelRooms> HotelRooms { get; set; }
        public DbSet<Amenities> Amenities { get; set; }

    }
}
