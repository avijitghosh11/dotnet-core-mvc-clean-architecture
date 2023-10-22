using SummerWindsResorts.Application.Common.Interfaces;
using SummerWindsResorts.Domain.Entities;
using SummerWindsResorts.Infrastructure.Data;

namespace SummerWindsResorts.Infrastructure.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Villa entity)
        {
            _db.Villas.Update(entity);
        }
    }
}
