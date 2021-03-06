using System;
using System.Collections.Generic;

namespace DatingApp.Models
{
    public class FeaturedUsers
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PassowrdHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string CommonName { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Photo { get; set; }        
    }
}