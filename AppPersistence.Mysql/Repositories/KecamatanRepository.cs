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
    public class KecamatanRepository : IKecamatan
    {       
        private readonly IMapper _mapper;

        public KecamatanRepository(IMapper mapper)
        {          
            _mapper = mapper;
        }

        public async Task<IEnumerable<KecamatanDTo>> GetAllAsync(KecamatanDTo param)
        {
            using var context = new AppDbContext();

            IQueryable<Kecamatan> query = context.Kecamatan;

            if (!string.IsNullOrWhiteSpace(param.KodeKecamatan))
                query = query.Where(n => n.KodeKecamatan == param.KodeKecamatan);

            if (!string.IsNullOrWhiteSpace(param.NamaKecamatan))
                query = query.Where(n => EF.Functions.Like(n.NamaKecamatan, $"%{param.NamaKecamatan}%"));

            if (!string.IsNullOrWhiteSpace(param.KodeCabang))
                query = query.Where(n => n.KodeCabang == param.KodeCabang);

            var data = await query.ToListAsync();

            return _mapper.Map<IEnumerable<KecamatanDTo>>(data);
        }
    }
}
