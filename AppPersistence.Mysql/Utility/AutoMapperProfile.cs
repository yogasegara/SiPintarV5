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
                  src => !string.IsNullOrWhiteSpace(src.MasterWilayah.NamaWilayah) ? src.MasterWilayah.NamaWilayah : "-")
              );

            CreateMap<MasterWilayah, MasterWilayahDto>().ReverseMap();           


            //CreateMap<Pelanggan, PelangganDTo>()
            //    .ForMember(dest => dest.NamaRayon, opt => opt.MapFrom(
            //        src => !string.IsNullOrWhiteSpace(src.MasterRayon.NamaRayon) ? src.MasterRayon.NamaRayon : "-")
            //    )
            //    .ForMember(dest => dest.KodeArea, opt => opt.MapFrom(
            //        src => !string.IsNullOrWhiteSpace(src.MasterRayon.KodeArea) ? src.MasterRayon.KodeArea : "-")
            //    )
            //    //.ForMember(dest => dest.NamaArea, opt => opt.MapFrom(
            //    //    src => !string.IsNullOrWhiteSpace(src.Rayon.NamaArea) ? src.MasterRayon.NamaArea : "-")
            //    //)
            //    .ForMember(dest => dest.KodeWil, opt => opt.MapFrom(
            //        src => !string.IsNullOrWhiteSpace(src.MasterRayon.KodeWil) ? src.MasterRayon.KodeWil : "-")
            //    )
            //    //.ForMember(dest => dest.NamaWilayah, opt => opt.MapFrom(
            //    //    src => !string.IsNullOrWhiteSpace(src.Rayon.NamaWilayah) ? src.Rayon.NamaWilayah : "-")
            //    //)
            //    .ForMember(dest => dest.NamaKelurahan, opt => opt.MapFrom(
            //        src => !string.IsNullOrWhiteSpace(src.Kelurahan.NamaKelurahan) ? src.Kelurahan.NamaKelurahan : "-")
            //    )
            //    .ForMember(dest => dest.KodeKecamatan, opt => opt.MapFrom(
            //        src => !string.IsNullOrWhiteSpace(src.Kelurahan.KodeKecamatan) ? src.Kelurahan.KodeKecamatan : "-")
            //    );

            //CreateMap<Kelurahan, KelurahanDTo>()
            //   .ForMember(dest => dest.NamaKecamatan, opt => opt.MapFrom(
            //       src => !string.IsNullOrWhiteSpace(src.Kecamatan.NamaKecamatan) ? src.Kecamatan.NamaKecamatan : "-")
            //   );






            //CreateMap<Kecamatan, KecamatanDTo>().ReverseMap();
            //CreateMap<Cabang, CabangDTo>().ReverseMap();
        }
    }
}
