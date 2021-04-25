using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Boilerplate.Application.Constants
{
    public static class DefaultIdentityConstants
    {
        public static class DefaultAdministrator
        {
            public const string UserName = "administrator";
            public const string Email = "admin@gmail.com";
            public const string FirstName = "Mukesh";
            public const string LastName = "Murugan";
            public const string Password = "123Pa$$word!";
        }
        public static class DefaultBasicUser
        {
            public const string UserName = "basicuser";
            public const string Email = "basicuser@gmail.com";
            public const string FirstName = "John";
            public const string LastName = "Doe";
            public const string Password = "123Pa$$word!";
        }
    }
}
