using SummerWindsResorts.Application.Common.Interfaces;
using SummerWindsResorts.Domain.Entities;
using SummerWindsResorts.Infrastructure.Data;

namespace SummerWindsResorts.Infrastructure.Repository
{
    public class BookingRepository : Repository<Booking>, IBookingRepository
    {
        private readonly ApplicationDbContext _db;
        public BookingRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Booking entity)
        {
            _db.Bookings.Update(entity);
        }
    }
}
