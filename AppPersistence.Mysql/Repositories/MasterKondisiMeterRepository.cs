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
    public class MasterKondisiMeterRepository : IMasterKondisiMeter
    {       
        private readonly IMapper _mapper;

        public MasterKondisiMeterRepository(IMapper mapper)
        {          
            _mapper = mapper;
        }

        public async Task<IEnumerable<MasterKondisiMeterDto>> GetAllAsync(MasterKondisiMeterDto param)
        {
            using var context = new AppDbContext();

            IQueryable<MasterKondisiMeter> query = context.MasterKondisiMeter;

            if (!string.IsNullOrWhiteSpace(param.KodeKondisiMeter))
                query = query.Where(n => n.KodeKondisiMeter == param.KodeKondisiMeter);

            if (!string.IsNullOrWhiteSpace(param.NamaKondisiMeter))
                query = query.Where(n => EF.Functions.Like(n.NamaKondisiMeter, $"%{param.NamaKondisiMeter}%"));

            var data = await query.ToListAsync();

            return _mapper.Map<IEnumerable<MasterKondisiMeterDto>>(data);
        }
    }
}
