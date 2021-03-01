using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class MasterBlokService : IMasterBlokService
    {
        private readonly IMasterBlok Blok;

        public MasterBlokService(IPersistence persistence)
        {
            Blok = persistence.MasterBlok;
        }

        public async Task<IEnumerable<MasterBlokDto>> GetAll(MasterBlokDto param)
        {
            return await Blok.GetAllAsync(param);
        }
    }
}
