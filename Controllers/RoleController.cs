using Microsoft.AspNetCore.Mvc;
using coreBankSystemFrontend.Models;

public class RoleController : Controller
{
    private readonly RoleApiService _service;

    public RoleController(RoleApiService service)
    {
        _service = service;
    }

    public async Task<IActionResult> Index()
    {
        var roles = await _service.GetRoles();
        return View(roles);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Create(RoleViewModel model)
    {
        await _service.Create(model);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(long id)
    {
        var role = await _service.GetRole(id);
        return View(role);
    }

    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Edit(long id, RoleViewModel model)
    {
        await _service.Update(id, model);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(long id)
    {
        await _service.Delete(id);
        return RedirectToAction(nameof(Index));
    }

    public  IActionResult Back()
    {
        return RedirectToAction(nameof(Index));
    }
}