using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP_AutoMapper.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string SecretProperty { get; set; } // You dont want to display this
    }
}
