using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IMasterPelangganService
    {
        Task<IEnumerable<MasterPelangganDTo>> GetAll(int limit, MasterPelangganDTo param);
    }
}