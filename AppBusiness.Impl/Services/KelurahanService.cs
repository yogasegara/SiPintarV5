using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class KelurahanService : IKelurahanService
    {
        private readonly IKelurahan kelurahan;

        public KelurahanService(IPersistence persistence)
        {
            kelurahan = persistence.Kelurahan;
        }

        public async Task<IEnumerable<KelurahanDTo>> GetAll(KelurahanDTo param)
        {
            return await kelurahan.GetAllAsync(param);
        }
    }
}
