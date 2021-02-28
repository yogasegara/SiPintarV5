using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IMasterArea
    {
        Task<IEnumerable<MasterAreaDto>> GetAllAsync(MasterAreaDto param);      
    }

}
