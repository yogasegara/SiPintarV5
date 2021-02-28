using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IMasterKelurahanService
    {
        Task<IEnumerable<MasterKelurahanDTo>> GetAll(MasterKelurahanDTo param);
    }
}