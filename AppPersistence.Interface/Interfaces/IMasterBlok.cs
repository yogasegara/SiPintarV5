using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IMasterBlok
    {
        Task<IEnumerable<MasterBlokDto>> GetAllAsync(MasterBlokDto param);
    }
}
