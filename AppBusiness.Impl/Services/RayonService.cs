using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class RayonService : IRayonService
    {
        private readonly IRayon rayon;

        public RayonService(IPersistence persistence)
        {
            rayon = persistence.Rayon;
        }

        public async Task<IEnumerable<RayonDTo>> GetAll(RayonDTo param)
        {
            return await rayon.GetAllAsync(param);
        }
    }
}
