namespace AppBusiness.Interface
{
    public interface IBusiness
    {
        IPelangganService IPelangganService { get; }
        IRayonService IRayonService { get; }
        IWilayahService IWilayahService { get; }
        IAreaService IAreaService { get; }
        IKelurahanService IKelurahanService { get; }
        IKecamatanService IKecamatanService { get; }
        ICabangService ICabangService { get; }


    }
}
