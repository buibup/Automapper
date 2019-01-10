using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP_AutoMapper.Models
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
    }
}
