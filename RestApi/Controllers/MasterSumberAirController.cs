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
    public class MasterSumberAirController : ControllerBase
    {

        private readonly IMasterSumberAirService SumberAirService;

        public MasterSumberAirController([FromServices] IBusiness business)
        {
            SumberAirService = business.IMasterSumberAirService;
        }

        [HttpGet]
        public async Task<JsonResult> Get(string kodeSumberAir, string namaSumberAir)
        {
            var watch = Stopwatch.StartNew();

            try
            {
                var param = new MasterSumberAirDto()
                {
                    KodeSumberAir = kodeSumberAir,
                    NamaSumberAir = namaSumberAir
                };

                AppResponse.ResponseGetData(await SumberAirService.GetAll(param));
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
