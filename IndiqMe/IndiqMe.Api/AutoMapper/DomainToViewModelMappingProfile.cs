using AutoMapper;
using IndiqMe.Api.ViewModels;
using IndiqMe.Domain;
using IndiqMe.Helper.Extensions;

namespace IndiqMe.Api.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile() : this("Profile") { }

        protected DomainToViewModelMappingProfile(string profileName) : base(profileName)
        {
            #region [ User ]
            CreateMap<User, UserVM>()
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address));
            #endregion
        }
    }
}
