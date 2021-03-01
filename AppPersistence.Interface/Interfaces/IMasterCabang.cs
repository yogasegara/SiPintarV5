using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IMasterCabang
    {
        Task<IEnumerable<MasterCabangDto>> GetAllAsync(MasterCabangDto param);
    }
}
