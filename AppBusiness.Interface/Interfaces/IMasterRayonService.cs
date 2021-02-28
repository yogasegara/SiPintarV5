using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IMasterRayonService
    {
        Task<IEnumerable<MasterRayonDto>> GetAll(MasterRayonDto param);
    }
}