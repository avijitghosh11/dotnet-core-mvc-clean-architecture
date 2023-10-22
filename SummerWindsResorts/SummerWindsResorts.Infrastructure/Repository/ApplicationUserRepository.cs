using SummerWindsResorts.Application.Common.Interfaces;
using SummerWindsResorts.Domain.Entities;
using SummerWindsResorts.Infrastructure.Data;

namespace SummerWindsResorts.Infrastructure.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
