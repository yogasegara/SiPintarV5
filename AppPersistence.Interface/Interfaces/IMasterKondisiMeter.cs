using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IMasterKondisiMeter
    {
        Task<IEnumerable<MasterKondisiMeterDto>> GetAllAsync(MasterKondisiMeterDto param);
    }
}
