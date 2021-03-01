using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IMasterSumberAirService
    {
        Task<IEnumerable<MasterSumberAirDto>> GetAll(MasterSumberAirDto param);
    }
}