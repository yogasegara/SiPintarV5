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
    public class MasterKecamatanController : ControllerBase
    {           

        private readonly IMasterKecamatanService kecamatanService;

        public MasterKecamatanController([FromServices]IBusiness business)
        {
            kecamatanService = business.IMasterKecamatanService;
        }      

        [HttpGet]
        public async Task<JsonResult> Get(string kodekecamatan, string namakecamatan, string kodecabang)
        {
            var watch = Stopwatch.StartNew();

            try
            {
                var param = new MasterKecamatanDTo()
                {
                    KodeKecamatan = kodekecamatan,
                    NamaKecamatan = namakecamatan,
                    KodeCabang = kodecabang
                };

                AppResponse.ResponseGetData(await kecamatanService.GetAll(param));
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
