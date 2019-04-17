
using AutoMapper;
using Shoppinglist.API.Domain.Models;
using Shoppinglist.API.Extensions;
using Shoppinglist.API.Resources;

namespace Shoppinglist.API.Mapping
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
