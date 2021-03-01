using AppBusiness.Data.DTOs;
using AppPersistence.Interface;
using AppPersistence.Mysql.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPersistence.Mysql.Repositories
{
    public class MasterSumberAirRepository : IMasterSumberAir
    {       
        private readonly IMapper _mapper;

        public MasterSumberAirRepository(IMapper mapper)
        {          
            _mapper = mapper;
        }

        public async Task<IEnumerable<MasterSumberAirDto>> GetAllAsync(MasterSumberAirDto param)
        {
            using var context = new AppDbContext();

            IQueryable<MasterSumberAir> query = context.MasterSumberAir;

            if (!string.IsNullOrWhiteSpace(param.KodeSumberAir))
                query = query.Where(n => n.KodeSumberAir == param.KodeSumberAir);

            if (!string.IsNullOrWhiteSpace(param.NamaSumberAir))
                query = query.Where(n => EF.Functions.Like(n.NamaSumberAir, $"%{param.NamaSumberAir}%"));

            var data = await query.ToListAsync();

            return _mapper.Map<IEnumerable<MasterSumberAirDto>>(data);
        }
    }
}
