using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WilayahController : ControllerBase
    {           

        private readonly IWilayahService wilayahService;

        public WilayahController([FromServices]IBusiness business)
        {
            wilayahService = business.IWilayahService;
        }

        [HttpGet]
        public async Task<IEnumerable<WilayahDTo>> Get(string kodewil,string namawilayah)
        {
            var param = new WilayahDTo()
            {            
                KodeWil = kodewil,
                NamaWilayah = namawilayah
            };

            return await Task.Run(() => wilayahService.GetAll(param));
        }
    }
}
