using Microsoft.AspNetCore.Mvc;

namespace coreBankSystemFrontend.Models
{
    [Bind("Id","RoleId","AdminCode","Username","Email")] // set key wich use
    public class Admin 
    {
        public long Id { get; set; }

        public long RoleId { get; set; } 

        public string AdminCode { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public List<RoleViewModel> Roles { get; set; }  = new();

    }
}
