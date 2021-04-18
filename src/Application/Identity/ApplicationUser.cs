using System;

namespace WebApi.Boilerplate.Application.Identity
{
    public class ApplicationUser
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
