﻿using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppBusiness.Interface
{
    public interface IMasterGolonganService
    {
        Task<IEnumerable<MasterGolonganDto>> GetAll(MasterGolonganDto param);
       
    }
}