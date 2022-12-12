using AutoMapper;
using SuperMarket.Domain.Models;
using SuperMarket.Resources;

namespace SuperMarket.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}
