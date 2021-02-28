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
    public class MasterKecamatanRepository : IMasterKecamatan
    {       
        private readonly IMapper _mapper;

        public MasterKecamatanRepository(IMapper mapper)
        {          
            _mapper = mapper;
        }

        public async Task<IEnumerable<MasterKecamatanDTo>> GetAllAsync(MasterKecamatanDTo param)
        {
            using var context = new AppDbContext();

            IQueryable<MasterKecamatan> query = (from kecamatan in context.MasterKecamatan
                                            join cabang in context.MasterCabang on kecamatan.KodeCabang equals cabang.KodeCabang into gCabang
                                            from cabang in gCabang.DefaultIfEmpty()
                                            select new MasterKecamatan()
                                            {
                                                KodeKecamatan = kecamatan.KodeKecamatan,
                                                NamaKecamatan = kecamatan.NamaKecamatan,
                                                KodeCabang = kecamatan.KodeCabang,
                                                MasterCabang = kecamatan.MasterCabang,
                                            });

            if (!string.IsNullOrWhiteSpace(param.KodeKecamatan))
                query = query.Where(n => n.KodeKecamatan == param.KodeKecamatan);

            if (!string.IsNullOrWhiteSpace(param.NamaKecamatan))
                query = query.Where(n => EF.Functions.Like(n.NamaKecamatan, $"%{param.NamaKecamatan}%"));

            if (!string.IsNullOrWhiteSpace(param.KodeCabang))
                query = query.Where(n => n.KodeCabang == param.KodeCabang);

            var data = await query.ToListAsync();

            return _mapper.Map<IEnumerable<MasterKecamatanDTo>>(data);
        }
    }
}
