using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IMasterMerekMeter
    {
        Task<IEnumerable<MasterMerekMeterDto>> GetAllAsync(MasterMerekMeterDto param);
    }
}
