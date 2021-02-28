using AppBusiness.Data.DTOs;
using AppBusiness.Data.Responses;
using AppBusiness.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("Master/[controller]")]
    public class MasterKelurahanController : ControllerBase
    {

        private readonly IMasterKelurahanService kelurahanService;

        public MasterKelurahanController([FromServices] IBusiness business)
        {
            kelurahanService = business.IMasterKelurahanService;
        }

        [HttpGet]
        public async Task<JsonResult> Get(string kodekelurahan, string namakelurahan, string kodekecamatan, string namakecamatan, string kodecabang, string namacabang )
        {
            var watch = Stopwatch.StartNew();

            try
            {
                var param = new MasterKelurahanDTo()
                {
                    KodeKelurahan = kodekelurahan,
                    NamaKelurahan = namakelurahan,
                    KodeKecamatan = kodekecamatan,
                    NamaKecamatan = namakecamatan,
                    KodeCabang = kodecabang,
                    NamaCabang = namacabang,
                };

                AppResponse.ResponseGetData(await kelurahanService.GetAll(param));
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
