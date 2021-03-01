using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IMasterBlokService
    {
        Task<IEnumerable<MasterBlokDto>> GetAll(MasterBlokDto param);
    }
}