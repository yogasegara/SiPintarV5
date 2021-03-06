﻿using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IMasterCabangService
    {
        Task<IEnumerable<MasterCabangDto>> GetAll(MasterCabangDto param);
    }
}