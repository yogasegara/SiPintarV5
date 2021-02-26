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

            IQueryable<Pelanggan> query = (from pelanggan in context.Pelanggan
                                           join rayon in context.MasterRayon on pelanggan.KodeRayon equals rayon.KodeRayon into gRayon
                                           from rayon in gRayon.DefaultIfEmpty()
                                           join kelurahan in context.Kelurahan on pelanggan.KodeKelurahan equals kelurahan.KodeKelurahan into gKelurahan
                                           from kelurahan in gKelurahan.DefaultIfEmpty()
                                           select new Pelanggan()
                                           {
                                               #region field from models
                                               Nama = pelanggan.Nama,
                                               NoSamb = pelanggan.NoSamb,
                                               Alamat = pelanggan.Alamat,
                                               KodeRayon = pelanggan.KodeRayon,
                                               KodeKelurahan = pelanggan.KodeKelurahan,
                                               KodeGol = pelanggan.KodeGol,
                                               KodeDiameter = pelanggan.KodeDiameter,
                                               KodeKolektif = pelanggan.KodeKolektif,
                                               NoHp = pelanggan.NoHp,
                                               NoRekening = pelanggan.NoRekening,
                                               NoTelp = pelanggan.NoTelp,
                                               #endregion

                                               #region Virtual
                                               MasterRayon = pelanggan.MasterRayon,
                                               Kelurahan = pelanggan.Kelurahan,
                                               #endregion
                                           });
            #region where clouse

            if (!string.IsNullOrWhiteSpace(param.KodeRayon))
                query = query.Where(n => n.KodeRayon == param.KodeRayon);

            if (!string.IsNullOrWhiteSpace(param.NoSamb))
                query = query.Where(n => n.NoSamb == param.NoSamb);

            if (!string.IsNullOrWhiteSpace(param.Nama))
                query = query.Where(n => EF.Functions.Like(n.Nama, $"%{param.Nama}%"));

            if (!string.IsNullOrWhiteSpace(param.Alamat))
                query = query.Where(n => EF.Functions.Like(n.Alamat, $"%{param.Alamat}%"));

            #endregion

            var data = await query.Take(limit).ToListAsync();

            return _mapper.Map<IEnumerable<PelangganDTo>>(data);
        }

    }
}

