using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class MasterDiameterService : IMasterDiameterService
    {
        private readonly IMasterDiameter diameter;

        public MasterDiameterService(IPersistence persistence)
        {
            diameter = persistence.MasterDiameter;
        }

        public async Task<IEnumerable<MasterDiameterDto>> GetAll(MasterDiameterDto param)
        {
            return await diameter.GetAllAsync(param);
        }

       
    }
}
