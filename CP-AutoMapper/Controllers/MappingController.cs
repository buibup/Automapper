using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CP_AutoMapper.Dto;
using CP_AutoMapper.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CP_AutoMapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MappingController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly Department sampleDepartment;
        private readonly Person samplePerson;

        public MappingController(IMapper mapper)
        {
            _mapper = mapper; //injected automapper

            //Initializing department object assume from a database
            sampleDepartment = new Department()
            {
                Name = "department1",
                Id = 1,
                Owner = "ABC",
                SecretProperty = "Very secret property"
            };

            //Initializing person object assume from a database
            samplePerson = new Person()
            {
                Firstname = "John",
                Lastname = "Doe",
                Age = 25,
                Sex = "Male",
                Address = new Address()
                {
                    City = "New York City",
                    HouseNumber = "10",
                    State = "NY",
                    ZipCode = "99999"
                }
            };
        }

        [HttpGet]
        public ActionResult<DepartmentDTO> Get()
        {
            return _mapper.Map<DepartmentDTO>(sampleDepartment);
        }

        [HttpGet]
        [Route("person")]
        public ActionResult<PersonDTO> GetPerson()
        {
            return _mapper.Map<PersonDTO>(samplePerson);
        }
    }
}