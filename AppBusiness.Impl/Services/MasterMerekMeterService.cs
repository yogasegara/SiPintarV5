using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class MasterMerekMeterService : IMasterMerekMeterService
    {
        private readonly IMasterMerekMeter MerekMeter;

        public MasterMerekMeterService(IPersistence persistence)
        {
            MerekMeter = persistence.MasterMerekMeter;
        }

        public async Task<IEnumerable<MasterMerekMeterDto>> GetAll(MasterMerekMeterDto param)
        {
            return await MerekMeter.GetAllAsync(param);
        }
    }
}
