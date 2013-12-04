using AutoMapper;
using VinaSale.Models;
using VinaSale.Models.ViewModels;

namespace VinaSale.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Event, EventVM>();
        }
    }
}