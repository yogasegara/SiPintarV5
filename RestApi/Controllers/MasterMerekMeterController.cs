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
    public class MasterMerekMeterController : ControllerBase
    {

        private readonly IMasterMerekMeterService MerekMeterService;

        public MasterMerekMeterController([FromServices] IBusiness business)
        {
            MerekMeterService = business.IMasterMerekMeterService;
        }

        [HttpGet]
        public async Task<JsonResult> Get(string kodeMerekMeter, string namaMerekMeter)
        {
            var watch = Stopwatch.StartNew();

            try
            {
                var param = new MasterMerekMeterDto()
                {
                    KodeMerekMeter = kodeMerekMeter,
                    NamaMerekMeter = namaMerekMeter
                };

                AppResponse.ResponseGetData(await MerekMeterService.GetAll(param));
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
