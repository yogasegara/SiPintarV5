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
    public class MasterCabangController : ControllerBase
    {

        private readonly IMasterCabangService cabangService;

        public MasterCabangController([FromServices] IBusiness business)
        {
            cabangService = business.IMasterCabangService;
        }

        [HttpGet]
        public async Task<JsonResult> Get(string kodecabang, string namacabang)
        {
            var watch = Stopwatch.StartNew();

            try
            {
                var param = new MasterCabangDTo()
                {
                    KodeCabang = kodecabang,
                    NamaCabang = namacabang
                };

                AppResponse.ResponseGetData(await cabangService.GetAll(param));
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
