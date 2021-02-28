using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class MasterRayonService : IMasterRayonService
    {
        private readonly IMasterRayon rayon;

        public MasterRayonService(IPersistence persistence)
        {
            rayon = persistence.MasterRayon;
        }

        public async Task<IEnumerable<MasterRayonDto>> GetAll(MasterRayonDto param)
        {
            return await rayon.GetAllAsync(param);
        }
    }
}
