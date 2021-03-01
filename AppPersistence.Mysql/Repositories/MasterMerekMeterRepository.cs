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
    public class MasterMerekMeterRepository : IMasterMerekMeter
    {       
        private readonly IMapper _mapper;

        public MasterMerekMeterRepository(IMapper mapper)
        {          
            _mapper = mapper;
        }

        public async Task<IEnumerable<MasterMerekMeterDto>> GetAllAsync(MasterMerekMeterDto param)
        {
            using var context = new AppDbContext();

            IQueryable<MasterMerekMeter> query = context.MasterMerekMeter;

            if (!string.IsNullOrWhiteSpace(param.KodeMerekMeter))
                query = query.Where(n => n.KodeMerekMeter == param.KodeMerekMeter);

            if (!string.IsNullOrWhiteSpace(param.NamaMerekMeter))
                query = query.Where(n => EF.Functions.Like(n.NamaMerekMeter, $"%{param.NamaMerekMeter}%"));

            var data = await query.ToListAsync();

            return _mapper.Map<IEnumerable<MasterMerekMeterDto>>(data);
        }
    }
}
