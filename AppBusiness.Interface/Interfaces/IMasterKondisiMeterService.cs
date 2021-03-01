using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IMasterKondisiMeterService
    {
        Task<IEnumerable<MasterKondisiMeterDto>> GetAll(MasterKondisiMeterDto param);
    }
}