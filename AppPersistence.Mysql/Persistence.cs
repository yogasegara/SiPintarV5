using AppPersistence.Interface;
using AppPersistence.Mysql.Repositories;
using AppPersistence.Mysql.Utility;
using AutoMapper;

namespace AppPersistence.Mysql
{
    public class Persistence : IPersistence
    {       
        public IPelanggan Pelanggan { get; protected set; }
        public IRayon Rayon { get; protected set; }
        public IWilayah Wilayah { get; protected set; }
        public IArea Area { get; protected set; }
        public IKelurahan Kelurahan { get; protected set; }
        public IKecamatan Kecamatan { get; protected set; }
        public ICabang Cabang { get; protected set; }


        public Persistence()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });

            configuration.AssertConfigurationIsValid();

            Pelanggan = new PelangganRepository(new Mapper(configuration));
            Rayon = new RayonRepository(new Mapper(configuration));
            Wilayah = new WilayahRepository(new Mapper(configuration));
            Area = new AreaRepository(new Mapper(configuration));
            Kelurahan = new KelurahanRepository(new Mapper(configuration));
            Kecamatan = new KecamatanRepository(new Mapper(configuration));
            Cabang = new CabangRepository(new Mapper(configuration));

        }

    }
}
