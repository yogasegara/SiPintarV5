using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IPelanggan
    {
        Task<IEnumerable<PelangganDTo>> GetAllAsync(int limit, PelangganDTo param);
    }
}
