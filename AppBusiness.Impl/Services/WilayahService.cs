using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class WilayahService : IWilayahService
    {
        private readonly IWilayah wilayah;

        public WilayahService(IPersistence persistence)
        {
            wilayah = persistence.Wilayah;
        }

        public async Task<IEnumerable<MasterWilayahDto>> GetAll(MasterWilayahDto param)
        {
            return await wilayah.GetAllAsync(param);
        }
    }
}
