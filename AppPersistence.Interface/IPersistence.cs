namespace AppPersistence.Interface
{
    public interface IPersistence
    {       
        IMasterRayon MasterRayon { get; }       
        IMasterArea MasterArea { get; }
        IMasterWilayah MasterWilayah { get; }

        IMasterKelurahan MasterKelurahan { get; }
        IMasterKecamatan MasterKecamatan { get; }
        IMasterCabang MasterCabang { get; }

        IMasterDiameter MasterDiameter { get; }

        IMasterPelanggan MasterPelanggan { get; }


    }
}
