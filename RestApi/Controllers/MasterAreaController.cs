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
    public class MasterAreaController : ControllerBase
    {
        private readonly IAreaService areaService;

        public MasterAreaController([FromServices] IBusiness business)
        {
            areaService = business.IAreaService;
        }

        [HttpGet]
        public async Task<JsonResult> GetAsync(string kodearea, string namaarea, string kodewil)
        {
            var watch = Stopwatch.StartNew();         
         
            try
            {
                var param = new MasterAreaDto()
                {
                    KodeArea = kodearea,
                    NamaArea = namaarea,
                    KodeWil = kodewil
                };                      

                AppResponse.ResponseGetData(await areaService.GetAll(param));
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
