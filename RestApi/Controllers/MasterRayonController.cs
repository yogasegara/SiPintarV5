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
    public class MasterRayonController : ControllerBase
    {           

        private readonly IRayonService rayonService;

        public MasterRayonController([FromServices]IBusiness business)
        {
            rayonService = business.IRayonService;
        }

        [HttpGet]    
        public async Task<JsonResult> Get(string koderayon, string namarayon, string kodearea, string namaarea, string kodewil, string namawilayah)
        {
            var watch = Stopwatch.StartNew();

            try
            {
                var param = new MasterRayonDto()
                {
                    KodeRayon = koderayon,
                    NamaRayon = namarayon,
                    KodeArea = kodearea,
                    NamaArea = namaarea,
                    KodeWil = kodewil,
                    NamaWilayah = namawilayah,

                };

                AppResponse.ResponseGetData(await rayonService.GetAll(param));
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
