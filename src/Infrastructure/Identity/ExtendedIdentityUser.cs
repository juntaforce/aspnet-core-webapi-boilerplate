using Microsoft.AspNetCore.Identity;
using System;

namespace WebApi.Boilerplate.Infrastructure.Identity
{
    //Map this to ApplicationUser in the Application Layer.
    public class ExtendedIdentityUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string CreatedBy { get; set; }
        public string ProfilePictureUrl { get; set; }

        public DateTime CreatedOn { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
        public bool IsActive { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
