using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IPelangganService
    {
        Task<IEnumerable<PelangganDTo>> GetAll(int limit, PelangganDTo param);
    }
}