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
    public class MasterWilayahRepository : IMasterWilayah
    {       
        private readonly IMapper _mapper;

        public MasterWilayahRepository(IMapper mapper)
        {          
            _mapper = mapper;
        }

        public async Task<IEnumerable<MasterWilayahDto>> GetAllAsync(MasterWilayahDto param)
        {
            using var context = new AppDbContext();

            IQueryable<MasterWilayah> query = context.MasterWilayah;

            if (!string.IsNullOrWhiteSpace(param.KodeWil))
                query = query.Where(n => n.KodeWil == param.KodeWil);

            if (!string.IsNullOrWhiteSpace(param.NamaWilayah))
                query = query.Where(n => EF.Functions.Like(n.NamaWilayah, $"%{param.NamaWilayah}%"));          


            var data = await query.ToListAsync();

            return _mapper.Map<IEnumerable<MasterWilayahDto>>(data);
        }
    }
}
