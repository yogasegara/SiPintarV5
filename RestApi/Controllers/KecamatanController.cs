using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KecamatanController : ControllerBase
    {           

        private readonly IKecamatanService kecamatanService;

        public KecamatanController([FromServices]IBusiness business)
        {
            kecamatanService = business.IKecamatanService;
        }

        [HttpGet]
        public async Task<IEnumerable<KecamatanDTo>> Get(string kodekecamatan, string namakecamatan, string kodecabang)
        {
            var param = new KecamatanDTo()
            {
                KodeKecamatan = kodekecamatan,
                NamaKecamatan = namakecamatan,
                KodeCabang = kodecabang
            };

            return await Task.Run(() => kecamatanService.GetAll(param));
        }
    }
}
