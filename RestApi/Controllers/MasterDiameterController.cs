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
    public class MasterDiameterController : ControllerBase
    {           

        private readonly IMasterDiameterService diameterService;

        public MasterDiameterController([FromServices]IBusiness business)
        {
            diameterService = business.IMasterDiameterService;
        }

        [HttpGet]    
        public async Task<JsonResult> Get(string kodediameter, int? periodemulaiberlaku, string namadiameter, bool? status)
        {
            var watch = Stopwatch.StartNew();

            try
            {
                var param = new MasterDiameterDto()
                {
                    KodeDiameter = kodediameter,
                    NamaDiameter = namadiameter,
                    PeriodeMulaiBerlaku = periodemulaiberlaku,
                    Status = status
                };

                AppResponse.ResponseGetData(await diameterService.GetAll(param));
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
