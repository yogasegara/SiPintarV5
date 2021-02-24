using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class CabangService : ICabangService
    {
        private readonly ICabang cabang;

        public CabangService(IPersistence persistence)
        {
            cabang = persistence.Cabang;
        }

        public async Task<IEnumerable<CabangDTo>> GetAll(CabangDTo param)
        {
            return await cabang.GetAllAsync(param);
        }
    }
}
