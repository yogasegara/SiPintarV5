using AppBusiness.Data.DTOs;
using AppPersistence.Mysql.Models;
using AutoMapper;

namespace AppPersistence.Mysql.Utility
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {

            CreateMap<MasterRayon, MasterRayonDto>().ReverseMap();

            CreateMap<MasterArea, MasterAreaDto>()
              .ForMember(dest => dest.NamaWilayah, opt => opt.MapFrom(
                  src => !string.IsNullOrWhiteSpace(src.MasterWilayah.NamaWilayah) ? src.MasterWilayah.NamaWilayah : "-"));

            CreateMap<MasterWilayah, MasterWilayahDto>().ReverseMap();


            CreateMap<MasterKelurahan, MasterKelurahanDTo>().ReverseMap();

            CreateMap<MasterKecamatan, MasterKecamatanDTo>()
              .ForMember(dest => dest.NamaCabang, opt => opt.MapFrom(
                  src => !string.IsNullOrWhiteSpace(src.MasterCabang.NamaCabang) ? src.MasterCabang.NamaCabang : "-"));

            CreateMap<MasterCabang, MasterCabangDTo>().ReverseMap();


            CreateMap<MasterDiameter, MasterDiameterDto>().ReverseMap();
            


            CreateMap<MasterPelanggan, MasterPelangganDTo>()
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


                .ForMember(dest => dest.Ukuran, opt => opt.MapFrom(
                   src => !string.IsNullOrWhiteSpace(src.MasterDiameter.Ukuran) ? src.MasterDiameter.Ukuran : "-")
                )
                ;



        }
    }
}
