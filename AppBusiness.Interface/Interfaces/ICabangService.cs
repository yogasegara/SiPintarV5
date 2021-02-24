using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface ICabangService
    {
        Task<IEnumerable<CabangDTo>> GetAll(CabangDTo param);
    }
}