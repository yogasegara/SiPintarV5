using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IWilayah
    {
        Task<IEnumerable<MasterWilayahDto>> GetAllAsync(MasterWilayahDto param);
    }
}
