using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class PelangganService : IPelangganService
    {
        private readonly IPelanggan PelangganRepo;

        public PelangganService(IPersistence persistence)
        {         
            PelangganRepo = persistence.Pelanggan;
        }

        public async Task<IEnumerable<PelangganDTo>> GetAll(int limit, PelangganDTo param)
        {
            return await PelangganRepo.GetAllAsync(limit,param);
        }
    }
}
