namespace AppBusiness.Interface
{
    public interface IBusiness
    {
        IMasterPelangganService IMasterPelangganService { get; }
        IMasterRayonService IMasterRayonService { get; }
        IMasterWilayahService IMasterWilayahService { get; }
        IMasterAreaService IMasterAreaService { get; }
        IMasterKelurahanService IMasterKelurahanService { get; }
        IMasterKecamatanService IMasterKecamatanService { get; }
        IMasterCabangService IMasterCabangService { get; }

        IMasterDiameterService IMasterDiameterService { get; }



    }
}
