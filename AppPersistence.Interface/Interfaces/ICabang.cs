using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface ICabang
    {
        Task<IEnumerable<CabangDTo>> GetAllAsync(CabangDTo param);
    }
}
