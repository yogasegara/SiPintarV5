using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KelurahanController : ControllerBase
    {

        private readonly IKelurahanService kelurahanService;

        public KelurahanController([FromServices] IBusiness business)
        {
            kelurahanService = business.IKelurahanService;

        }

        [HttpGet]
        public async Task<IEnumerable<KelurahanDTo>> Get(string kodekelurahan,string namakelurahan, string kodekecamatan)
        {
            var param = new KelurahanDTo()
            {
                KodeKelurahan = kodekelurahan,
                NamaKelurahan = namakelurahan,
                KodeKecamatan = kodekecamatan
            };

            return await Task.Run(() => kelurahanService.GetAll(param));
        }
    }
}
