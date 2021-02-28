using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IMasterAreaService
    {
        Task<IEnumerable<MasterAreaDto>> GetAll(MasterAreaDto param);
    }
}