namespace AppPersistence.Interface
{
    public interface IPersistence
    {
        IPelanggan Pelanggan { get; }
        IRayon Rayon { get; }
        IWilayah Wilayah { get; }
        IArea Area { get; }
        IKelurahan Kelurahan { get; }
        IKecamatan Kecamatan { get; }
        ICabang Cabang { get; }

    }
}
