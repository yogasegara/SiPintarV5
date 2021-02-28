using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IMasterDiameterService
    {
        Task<IEnumerable<MasterDiameterDto>> GetAll(MasterDiameterDto param);
       
    }
}