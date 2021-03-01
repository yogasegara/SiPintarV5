using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using AppPersistence.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Impl.Services
{
    public class MasterKolektifService : IMasterKolektifService
    {
        private readonly IMasterKolektif kolektif;

        public MasterKolektifService(IPersistence persistence)
        {
            kolektif = persistence.MasterKolektif;
        }

        public async Task<IEnumerable<MasterKolektifDto>> GetAll(MasterKolektifDto param)
        {
            return await kolektif.GetAllAsync(param);
        }

       
    }
}
