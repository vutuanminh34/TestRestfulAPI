using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Users
    {
        public string Userid { get; set; }
        public string Name { get; set; }
        public string Office { get; set; }
        public string Gender { get; set; }
        public int? DayOfBirthday { get; set; }
        public string Email { get; set; }
    }
}
