using AppBusiness.Data.DTOs;
using AppPersistence.Interface;
using AppPersistence.Mysql.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPersistence.Mysql.Repositories
{
    public class MasterGolonganRepository : IMasterGolongan
    {
        private readonly IMapper _mapper;

        public MasterGolonganRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<MasterGolonganDto>> GetAllAsync(MasterGolonganDto param)
        {
            using var context = new AppDbContext();

            IQueryable<MasterGolongan> query = context.MasterGolongan;          

           
            if (!string.IsNullOrWhiteSpace(param.KodeGol))
                query = query.Where(n => n.KodeGol == param.KodeGol);

            if (!string.IsNullOrWhiteSpace(Convert.ToString(param.PeriodeMulaiBerlaku)))
                query = query.Where(n => n.PeriodeMulaiBerlaku == param.PeriodeMulaiBerlaku);

            if (!string.IsNullOrWhiteSpace(param.NamaGolongan))
                query = query.Where(n => EF.Functions.Like(n.NamaGolongan, $"%{param.NamaGolongan}%"));

            if (!string.IsNullOrWhiteSpace(Convert.ToString(param.Status)))
                query = query.Where(n => n.Status == param.Status);


            var data = await query.ToListAsync();

            return _mapper.Map<IEnumerable<MasterGolonganDto>>(data);
        }

       
    }
}
