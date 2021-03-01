using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class MasterGolonganService : IMasterGolonganService
    {
        private readonly IMasterGolongan golongan;

        public MasterGolonganService(IPersistence persistence)
        {
            golongan = persistence.MasterGolongan;
        }

        public async Task<IEnumerable<MasterGolonganDto>> GetAll(MasterGolonganDto param)
        {
            return await golongan.GetAllAsync(param);
        }

       
    }
}
