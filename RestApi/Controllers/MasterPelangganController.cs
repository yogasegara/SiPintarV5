using AppBusiness.Data.DTOs;
using AppBusiness.Data.Responses;
using AppBusiness.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("Master/[controller]")]
    public class MasterPelangganController : ControllerBase
    {

        private readonly IMasterPelangganService pelangganService;

        public MasterPelangganController([FromServices] IBusiness business)
        {
            pelangganService = business.IMasterPelangganService;
        }

        [HttpGet]
        public async Task<JsonResult> Get(int limit, string nosamb, string nama, string alamat, string koderayon, string kodekelurahan,
            string kodegol, string kodediameter, string kodekolektif, string kodekondisimeter, string kodesumberair, string kodeblok, string kodemerekmeter,
            string nohp, string notelp, string noktp, string norekening, string serimeter, int? status, int? flag, string email, DateTime? tgldaftar)
        {
            var watch = Stopwatch.StartNew();

            try
            {
                var param = new MasterPelangganDto()
                {
                    NoSamb = nosamb,
                    Nama = nama,
                    Alamat = alamat,
                    KodeRayon = koderayon,
                    KodeKelurahan = kodekelurahan,
                    KodeGol = kodegol,
                    KodeDiameter = kodediameter,
                    KodeKolektif = kodekolektif,
                    KodeKondisiMeter = kodekondisimeter,
                    KodeSumberAir = kodesumberair,
                    KodeBlok = kodeblok,
                    KodeMerekMeter = kodemerekmeter,
                    NoHp = nohp,
                    NoTelp = notelp,
                    NoKtp = noktp,
                    NoRekening = norekening,
                    SeriMeter = serimeter,
                    Status = status,
                    Flag = flag,
                    Email = email,
                    TglDaftar = tgldaftar,

                };

                AppResponse.ResponseGetData(await pelangganService.GetAll(limit, param));
            }
            catch (Exception e)
            {
                AppResponse.ResponseErrorGetData(e.InnerException != null ? e.InnerException.Message : e.Message);
            }

            watch.Stop();
            AppResponse._result.execution_time = watch.ElapsedMilliseconds;
            return new JsonResult(AppResponse._result);
        }
    }
}
