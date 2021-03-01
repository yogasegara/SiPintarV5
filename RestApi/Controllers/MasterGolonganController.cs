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
    public class MasterGolonganController : ControllerBase
    {           

        private readonly IMasterGolonganService GolonganService;

        public MasterGolonganController([FromServices]IBusiness business)
        {
            GolonganService = business.IMasterGolonganService;
        }

        [HttpGet]    
        public async Task<JsonResult> Get(string kodegol, int? periodemulaiberlaku, string namagolongan, bool? status)
        {
            var watch = Stopwatch.StartNew();

            try
            {
                var param = new MasterGolonganDto()
                {
                    KodeGol = kodegol,
                    NamaGolongan = namagolongan,
                    PeriodeMulaiBerlaku = periodemulaiberlaku,
                    Status = status
                };

                AppResponse.ResponseGetData(await GolonganService.GetAll(param));
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
