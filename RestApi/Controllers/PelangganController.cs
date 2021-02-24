using AppBusiness.Data.DTOs;
using AppBusiness.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PelangganController : ControllerBase
    {

        private readonly IPelangganService pelangganService;

        public PelangganController([FromServices] IBusiness business)
        {
            pelangganService = business.IPelangganService;
        }

        [HttpGet]
        public async Task<IEnumerable<PelangganDTo>> Get(int limit, string nosamb, string koderayon, string nama, string alamat)
        {
            var param = new PelangganDTo()
            {
                NoSamb = nosamb,
                KodeRayon = koderayon,
                Nama = nama,
                Alamat = alamat
            };

            return await Task.Run(() => pelangganService.GetAll(limit, param));
        }
    }
}
