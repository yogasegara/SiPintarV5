using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IAreaService
    {
        Task<IEnumerable<MasterAreaDto>> GetAll(MasterAreaDto param);
    }
}