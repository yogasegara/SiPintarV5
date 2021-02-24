using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IKelurahan
    {
        Task<IEnumerable<KelurahanDTo>> GetAllAsync(KelurahanDTo param);
    }
}
