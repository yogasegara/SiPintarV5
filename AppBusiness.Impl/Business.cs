using AppBusiness.Interface;

namespace AppBusiness.Business.Impl
{
    public class Business : IBusiness
    {
        public IPelangganService IPelangganService { get;  protected set; }    
        public IRayonService IRayonService { get;  protected set; }
        public IWilayahService IWilayahService { get; protected set; }
        public IAreaService IAreaService { get; protected set; }
        public IKelurahanService IKelurahanService { get; protected set; }
        public IKecamatanService IKecamatanService { get; protected set; }
        public ICabangService ICabangService { get; protected set; }

        public Business(
            IPelangganService iPelangganService,
            IRayonService iRayonService,
            IWilayahService iWilayahService,
            IAreaService iAreaService, 
            IKelurahanService iKelurahanService,
            IKecamatanService iKecamatanService, 
            ICabangService iCabangService)
        {
            IPelangganService = iPelangganService;
            IRayonService = iRayonService;
            IWilayahService = iWilayahService;
            IPelangganService = iPelangganService;
            IAreaService = iAreaService;
            IKelurahanService = iKelurahanService;
            IKecamatanService = iKecamatanService;
            ICabangService = iCabangService;
        }
    }
}
