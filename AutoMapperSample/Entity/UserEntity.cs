using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperSample.Entity
{
    public class UserEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identity { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender{
        Male,
        Female
    }
}
