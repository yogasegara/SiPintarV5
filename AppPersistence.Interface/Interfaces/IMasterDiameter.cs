using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IMasterDiameter
    {
        Task<IEnumerable<MasterDiameterDto>> GetAllAsync(MasterDiameterDto param);       
    }

}