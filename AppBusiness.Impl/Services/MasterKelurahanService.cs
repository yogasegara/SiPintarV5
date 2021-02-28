using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class MasterKelurahanService : IMasterKelurahanService
    {
        private readonly IMasterKelurahan kelurahan;

        public MasterKelurahanService(IPersistence persistence)
        {
            kelurahan = persistence.MasterKelurahan;
        }

        public async Task<IEnumerable<MasterKelurahanDTo>> GetAll(MasterKelurahanDTo param)
        {
            return await kelurahan.GetAllAsync(param);
        }
    }
}
