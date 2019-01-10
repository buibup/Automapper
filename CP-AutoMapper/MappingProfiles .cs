using AutoMapper;
using CP_AutoMapper.Dto;
using CP_AutoMapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP_AutoMapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Department, DepartmentDTO>().ReverseMap();

            //Complex to Flattened
            CreateMap<Person, PersonDTO>()
                .ForMember(dest => dest.City,
                    opts => opts.MapFrom(
                        src => src.Address.City
                    )).ReverseMap();
        }
    }
}
