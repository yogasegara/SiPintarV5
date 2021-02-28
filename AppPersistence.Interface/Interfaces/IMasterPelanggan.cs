using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IMasterPelanggan
    {
        Task<IEnumerable<MasterPelangganDTo>> GetAllAsync(int limit, MasterPelangganDTo param);
    }
}
