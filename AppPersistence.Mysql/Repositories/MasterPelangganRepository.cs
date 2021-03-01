using AppBusiness.Data.DTOs;
using AppPersistence.Interface;
using AppPersistence.Mysql.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPersistence.Mysql.Repositories
{
    public class MasterPelangganRepository : IMasterPelanggan
    {
        private readonly IMapper _mapper;

        public MasterPelangganRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<MasterPelangganDto>> GetAllAsync(int limit, MasterPelangganDto param)
        {
            using var context = new AppDbContext();

            IQueryable<MasterPelanggan> query = (from pelanggan in context.MasterPelanggan.Where(c => c.FlagHapus == false)

                                                 join rayon in context.MasterRayon on pelanggan.KodeRayon equals rayon.KodeRayon into gRayon
                                                 from rayon in gRayon.DefaultIfEmpty()

                                                 join kelurahan in context.MasterKelurahan on pelanggan.KodeKelurahan equals kelurahan.KodeKelurahan into gKelurahan
                                                 from kelurahan in gKelurahan.DefaultIfEmpty()

                                                 join diameter in context.MasterDiameter.Where(c => c.Status == true) on pelanggan.KodeDiameter equals diameter.KodeDiameter into gDiameter
                                                 from diameter in gDiameter.DefaultIfEmpty()

                                                 join golongan in context.MasterGolongan.Where(c => c.Status == true) on pelanggan.KodeGol equals golongan.KodeGol into gGolongan
                                                 from golongan in gGolongan.DefaultIfEmpty()

                                                 join kolektif in context.MasterKolektif on pelanggan.KodeKolektif equals kolektif.KodeKolektif into gKolektif
                                                 from kolektif in gKolektif.DefaultIfEmpty()

                                                 join kondisimeter in context.MasterKondisiMeter on pelanggan.KodeKondisiMeter equals kondisimeter.KodeKondisiMeter into gKondisiMeter
                                                 from kondisimeter in gKondisiMeter.DefaultIfEmpty()

                                                 join sumberair in context.MasterSumberAir on pelanggan.KodeSumberAir equals sumberair.KodeSumberAir into gSumberair
                                                 from sumberair in gSumberair.DefaultIfEmpty()

                                                 join blok in context.MasterBlok on pelanggan.KodeBlok equals blok.KodeBlok into gBlok
                                                 from blok in gBlok.DefaultIfEmpty()

                                                 join merekmeter in context.MasterMerekMeter on pelanggan.KodeMerekMeter equals merekmeter.KodeMerekMeter into gMerekmeter
                                                 from merekmeter in gMerekmeter.DefaultIfEmpty()

                                                 select new MasterPelanggan()
                                                 {
                                                     #region field from models
                                                     NoSamb = pelanggan.NoSamb,
                                                     Nama = pelanggan.Nama,
                                                     Alamat = pelanggan.Alamat,
                                                     KodeRayon = pelanggan.KodeRayon,
                                                     KodeKelurahan = pelanggan.KodeKelurahan,
                                                     KodeGol = pelanggan.KodeGol,
                                                     KodeDiameter = pelanggan.KodeDiameter,
                                                     KodeKolektif = pelanggan.KodeKolektif,
                                                     KodeKondisiMeter = pelanggan.KodeKondisiMeter,
                                                     KodeSumberAir = pelanggan.KodeSumberAir,
                                                     KodeBlok = pelanggan.KodeBlok,
                                                     KodeMerekMeter = pelanggan.KodeMerekMeter,
                                                     KodeAdministrasiLain = pelanggan.KodeAdministrasiLain,
                                                     KodePemeliharaanLain = pelanggan.KodePemeliharaanLain,
                                                     KodeRetribusiLain = pelanggan.KodeRetribusiLain,
                                                     NoHp = pelanggan.NoHp,
                                                     NoTelp = pelanggan.NoTelp,
                                                     NoKtp = pelanggan.NoKtp,
                                                     NoSegelMeter = pelanggan.NoSegelMeter,
                                                     NoRekening = pelanggan.NoRekening,
                                                     NoPendaftaran = pelanggan.NoPendaftaran,
                                                     NoRab = pelanggan.NoRab,
                                                     SeriMeter = pelanggan.SeriMeter,
                                                     Status = pelanggan.Status,
                                                     KepemilikanBangunan = pelanggan.KepemilikanBangunan,
                                                     NamaPemilik = pelanggan.NamaPemilik,
                                                     Pekerjaan = pelanggan.Pekerjaan,
                                                     Penghuni = pelanggan.Penghuni,
                                                     Flag = pelanggan.Flag,
                                                     Keterangan = pelanggan.Keterangan,
                                                     AdaAngsuran = pelanggan.AdaAngsuran,
                                                     LuasRumah = pelanggan.LuasRumah,
                                                     Email = pelanggan.Email,
                                                     TglDaftar = pelanggan.TglDaftar,
                                                     TglMeter = pelanggan.TglMeter,
                                                     UrutanBaca = pelanggan.UrutanBaca,
                                                     StanAwalPasang = pelanggan.StanAwalPasang,
                                                     FlagHapus = pelanggan.FlagHapus,
                                                     NosambBaru = pelanggan.NosambBaru,
                                                     KeteranganHapus = pelanggan.KeteranganHapus,
                                                     TglHapus = pelanggan.TglHapus,
                                                     TglPutus = pelanggan.TglPutus,
                                                     #endregion

                                                     #region Virtual
                                                     MasterRayon = pelanggan.MasterRayon,
                                                     MasterKelurahan = pelanggan.MasterKelurahan,
                                                     MasterDiameter = pelanggan.MasterDiameter,
                                                     MasterGolongan = pelanggan.MasterGolongan,
                                                     MasterKolektif = pelanggan.MasterKolektif,
                                                     MasterKondisiMeter = pelanggan.MasterKondisiMeter,
                                                     MasterSumberAir = pelanggan.MasterSumberAir,
                                                     MasterBlok = pelanggan.MasterBlok,
                                                     MasterMerekMeter = pelanggan.MasterMerekMeter,


                                                     #endregion
                                                 });
            #region where clouse

            if (!string.IsNullOrWhiteSpace(param.NoSamb))
                query = query.Where(n => n.NoSamb == param.NoSamb);

            if (!string.IsNullOrWhiteSpace(param.Nama))
                query = query.Where(n => EF.Functions.Like(n.Nama, $"%{param.Nama}%"));

            if (!string.IsNullOrWhiteSpace(param.Alamat))
                query = query.Where(n => EF.Functions.Like(n.Alamat, $"%{param.Alamat}%"));

            if (!string.IsNullOrWhiteSpace(param.KodeRayon))
                query = query.Where(n => n.KodeRayon == param.KodeRayon);

            if (!string.IsNullOrWhiteSpace(param.KodeKelurahan))
                query = query.Where(n => n.KodeKelurahan == param.KodeKelurahan);

            if (!string.IsNullOrWhiteSpace(param.KodeGol))
                query = query.Where(n => n.KodeGol == param.KodeGol);

            if (!string.IsNullOrWhiteSpace(param.KodeDiameter))
                query = query.Where(n => n.KodeDiameter == param.KodeDiameter);

            if (!string.IsNullOrWhiteSpace(param.KodeKolektif))
                query = query.Where(n => n.KodeKolektif == param.KodeKolektif);

            if (!string.IsNullOrWhiteSpace(param.KodeKondisiMeter))
                query = query.Where(n => n.KodeKondisiMeter == param.KodeKondisiMeter);

            if (!string.IsNullOrWhiteSpace(param.KodeSumberAir))
                query = query.Where(n => n.KodeSumberAir == param.KodeSumberAir);

            if (!string.IsNullOrWhiteSpace(param.KodeBlok))
                query = query.Where(n => n.KodeBlok == param.KodeBlok);

            if (!string.IsNullOrWhiteSpace(param.KodeMerekMeter))
                query = query.Where(n => n.KodeMerekMeter == param.KodeMerekMeter);

            if (!string.IsNullOrWhiteSpace(param.NoHp))
                query = query.Where(n => n.NoHp == param.NoHp);

            if (!string.IsNullOrWhiteSpace(param.NoTelp))
                query = query.Where(n => n.NoTelp == param.NoTelp);

            if (!string.IsNullOrWhiteSpace(param.NoKtp))
                query = query.Where(n => n.NoKtp == param.NoKtp);

            if (!string.IsNullOrWhiteSpace(param.NoRekening))
                query = query.Where(n => n.NoRekening == param.NoRekening);

            if (!string.IsNullOrWhiteSpace(param.SeriMeter))
                query = query.Where(n => n.SeriMeter == param.SeriMeter);

            if (!string.IsNullOrWhiteSpace(Convert.ToString(param.Status)))
                query = query.Where(n => n.Status == param.Status);

            if (!string.IsNullOrWhiteSpace(Convert.ToString(param.Flag)))
                query = query.Where(n => n.Flag == param.Flag);

            if (!string.IsNullOrWhiteSpace(param.Email))
                query = query.Where(n => n.Email == param.Email);

            if (!string.IsNullOrWhiteSpace(Convert.ToString(param.TglDaftar)))
                query = query.Where(n => n.TglDaftar == param.TglDaftar);


            #endregion

            var data = await query.Take(limit).ToListAsync();

            return _mapper.Map<IEnumerable<MasterPelangganDto>>(data);
        }

    }
}

