using System;

namespace DemoASPNETIdentity.Controllers
{
    internal class authorizeAttribute : Attribute
    {
        public string Roles { get; set; }
    }
}