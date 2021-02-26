using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class AreaService : IAreaService
    {
        private readonly IArea area;

        public AreaService(IPersistence persistence)
        {
            area = persistence.Area;
        }

        public async Task<IEnumerable<MasterAreaDto>> GetAll(MasterAreaDto param)
        {
            return await area.GetAllAsync(param);           
        }
    }
}
