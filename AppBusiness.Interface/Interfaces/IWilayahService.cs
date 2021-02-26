using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IWilayahService
    {
        Task<IEnumerable<MasterWilayahDto>> GetAll(MasterWilayahDto param);
    }
}