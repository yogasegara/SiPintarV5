using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IMasterWilayahService
    {
        Task<IEnumerable<MasterWilayahDto>> GetAll(MasterWilayahDto param);
    }
}