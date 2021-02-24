﻿using AppBusiness.Data.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPersistence.Interface
{
    public interface IRayon
    {
        Task<IEnumerable<RayonDTo>> GetAllAsync(RayonDTo param);
    }
}