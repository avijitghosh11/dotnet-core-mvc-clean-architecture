using SummerWindsResorts.Domain.Entities;

namespace SummerWindsResorts.Application.Common.Interfaces
{
    public interface IAmenityRepository : IRepository<Amenity>
    {
        void Update(Amenity entity);
    }
}
