using AutoMapper;
using GitaWebProject.Data.Entities;
using GitaWebProject.Models;

namespace GitaWebProject.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DeletedProduct, DeletedProductModel>();
            CreateMap<Product, ProductModel>();
            CreateMap<UserChange, UserChangesModel>();
        }
    }
}
