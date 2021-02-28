using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class MasterCabangService : IMasterCabangService
    {
        private readonly IMasterCabang cabang;

        public MasterCabangService(IPersistence persistence)
        {
            cabang = persistence.MasterCabang;
        }

        public async Task<IEnumerable<MasterCabangDTo>> GetAll(MasterCabangDTo param)
        {
            return await cabang.GetAllAsync(param);
        }
    }
}
