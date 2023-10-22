using SummerWindsResorts.Application.Common.Interfaces;
using SummerWindsResorts.Domain.Entities;
using SummerWindsResorts.Infrastructure.Data;

namespace SummerWindsResorts.Infrastructure.Repository
{
    public class AmenityRepository : Repository<Amenity>, IAmenityRepository
    {
        private readonly ApplicationDbContext _db;

        public AmenityRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Amenity entity)
        {
            _db.Amenities.Update(entity);
        }
    }
}
