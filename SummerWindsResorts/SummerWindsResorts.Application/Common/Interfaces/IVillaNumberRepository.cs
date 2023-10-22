using SummerWindsResorts.Domain.Entities;

namespace SummerWindsResorts.Application.Common.Interfaces
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        void Update(VillaNumber entity);
    }
}
