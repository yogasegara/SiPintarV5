using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class MasterKecamatanService : IMasterKecamatanService
    {
        private readonly IMasterKecamatan kecamatan;

        public MasterKecamatanService(IPersistence persistence)
        {
            kecamatan = persistence.MasterKecamatan;
        }

        public async Task<IEnumerable<MasterKecamatanDTo>> GetAll(MasterKecamatanDTo param)
        {
            return await kecamatan.GetAllAsync(param);
        }
    }
}
