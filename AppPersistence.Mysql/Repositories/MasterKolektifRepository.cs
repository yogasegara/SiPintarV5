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
    public class MasterKolektifRepository : IMasterKolektif
    {
        private readonly IMapper _mapper;

        public MasterKolektifRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<MasterKolektifDto>> GetAllAsync(MasterKolektifDto param)
        {
            using var context = new AppDbContext();

            IQueryable<MasterKolektif> query = context.MasterKolektif;          

           
            if (!string.IsNullOrWhiteSpace(param.KodeKolektif))
                query = query.Where(n => n.KodeKolektif == param.KodeKolektif);           

            if (!string.IsNullOrWhiteSpace(param.NamaKolektif))
                query = query.Where(n => EF.Functions.Like(n.NamaKolektif, $"%{param.NamaKolektif}%"));

           
            var data = await query.ToListAsync();

            return _mapper.Map<IEnumerable<MasterKolektifDto>>(data);
        }

       
    }
}
