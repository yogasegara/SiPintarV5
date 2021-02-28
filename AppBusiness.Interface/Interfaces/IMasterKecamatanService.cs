﻿using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IMasterKecamatanService
    {
        Task<IEnumerable<MasterKecamatanDTo>> GetAll(MasterKecamatanDTo param);
    }
}