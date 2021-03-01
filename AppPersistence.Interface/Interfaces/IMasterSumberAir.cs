using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IMasterSumberAir
    {
        Task<IEnumerable<MasterSumberAirDto>> GetAllAsync(MasterSumberAirDto param);
    }
}
