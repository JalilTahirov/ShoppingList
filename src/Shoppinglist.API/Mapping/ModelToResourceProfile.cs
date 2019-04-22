
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
            CreateMap<Product, ProductResource>();            
        }
    }
}
