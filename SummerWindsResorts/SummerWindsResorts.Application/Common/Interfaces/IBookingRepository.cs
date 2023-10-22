using SummerWindsResorts.Domain.Entities;

namespace SummerWindsResorts.Application.Common.Interfaces
{
    public interface IBookingRepository : IRepository<Booking>
    {
        void Update(Booking entity);
    }
}
