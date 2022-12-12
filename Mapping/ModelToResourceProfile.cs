using AutoMapper;
using SuperMarket.Domain.Models;
using SuperMarket.Extensions;
using SuperMarket.Resources;

namespace SuperMarket.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                           opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));
        }
    }
}
