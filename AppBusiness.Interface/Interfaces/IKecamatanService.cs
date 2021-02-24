using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IKecamatanService
    {
        Task<IEnumerable<KecamatanDTo>> GetAll(KecamatanDTo param);
    }
}