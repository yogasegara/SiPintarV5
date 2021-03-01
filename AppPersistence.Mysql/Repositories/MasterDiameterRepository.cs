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
    public class MasterDiameterRepository : IMasterDiameter
    {
        private readonly IMapper _mapper;

        public MasterDiameterRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<MasterDiameterDto>> GetAllAsync(MasterDiameterDto param)
        {
            using var context = new AppDbContext();

            IQueryable<MasterDiameter> query = context.MasterDiameter;          

           
            if (!string.IsNullOrWhiteSpace(param.KodeDiameter))
                query = query.Where(n => n.KodeDiameter == param.KodeDiameter);

            if (!string.IsNullOrWhiteSpace(Convert.ToString(param.PeriodeMulaiBerlaku)))
                query = query.Where(n => n.PeriodeMulaiBerlaku == param.PeriodeMulaiBerlaku);

            if (!string.IsNullOrWhiteSpace(param.NamaDiameter))
                query = query.Where(n => EF.Functions.Like(n.NamaDiameter, $"%{param.NamaDiameter}%"));

            if (!string.IsNullOrWhiteSpace(Convert.ToString(param.Status)))
                query = query.Where(n => n.Status == param.Status);



            var data = await query.ToListAsync();

            return _mapper.Map<IEnumerable<MasterDiameterDto>>(data);
        }

       
    }
}
