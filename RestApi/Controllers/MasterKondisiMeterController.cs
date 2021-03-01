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
    public class MasterKondisiMeterController : ControllerBase
    {

        private readonly IMasterKondisiMeterService KondisiMeterService;

        public MasterKondisiMeterController([FromServices] IBusiness business)
        {
            KondisiMeterService = business.IMasterKondisiMeterService;
        }

        [HttpGet]
        public async Task<JsonResult> Get(string kodeKondisiMeter, string namaKondisiMeter)
        {
            var watch = Stopwatch.StartNew();

            try
            {
                var param = new MasterKondisiMeterDto()
                {
                    KodeKondisiMeter = kodeKondisiMeter,
                    NamaKondisiMeter = namaKondisiMeter
                };

                AppResponse.ResponseGetData(await KondisiMeterService.GetAll(param));
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
