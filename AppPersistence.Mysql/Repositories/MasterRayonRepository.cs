﻿using AppBusiness.Data.DTOs;
using AppPersistence.Interface;
using AppPersistence.Mysql.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPersistence.Mysql.Repositories
{
    public class MasterRayonRepository : IMasterRayon
    {
        private readonly IMapper _mapper;

        public MasterRayonRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<MasterRayonDto>> GetAllAsync(MasterRayonDto param)
        {
            using var context = new AppDbContext();

            IQueryable<MasterRayon> query = context.MasterRayon;


            if (!string.IsNullOrWhiteSpace(param.KodeRayon))
                query = query.Where(n => n.KodeRayon == param.KodeRayon);

            if (!string.IsNullOrWhiteSpace(param.NamaRayon))
                query = query.Where(n => EF.Functions.Like(n.NamaRayon, $"%{param.NamaRayon}%"));

            if (!string.IsNullOrWhiteSpace(param.KodeArea))
                query = query.Where(n => n.KodeArea == param.KodeArea);

            if (!string.IsNullOrWhiteSpace(param.NamaArea))
                query = query.Where(n => EF.Functions.Like(n.NamaArea, $"%{param.NamaArea}%"));

            if (!string.IsNullOrWhiteSpace(param.KodeWil))
                query = query.Where(n => n.KodeWil == param.KodeWil);

            if (!string.IsNullOrWhiteSpace(param.NamaWilayah))
                query = query.Where(n => EF.Functions.Like(n.NamaWilayah, $"%{param.NamaWilayah}%"));


            var data = await query.ToListAsync();

            return _mapper.Map<IEnumerable<MasterRayonDto>>(data);
        }
    }
}
