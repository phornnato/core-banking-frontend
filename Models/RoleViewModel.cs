using Microsoft.AspNetCore.Mvc;

namespace coreBankSystemFrontend.Models
{
    [Bind("Id","Title","Description")]
    public class RoleViewModel
    {
        public long Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;


    }
}