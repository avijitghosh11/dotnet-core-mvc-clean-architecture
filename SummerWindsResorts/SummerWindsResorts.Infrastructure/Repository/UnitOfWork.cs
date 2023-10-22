﻿using SummerWindsResorts.Application.Common.Interfaces;
using SummerWindsResorts.Infrastructure.Data;

namespace SummerWindsResorts.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IVillaRepository Villa { get; private set; }
        public IApplicationUserRepository User { get; private set; }
        public IAmenityRepository Amenity { get; private set; }
        public IBookingRepository Booking { get; private set; }
        public IVillaNumberRepository VillaNumber { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Villa = new VillaRepository(_db);
            User = new ApplicationUserRepository(_db);
            Booking = new BookingRepository(_db);
            Amenity = new AmenityRepository(_db);
            VillaNumber = new VillaNumberRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
