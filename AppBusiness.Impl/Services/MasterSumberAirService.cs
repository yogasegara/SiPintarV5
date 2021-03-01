using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class MasterSumberAirService : IMasterSumberAirService
    {
        private readonly IMasterSumberAir sumberAir;

        public MasterSumberAirService(IPersistence persistence)
        {
            sumberAir = persistence.MasterSumberAir;
        }

        public async Task<IEnumerable<MasterSumberAirDto>> GetAll(MasterSumberAirDto param)
        {
            return await sumberAir.GetAllAsync(param);
        }
    }
}
