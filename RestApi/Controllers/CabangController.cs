using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CabangController : ControllerBase
    {           

        private readonly ICabangService cabangService;

        public CabangController([FromServices]IBusiness business)
        {
            cabangService = business.ICabangService;
        }

        [HttpGet]
        public async Task<IEnumerable<CabangDTo>> Get(string kodecabang, string namacabang)
        {
            var param = new CabangDTo()
            {
                KodeCabang = kodecabang,
                NamaCabang = namacabang                
            };

            return await Task.Run(() => cabangService.GetAll(param));
        }
    }
}
