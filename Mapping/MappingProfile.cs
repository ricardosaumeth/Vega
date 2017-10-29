using AutoMapper;
using vega.Controllers.Resources;
using vega.Model;

namespace vega.Mapping
{
    public class MappingProfile : Profile
    {
       public MappingProfile()
       {
           CreateMap<Make, MakeResource>();
           CreateMap<vega.Model.Model, ModelResource>();
       } 
    }
}