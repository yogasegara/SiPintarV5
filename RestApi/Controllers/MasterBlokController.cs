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
    public class MasterBlokController : ControllerBase
    {

        private readonly IMasterBlokService BlokService;

        public MasterBlokController([FromServices] IBusiness business)
        {
            BlokService = business.IMasterBlokService;
        }

        [HttpGet]
        public async Task<JsonResult> Get(string kodeBlok, string namaBlok, string koderayon)
        {
            var watch = Stopwatch.StartNew();

            try
            {
                var param = new MasterBlokDto()
                {
                    KodeBlok = kodeBlok,
                    NamaBlok = namaBlok,
                    KodeRayon = koderayon,
                };

                AppResponse.ResponseGetData(await BlokService.GetAll(param));
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
