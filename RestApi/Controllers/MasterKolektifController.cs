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
    public class MasterKolektifController : ControllerBase
    {           

        private readonly IMasterKolektifService kolektifService;

        public MasterKolektifController([FromServices]IBusiness business)
        {
            kolektifService = business.IMasterKolektifService;
        }

        [HttpGet]    
        public async Task<JsonResult> Get(string kodeKolektif, string namakolektif)
        {
            var watch = Stopwatch.StartNew();

            try
            {
                var param = new MasterKolektifDto()
                {
                    KodeKolektif = kodeKolektif,
                    NamaKolektif = namakolektif,                    
                };

                AppResponse.ResponseGetData(await kolektifService.GetAll(param));
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
