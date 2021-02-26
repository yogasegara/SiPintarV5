﻿using AppBusiness.Data.DTOs;
using AppBusiness.Data.Responses;
using AppBusiness.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public async Task<JsonResult> Get(int limit, string nosamb, string koderayon, string nama, string alamat)
        {
            var watch = Stopwatch.StartNew();

            try
            {
                var param = new PelangganDTo()
                {
                    NoSamb = nosamb,
                    KodeRayon = koderayon,
                    Nama = nama,
                    Alamat = alamat
                };

                AppResponse.ResponseGetData(await pelangganService.GetAll(limit,param));
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
