using AutoMapper;
using BLL.DTO;
using BLL.Entities;
using DAL.Entities;
using fcn_CRUD_again.Models;

namespace fcn_CRUD_again.AutoMapper
{
    public class AppMappingProfile : Profile
    {

        public AppMappingProfile() { 
            CreateMap<BrandDTO,BrandViewModel>().ReverseMap();
            CreateMap<ProductDTO,ProductCreateViewModel>().ReverseMap();
            CreateMap<ProductDTO, ProductViewModel>().ForMember("LanguageId",opt=>opt.MapFrom(p=> p.LanguageID))
                .ForMember("CategoryName", opt => opt.MapFrom(p=>p.Category.name))
                .ForMember("brandName", opt => opt.MapFrom(p => p.Brand.name))
                .ReverseMap();
            CreateMap<LanguageDTO, LanguageViewModel>().ReverseMap();
            CreateMap<ParameterValuesViewModel,ParameterValueDTO>().ReverseMap()
                .ForMember("ParameterName", opt => opt.MapFrom(p => p.ParameterName.Name))
                .ForMember("ParameterNameId", opt => opt.MapFrom(p => p.ParameterName.Id));
            CreateMap<CurrencyDTO, CurrencyViewModel>().ReverseMap();
            CreateMap<CategoryViewModel, CategoryDTO>().ReverseMap()
                .ForMember("languageId", opt => opt.MapFrom(c => c.languageId));
            CreateMap<ProductContainerDTO, ProductContainerViewModel>().ReverseMap();
            CreateMap<ParameterName,ParameterNameDTO>().ReverseMap();

            CreateMap<ParameterName, ParameterNameViewModel>().ReverseMap();
            CreateMap<Brand, BrandDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Language, LanguageDTO>().ReverseMap();
            CreateMap<ParameterValue, ParameterValueDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<ProductContainer, ProductContainerDTO>().ReverseMap();
            CreateMap<Currency, CurrencyDTO>().ReverseMap();
            CreateMap<OrderProductDTO, OrderProduct>().ReverseMap();
        }
    }
}
