using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AreaController : ControllerBase
    {

        private readonly IAreaService areaService;

        public AreaController([FromServices] IBusiness business)
        {
            areaService = business.IAreaService;
        }

        [HttpGet]
        public async Task<IEnumerable<AreaDTo>> Get(string kodearea, string namaarea, string kodewil)
        {
            var param = new AreaDTo()
            {
                KodeArea = kodearea,
                NamaArea = namaarea,
                KodeWil = kodewil
            };

            return await Task.Run(() => areaService.GetAll(param));
        }
    }
}
