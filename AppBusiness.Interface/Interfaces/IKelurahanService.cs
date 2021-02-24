using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IKelurahanService
    {
        Task<IEnumerable<KelurahanDTo>> GetAll(KelurahanDTo param);
    }
}