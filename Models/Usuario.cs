using Microsoft.AspNetCore.Identity;

namespace CSeC.web.Models
{
    public class Usuario : IdentityUser
    {
        public string Nombre {get; set;}
        public string Apellido {get; set;}
    }
}