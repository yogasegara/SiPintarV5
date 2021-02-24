using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IKecamatan
    {
        Task<IEnumerable<KecamatanDTo>> GetAllAsync(KecamatanDTo param);
    }
}
