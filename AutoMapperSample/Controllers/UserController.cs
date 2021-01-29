using AutoMapper;
using AutoMapperSample.Dto;
using AutoMapperSample.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperSample.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IMapper _mapper;
        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public UserDto GetUserDto()
        {
            UserEntity userEntity = new UserEntity
            {
                FirstName="Hasan",
                LastName="Aksan",
                Gender=Gender.Male,
                Identity="999999999999",
                Phone="5555555555"
            };

            return _mapper.Map<UserDto>(userEntity);
        }

        [HttpGet]
        public UserEntity GetUserEntity()
        {
            UserDto userDto = new UserDto
            {
               Name="Hasan",
               Surname="Aksan",
               Gender="Erkek",
               Phone= "5555555555"
            };

            return _mapper.Map<UserEntity>(userDto);
        }
    }
}
