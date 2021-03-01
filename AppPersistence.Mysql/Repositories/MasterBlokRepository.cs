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
    public class MasterBlokRepository : IMasterBlok
    {       
        private readonly IMapper _mapper;

        public MasterBlokRepository(IMapper mapper)
        {          
            _mapper = mapper;
        }

        public async Task<IEnumerable<MasterBlokDto>> GetAllAsync(MasterBlokDto param)
        {
            using var context = new AppDbContext();

            IQueryable<MasterBlok> query = context.MasterBlok;

            if (!string.IsNullOrWhiteSpace(param.KodeBlok))
                query = query.Where(n => n.KodeBlok == param.KodeBlok);

            if (!string.IsNullOrWhiteSpace(param.NamaBlok))
                query = query.Where(n => EF.Functions.Like(n.NamaBlok, $"%{param.NamaBlok}%"));

            if (!string.IsNullOrWhiteSpace(param.KodeRayon))
                query = query.Where(n => n.KodeRayon == param.KodeRayon);

            var data = await query.ToListAsync();

            return _mapper.Map<IEnumerable<MasterBlokDto>>(data);
        }
    }
}
