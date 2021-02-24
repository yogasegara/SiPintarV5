using AppBusiness.Data.DTOs;
using AppPersistence.Mysql.Models;
using AutoMapper;

namespace AppPersistence.Mysql.Utility
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Pelanggan, PelangganDTo>().ReverseMap();
            CreateMap<Rayon, RayonDTo>().ReverseMap();
            CreateMap<Area, AreaDTo>().ReverseMap();
            CreateMap<Wilayah, WilayahDTo>().ReverseMap();
            CreateMap<Kelurahan, KelurahanDTo>().ReverseMap();
            CreateMap<Kecamatan, KecamatanDTo>().ReverseMap();
            CreateMap<Cabang, CabangDTo>().ReverseMap();
        }
    }
}
