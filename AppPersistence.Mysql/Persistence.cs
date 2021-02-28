using AppPersistence.Interface;
using AppPersistence.Mysql.Repositories;
using AppPersistence.Mysql.Utility;
using AutoMapper;

namespace AppPersistence.Mysql
{
    public class Persistence : IPersistence
    {             
        public IMasterRayon MasterRayon { get; protected set; }      
        public IMasterArea MasterArea { get; protected set; }
        public IMasterWilayah MasterWilayah { get; protected set; }


        public IMasterKelurahan MasterKelurahan { get; protected set; }
        public IMasterKecamatan MasterKecamatan { get; protected set; }
        public IMasterCabang MasterCabang { get; protected set; }

        public IMasterDiameter MasterDiameter { get; protected set; }


        public IMasterPelanggan MasterPelanggan { get; protected set; }


        public Persistence()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });

            configuration.AssertConfigurationIsValid();
           
            MasterRayon = new MasterRayonRepository(new Mapper(configuration));
            MasterWilayah = new MasterWilayahRepository(new Mapper(configuration));
            MasterArea = new MasterAreaRepository(new Mapper(configuration));
            MasterKelurahan = new MasterKelurahanRepository(new Mapper(configuration));
            MasterKecamatan = new MasterKecamatanRepository(new Mapper(configuration));
            MasterCabang = new MasterCabangRepository(new Mapper(configuration));

            MasterDiameter = new MasterDiameterRepository(new Mapper(configuration));


            MasterPelanggan = new MasterPelangganRepository(new Mapper(configuration));

        }

    }
}
