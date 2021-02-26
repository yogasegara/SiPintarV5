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
    public class KelurahanRepository : IKelurahan
    {       
        private readonly IMapper _mapper;

        public KelurahanRepository(IMapper mapper)
        {          
            _mapper = mapper;
        }

        public async Task<IEnumerable<KelurahanDTo>> GetAllAsync(KelurahanDTo param)
        {
            using var context = new AppDbContext();

            IQueryable<Kelurahan> query = (from kelurahan in context.Kelurahan
                                           join kecamatan in context.Kecamatan on kelurahan.KodeKecamatan equals kecamatan.KodeKecamatan into gKecamatan
                                           from kecamatan in gKecamatan.DefaultIfEmpty()                                          
                                           select new Kelurahan()
                                           {
                                              KodeKelurahan = kelurahan.KodeKelurahan,
                                              NamaKelurahan = kelurahan.NamaKelurahan,
                                              KodeKecamatan = kelurahan.KodeKecamatan,
                                              Kecamatan = kelurahan.Kecamatan,
                                              JumlahJiwa = kelurahan.JumlahJiwa
                                           });

            if (!string.IsNullOrWhiteSpace(param.KodeKelurahan))
                query = query.Where(n => n.KodeKelurahan == param.KodeKelurahan);

            if (!string.IsNullOrWhiteSpace(param.NamaKelurahan))
                query = query.Where(n => EF.Functions.Like(n.NamaKelurahan, $"%{param.NamaKelurahan}%"));

            if (!string.IsNullOrWhiteSpace(param.KodeKecamatan))
                query = query.Where(n => n.KodeKecamatan == param.KodeKecamatan);
           

            var data = await query.ToListAsync();

            return _mapper.Map<IEnumerable<KelurahanDTo>>(data);
        }
    }
}
