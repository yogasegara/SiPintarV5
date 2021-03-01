using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IMasterKelurahan
    {
        Task<IEnumerable<MasterKelurahanDto>> GetAllAsync(MasterKelurahanDto param);
    }
}
