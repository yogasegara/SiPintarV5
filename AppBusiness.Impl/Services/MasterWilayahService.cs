using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class MasterWilayahService : IMasterWilayahService
    {
        private readonly IMasterWilayah wilayah;

        public MasterWilayahService(IPersistence persistence)
        {
            wilayah = persistence.MasterWilayah;
        }

        public async Task<IEnumerable<MasterWilayahDto>> GetAll(MasterWilayahDto param)
        {
            return await wilayah.GetAllAsync(param);
        }
    }
}
