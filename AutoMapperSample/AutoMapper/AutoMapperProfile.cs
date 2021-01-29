using AutoMapper;
using AutoMapperSample.Dto;
using AutoMapperSample.Entity;
using System;

namespace AutoMapperSample.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserEntity, UserDto>()
             .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName))
              .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.LastName))
              .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender == Gender.Male ? "Erkek" : "Bayan"))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => MaskedPhone(src.Phone)));

            CreateMap<UserDto, UserEntity>()
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Name))
             .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Surname))
             .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender == "Erkek" ? Gender.Male : Gender.Female))
               .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone));
        }

        private string MaskedPhone(string Phone)
        {
            return Phone.Substring(0,3).PadRight(Phone.Length, '*');
        }

    }
}
