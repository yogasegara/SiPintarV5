using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class MasterAreaService : IMasterAreaService
    {
        private readonly IMasterArea area;

        public MasterAreaService(IPersistence persistence)
        {
            area = persistence.MasterArea;
        }

        public async Task<IEnumerable<MasterAreaDto>> GetAll(MasterAreaDto param)
        {
            return await area.GetAllAsync(param);           
        }
    }
}
