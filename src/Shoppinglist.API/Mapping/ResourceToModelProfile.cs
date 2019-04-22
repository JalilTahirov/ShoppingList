using AutoMapper;
using Shoppinglist.API.Domain.Models;
using Shoppinglist.API.Resources;

namespace Shoppinglist.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveProductResource, Product>();
        }
    }
}