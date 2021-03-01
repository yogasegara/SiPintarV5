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
        IMasterGolongan MasterGolongan { get; }


        IMasterPelanggan MasterPelanggan { get; }

        IMasterKolektif MasterKolektif { get; }
        IMasterKondisiMeter MasterKondisiMeter { get; }
        IMasterSumberAir MasterSumberAir { get; }
        IMasterBlok MasterBlok { get; }
        IMasterMerekMeter MasterMerekMeter { get; }




    }
}
