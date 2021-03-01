using AppBusiness.Interface;

namespace AppBusiness.Business.Impl
{
    public class Business : IBusiness
    {
        public IMasterPelangganService IMasterPelangganService { get;  protected set; }    
        public IMasterRayonService IMasterRayonService { get;  protected set; }
        public IMasterWilayahService IMasterWilayahService { get; protected set; }
        public IMasterAreaService IMasterAreaService { get; protected set; }
        public IMasterKelurahanService IMasterKelurahanService { get; protected set; }
        public IMasterKecamatanService IMasterKecamatanService { get; protected set; }
        public IMasterCabangService IMasterCabangService { get; protected set; }

        public IMasterDiameterService IMasterDiameterService { get; protected set; }
        public IMasterGolonganService IMasterGolonganService { get; protected set; }
        public IMasterKolektifService IMasterKolektifService { get; protected set; }
        public IMasterKondisiMeterService IMasterKondisiMeterService { get; protected set; }
        public IMasterSumberAirService IMasterSumberAirService { get; protected set; }
        public IMasterBlokService IMasterBlokService { get; protected set; }
        public IMasterMerekMeterService IMasterMerekMeterService { get; protected set; }




        public Business(
            IMasterPelangganService iMasterPelangganService, IMasterRayonService iMasterRayonService,
            IMasterWilayahService iMasterWilayahService, IMasterAreaService iMasterAreaService,
            IMasterKelurahanService iMasterKelurahanService, IMasterKecamatanService iMasterKecamatanService,
            IMasterCabangService iMasterCabangService, IMasterDiameterService iMasterDiameterService,
            IMasterGolonganService iMasterGolonganService, IMasterKolektifService iMasterKolektifService,
            IMasterSumberAirService iMasterSumberAirService, IMasterKondisiMeterService iMasterKondisiMeterService,
            IMasterBlokService iMasterBlokService, IMasterMerekMeterService iMasterMerekMeterService)
        {
            IMasterPelangganService = iMasterPelangganService;
            IMasterRayonService = iMasterRayonService;
            IMasterWilayahService = iMasterWilayahService;
            IMasterAreaService = iMasterAreaService;
            IMasterKelurahanService = iMasterKelurahanService;
            IMasterKecamatanService = iMasterKecamatanService;
            IMasterCabangService = iMasterCabangService;
            IMasterDiameterService = iMasterDiameterService;
            IMasterGolonganService = iMasterGolonganService;
            IMasterKolektifService = iMasterKolektifService;
            IMasterSumberAirService = iMasterSumberAirService;
            IMasterKondisiMeterService = iMasterKondisiMeterService;
            IMasterBlokService = iMasterBlokService;
            IMasterMerekMeterService = iMasterMerekMeterService;
        }
    }
}
