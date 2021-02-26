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
    [Route("[controller]")]
    public class KelurahanController : ControllerBase
    {

        private readonly IKelurahanService kelurahanService;

        public KelurahanController([FromServices] IBusiness business)
        {
            kelurahanService = business.IKelurahanService;
        }

        [HttpGet]
        public async Task<JsonResult> Get(string kodekelurahan, string namakelurahan, string kodekecamatan)
        {
            var watch = Stopwatch.StartNew();

            try
            {
                var param = new KelurahanDTo()
                {
                    KodeKelurahan = kodekelurahan,
                    NamaKelurahan = namakelurahan,
                    KodeKecamatan = kodekecamatan
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
