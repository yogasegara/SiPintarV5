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
    public class CabangRepository : ICabang
    {       
        private readonly IMapper _mapper;

        public CabangRepository(IMapper mapper)
        {          
            _mapper = mapper;
        }

        public async Task<IEnumerable<CabangDTo>> GetAllAsync(CabangDTo param)
        {
            using var context = new AppDbContext();

            IQueryable<Cabang> query = context.Cabang;

            if (!string.IsNullOrWhiteSpace(param.KodeCabang))
                query = query.Where(n => n.KodeCabang == param.KodeCabang);

            if (!string.IsNullOrWhiteSpace(param.NamaCabang))
                query = query.Where(n => EF.Functions.Like(n.NamaCabang, $"%{param.NamaCabang}%"));

            var data = await query.ToListAsync();

            return _mapper.Map<IEnumerable<CabangDTo>>(data);
        }
    }
}
