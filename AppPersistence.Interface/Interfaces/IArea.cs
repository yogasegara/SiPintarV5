using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IArea
    {
        Task<IEnumerable<AreaDTo>> GetAllAsync(AreaDTo param);
    }
}
