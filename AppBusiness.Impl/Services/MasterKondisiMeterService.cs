using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class MasterKondisiMeterService : IMasterKondisiMeterService
    {
        private readonly IMasterKondisiMeter kondisiMeter;

        public MasterKondisiMeterService(IPersistence persistence)
        {
            kondisiMeter = persistence.MasterKondisiMeter;
        }

        public async Task<IEnumerable<MasterKondisiMeterDto>> GetAll(MasterKondisiMeterDto param)
        {
            return await kondisiMeter.GetAllAsync(param);
        }
    }
}
