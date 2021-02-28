using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class MasterPelangganService : IMasterPelangganService
    {
        private readonly IMasterPelanggan PelangganRepo;

        public MasterPelangganService(IPersistence persistence)
        {         
            PelangganRepo = persistence.MasterPelanggan;
        }

        public async Task<IEnumerable<MasterPelangganDTo>> GetAll(int limit, MasterPelangganDTo param)
        {
            return await PelangganRepo.GetAllAsync(limit,param);
        }
    }
}
