using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class KecamatanService : IKecamatanService
    {
        private readonly IKecamatan kecamatan;

        public KecamatanService(IPersistence persistence)
        {
            kecamatan = persistence.Kecamatan;
        }

        public async Task<IEnumerable<KecamatanDTo>> GetAll(KecamatanDTo param)
        {
            return await kecamatan.GetAllAsync(param);
        }
    }
}
