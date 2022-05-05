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
            CreateMap<DeletedProductModel, DeletedProduct>();

            CreateMap<Product, ProductModel>();
            CreateMap<ProductModel, Product>();

            CreateMap<Product, ProductCreateModel>();
            CreateMap<ProductCreateModel, Product>();

            CreateMap<Product, ProductUpdateModel>();
            CreateMap<ProductUpdateModel, Product>();

            CreateMap<UserChange, UserChangesModel>();
            CreateMap<UserChangesModel, UserChange>();
        }
    }
}
