using coreBankSystemFrontend.Models;
using coreBankSystemFrontend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Reflection;
using System.Text.Json;

namespace coreBankSystemFrontend.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdminApiService _service;
        private readonly RoleApiService _roleApiService;

        public AdminController(AdminApiService service, RoleApiService roleService)
        {
            _service = service;
            _roleApiService = roleService;
        }
        public async Task<IActionResult> Index()
        {
            var admin = await _service.GetAdmins();
            return View(admin);
        }

        public async Task<IActionResult> Create()
        {
            var model = new Admin
            {
                Roles = await _roleApiService.GetRoles()
            };

            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]  //make avoid injection
        //note using when method post 
        public async Task<IActionResult> Create(Admin admin)  // bind meaing allow only those field
        {
            await _service.Create(admin);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(long id)
        {
            var admin = await _service.GetAdmin(id);
            var roles = await _roleApiService.GetRoles();

            ViewBag.Roles = roles;

            return View(admin);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken] //make avoid injection
        public async Task<IActionResult> Edit(long id, Admin admin)
        {
            await _service.Update(id, admin);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(long id)
        {
            await _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Back()
        {
            return RedirectToAction(nameof(Index));
        }
    } 
}
