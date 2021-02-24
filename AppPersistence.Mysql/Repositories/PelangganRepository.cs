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
    public class PelangganRepository : IPelanggan
    {
        private readonly IMapper _mapper;

        public PelangganRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<PelangganDTo>> GetAllAsync(int limit, PelangganDTo param)
        {
            using var context = new AppDbContext();

            IQueryable<Pelanggan> query = context.Pelanggan;

            if (!string.IsNullOrWhiteSpace(param.KodeRayon))
                query = query.Where(n => n.KodeRayon == param.KodeRayon);

            if (!string.IsNullOrWhiteSpace(param.NoSamb))
                query = query.Where(n => n.NoSamb == param.NoSamb);

            if (!string.IsNullOrWhiteSpace(param.Nama))
                query = query.Where(n => EF.Functions.Like(n.Nama, $"%{param.Nama}%"));

            if (!string.IsNullOrWhiteSpace(param.Alamat))
                query = query.Where(n => EF.Functions.Like(n.Alamat, $"%{param.Alamat}%"));

            var data = await query.Take(limit).ToListAsync();

            return _mapper.Map<IEnumerable<PelangganDTo>>(data);
        }

    }
}

