using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RayonController : ControllerBase
    {           

        private readonly IRayonService rayonService;

        public RayonController([FromServices]IBusiness business)
        {
            rayonService = business.IRayonService;
        }

        [HttpGet]
        public async Task<IEnumerable<RayonDTo>> Get(string koderayon, string namarayon, string kodearea, string namaarea, string kodewil, string namawilayah)
        {
            var param = new RayonDTo()
            {
                KodeRayon = koderayon,
                NamaRayon = namarayon,
                KodeArea = kodearea,
                NamaArea = namaarea,
                KodeWil = kodewil,
                NamaWilayah = namawilayah,

            };

            return await Task.Run(() => rayonService.GetAll(param));
        }     

    }
}
