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
    public class AreaRepository : IArea
    {
        private readonly IMapper _mapper;

        public AreaRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<MasterAreaDto>> GetAllAsync(MasterAreaDto param)
        {
            using var context = new AppDbContext();

            IQueryable<MasterArea> query = (from area in context.MasterArea
                                            join wilayah in context.MasterWilayah on area.KodeWil equals wilayah.KodeWil into gWilayah
                                            from wilayah in gWilayah.DefaultIfEmpty()
                                            select new MasterArea()
                                            {
                                                KodeArea = area.KodeArea,
                                                NamaArea = area.NamaArea,
                                                KodeWil = area.KodeWil,
                                                MasterWilayah = area.MasterWilayah,

                                            });

            if (!string.IsNullOrWhiteSpace(param.KodeArea))
                query = query.Where(n => n.KodeArea == param.KodeArea);

            if (!string.IsNullOrWhiteSpace(param.NamaArea))
                query = query.Where(n => EF.Functions.Like(n.NamaArea, $"%{param.NamaArea}%"));

            if (!string.IsNullOrWhiteSpace(param.KodeWil))
                query = query.Where(n => n.KodeWil == param.KodeWil);

            var data = await query.ToListAsync();

            return _mapper.Map<IEnumerable<MasterAreaDto>>(data);
        }



    }
}
