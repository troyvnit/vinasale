using AutoMapper;
using VinaSale.Models;
using VinaSale.Models.ViewModels;

namespace VinaSale.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<EventVM, Event>();
        }
    }
}