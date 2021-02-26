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
    public class MasterWilayahController : ControllerBase
    {           

        private readonly IWilayahService wilayahService;

        public MasterWilayahController([FromServices]IBusiness business)
        {
            wilayahService = business.IWilayahService;
        }

        [HttpGet]
        public async Task<JsonResult> Get(string kodewil, string namawilayah)
        {
            var watch = Stopwatch.StartNew();

            try
            {
                var param = new MasterWilayahDto()
                {
                    KodeWil = kodewil,
                    NamaWilayah = namawilayah
                };

                AppResponse.ResponseGetData(await wilayahService.GetAll(param));
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
