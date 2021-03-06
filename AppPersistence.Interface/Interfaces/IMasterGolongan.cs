﻿using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IMasterGolongan
    {
        Task<IEnumerable<MasterGolonganDto>> GetAllAsync(MasterGolonganDto param);       
    }

}