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
    public class MasterKelurahanRepository : IMasterKelurahan
    {
        private readonly IMapper _mapper;

        public MasterKelurahanRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<MasterKelurahanDto>> GetAllAsync(MasterKelurahanDto param)
        {
            using var context = new AppDbContext();

            IQueryable<MasterKelurahan> query = context.MasterKelurahan;

            if (!string.IsNullOrWhiteSpace(param.KodeKelurahan))
                query = query.Where(n => n.KodeKelurahan == param.KodeKelurahan);

            if (!string.IsNullOrWhiteSpace(param.NamaKelurahan))
                query = query.Where(n => EF.Functions.Like(n.NamaKelurahan, $"%{param.NamaKelurahan}%"));

            if (!string.IsNullOrWhiteSpace(param.KodeKecamatan))
                query = query.Where(n => n.KodeKecamatan == param.KodeKecamatan);

            if (!string.IsNullOrWhiteSpace(param.NamaKecamatan))
                query = query.Where(n => EF.Functions.Like(n.NamaKecamatan, $"%{param.NamaKecamatan}%"));

            if (!string.IsNullOrWhiteSpace(param.KodeCabang))
                query = query.Where(n => n.KodeCabang == param.KodeCabang);

            if (!string.IsNullOrWhiteSpace(param.NamaCabang))
                query = query.Where(n => EF.Functions.Like(n.NamaCabang, $"%{param.NamaCabang}%"));

            var data = await query.ToListAsync();

            return _mapper.Map<IEnumerable<MasterKelurahanDto>>(data);
        }
    }
}
