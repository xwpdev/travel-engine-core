﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelEngine.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class travelenginedbEntities : DbContext
    {
        public travelenginedbEntities()
            : base("name=travelenginedbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Bus> Buses { get; set; }
        public virtual DbSet<BusTime> BusTimes { get; set; }
        public virtual DbSet<BusType> BusTypes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerDevice> CustomerDevices { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<SeatSide> SeatSides { get; set; }
        public virtual DbSet<SeatType> SeatTypes { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<TripBooking> TripBookings { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
    }
}
