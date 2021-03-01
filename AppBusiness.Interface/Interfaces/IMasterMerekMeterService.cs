using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IMasterMerekMeterService
    {
        Task<IEnumerable<MasterMerekMeterDto>> GetAll(MasterMerekMeterDto param);
    }
}