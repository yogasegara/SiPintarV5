using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IMasterKolektif
    {
        Task<IEnumerable<MasterKolektifDto>> GetAllAsync(MasterKolektifDto param);       
    }

}