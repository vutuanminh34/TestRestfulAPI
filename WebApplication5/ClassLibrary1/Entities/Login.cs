using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Database.Entities
{
    public class Login
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
    }
}
