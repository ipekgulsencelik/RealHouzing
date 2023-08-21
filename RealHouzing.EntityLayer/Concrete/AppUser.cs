﻿using Microsoft.AspNetCore.Identity;

namespace RealHouzing.EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? ImageURL { get; set; }
        public int ConfirmCode { get; set; }
    }
}
