using AppBusiness.Data.DTOs;
using AppPersistence.Mysql.Models;
using AutoMapper;

namespace AppPersistence.Mysql.Utility
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Wilayah Administratif

            CreateMap<MasterRayon, MasterRayonDto>().ReverseMap();

            CreateMap<MasterArea, MasterAreaDto>()
              .ForMember(dest => dest.NamaWilayah, opt => opt.MapFrom(
                  src => !string.IsNullOrWhiteSpace(src.MasterWilayah.NamaWilayah) ? src.MasterWilayah.NamaWilayah : "-"));

            CreateMap<MasterWilayah, MasterWilayahDto>().ReverseMap();


            CreateMap<MasterKelurahan, MasterKelurahanDto>().ReverseMap();

            CreateMap<MasterKecamatan, MasterKecamatanDto>()
              .ForMember(dest => dest.NamaCabang, opt => opt.MapFrom(
                  src => !string.IsNullOrWhiteSpace(src.MasterCabang.NamaCabang) ? src.MasterCabang.NamaCabang : "-"));

            CreateMap<MasterCabang, MasterCabangDto>().ReverseMap();

            #endregion

            #region Tarif & Golongan

            CreateMap<MasterDiameter, MasterDiameterDto>().ReverseMap();

            CreateMap<MasterGolongan, MasterGolonganDto>().ReverseMap();

            #endregion

            #region data atribute

            CreateMap<MasterKolektif, MasterKolektifDto>().ReverseMap();
            CreateMap<MasterKondisiMeter, MasterKondisiMeterDto>().ReverseMap();
            CreateMap<MasterSumberAir, MasterSumberAirDto>().ReverseMap();
            CreateMap<MasterBlok, MasterBlokDto>().ReverseMap();
            CreateMap<MasterMerekMeter, MasterMerekMeterDto>().ReverseMap();




            #endregion

            #region Langganan

            CreateMap<MasterPelanggan, MasterPelangganDto>()
                .ForMember(dest => dest.NamaRayon, opt => opt.MapFrom(
                    src => !string.IsNullOrWhiteSpace(src.MasterRayon.NamaRayon) ? src.MasterRayon.NamaRayon : "-")
                )
                .ForMember(dest => dest.KodeArea, opt => opt.MapFrom(
                    src => !string.IsNullOrWhiteSpace(src.MasterRayon.KodeArea) ? src.MasterRayon.KodeArea : "-")
                )
                .ForMember(dest => dest.NamaArea, opt => opt.MapFrom(
                    src => !string.IsNullOrWhiteSpace(src.MasterRayon.NamaArea) ? src.MasterRayon.NamaArea : "-")
                )
                .ForMember(dest => dest.KodeWil, opt => opt.MapFrom(
                    src => !string.IsNullOrWhiteSpace(src.MasterRayon.KodeWil) ? src.MasterRayon.KodeWil : "-")
                )
                .ForMember(dest => dest.NamaWilayah, opt => opt.MapFrom(
                    src => !string.IsNullOrWhiteSpace(src.MasterRayon.NamaWilayah) ? src.MasterRayon.NamaWilayah : "-")


                )
                .ForMember(dest => dest.NamaKelurahan, opt => opt.MapFrom(
                    src => !string.IsNullOrWhiteSpace(src.MasterKelurahan.NamaKelurahan) ? src.MasterKelurahan.NamaKelurahan : "-")
                )
                .ForMember(dest => dest.KodeKecamatan, opt => opt.MapFrom(
                    src => !string.IsNullOrWhiteSpace(src.MasterKelurahan.KodeKecamatan) ? src.MasterKelurahan.KodeKecamatan : "-")
                )
                .ForMember(dest => dest.NamaKecamatan, opt => opt.MapFrom(
                    src => !string.IsNullOrWhiteSpace(src.MasterKelurahan.NamaKecamatan) ? src.MasterKelurahan.NamaKecamatan : "-")
                )
                .ForMember(dest => dest.KodeCabang, opt => opt.MapFrom(
                    src => !string.IsNullOrWhiteSpace(src.MasterKelurahan.KodeCabang) ? src.MasterKelurahan.KodeCabang : "-")
                )
                .ForMember(dest => dest.NamaCabang, opt => opt.MapFrom(
                   src => !string.IsNullOrWhiteSpace(src.MasterKelurahan.NamaCabang) ? src.MasterKelurahan.NamaCabang : "-")
                )


                .ForMember(dest => dest.NamaDiameter, opt => opt.MapFrom(
                   src => !string.IsNullOrWhiteSpace(src.MasterDiameter.NamaDiameter) ? src.MasterDiameter.NamaDiameter : "-")
                )
                .ForMember(dest => dest.NamaGolongan, opt => opt.MapFrom(
                   src => !string.IsNullOrWhiteSpace(src.MasterGolongan.NamaGolongan) ? src.MasterGolongan.NamaGolongan : "-")
                )
                .ForMember(dest => dest.NamaKolektif, opt => opt.MapFrom(
                   src => !string.IsNullOrWhiteSpace(src.MasterKolektif.NamaKolektif) ? src.MasterKolektif.NamaKolektif : "-")
                )
                .ForMember(dest => dest.NamaKondisiMeter, opt => opt.MapFrom(
                   src => !string.IsNullOrWhiteSpace(src.MasterKondisiMeter.NamaKondisiMeter) ? src.MasterKondisiMeter.NamaKondisiMeter : "-")
                )
                .ForMember(dest => dest.NamaSumberAir, opt => opt.MapFrom(
                   src => !string.IsNullOrWhiteSpace(src.MasterSumberAir.NamaSumberAir) ? src.MasterSumberAir.NamaSumberAir : "-")
                )
                .ForMember(dest => dest.NamaBlok, opt => opt.MapFrom(
                   src => !string.IsNullOrWhiteSpace(src.MasterBlok.NamaBlok) ? src.MasterBlok.NamaBlok : "-")
                )
                .ForMember(dest => dest.NamaMerekMeter, opt => opt.MapFrom(
                   src => !string.IsNullOrWhiteSpace(src.MasterMerekMeter.NamaMerekMeter) ? src.MasterMerekMeter.NamaMerekMeter : "-")
                )
                ;

            #endregion
        }
    }
}
