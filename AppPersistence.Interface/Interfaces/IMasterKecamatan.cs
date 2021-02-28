using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IMasterKecamatan
    {
        Task<IEnumerable<MasterKecamatanDTo>> GetAllAsync(MasterKecamatanDTo param);
    }
}
