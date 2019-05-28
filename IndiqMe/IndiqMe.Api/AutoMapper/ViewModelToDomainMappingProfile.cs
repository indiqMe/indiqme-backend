﻿using AutoMapper;
using IndiqMe.Api.ViewModels;
using IndiqMe.Domain;

namespace IndiqMe.Api.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile() : this("Profile") { }

        protected ViewModelToDomainMappingProfile(string profileName) : base(profileName)
        {
            #region [ User ]
            CreateMap<LoginUserVM, User>();

            CreateMap<RegisterUserVM, User>()
                 .ForPath(dest => dest.Address.Street, opt => opt.MapFrom(src => src.Street))
                 .ForPath(dest => dest.Address.Number, opt => opt.MapFrom(src => src.Number))
                 .ForPath(dest => dest.Address.PostalCode, opt => opt.MapFrom(src => src.PostalCode))
                 .ForPath(dest => dest.Address.State, opt => opt.MapFrom(src => src.State))
                 .ForPath(dest => dest.Address.City, opt => opt.MapFrom(src => src.City))
                 .ForPath(dest => dest.Address.Neighborhood, opt => opt.MapFrom(src => src.Neighborhood))
                 .ForPath(dest => dest.Address.Country, opt => opt.MapFrom(src => src.Country))
                 .ForPath(dest => dest.Address.Complement, opt => opt.MapFrom(src => src.Complement));

            CreateMap<UpdateUserVM, User>();
            #endregion

            #region [ ContactUs ]
            CreateMap<ContactUsVM, ContactUs>();
            #endregion
        }
    }
}