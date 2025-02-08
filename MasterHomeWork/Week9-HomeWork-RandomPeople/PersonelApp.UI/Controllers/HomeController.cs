using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PersonelApp.Data.Abstract;
using PersonelApp.Entity.Concrete;
using PersonelApp.Services.Abstract;


namespace PersonelApp.UI.Controllers;

public class HomeController : Controller
{
    private readonly IPersonRepository _personRepository;
    private readonly IGroupingService _groupingService;

    public HomeController(IPersonRepository personRepository, IGroupingService groupingService)
    {
        _personRepository = personRepository;
        _groupingService = groupingService;
    }

    public async Task<IActionResult> Index()
    {
        var people = await _personRepository.GetAllAsync();
        return View(people);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Person person)
    {
        if (ModelState.IsValid)
        {
            await _personRepository.AddAsync(person);
            return RedirectToAction(nameof(Index));
        }
        return View(person);
    }

    public async Task<IActionResult> Edit(int id)
    {
        var person = await _personRepository.GetByIdAsync(id);
        return View(person);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Person person)
    {
        if (ModelState.IsValid)
        {
            await _personRepository.UpdateAsync(person);
            return RedirectToAction(nameof(Index));
        }
        return View(person);
    }

    public async Task<IActionResult> Delete(int id)
    {
        await _personRepository.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> CreateGroups(int groupSize)
    {
        var groups = await _groupingService.CreateGroupsAsync(groupSize);
        return PartialView("_GroupsPartial", groups);
    }

    [HttpPost]
    public async Task<IActionResult> SaveGroups()
    {
        await _groupingService.SaveGroupsAsync();
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> DeleteGroups()
    {
        await _groupingService.DeleteAllGroupsAsync();
        return RedirectToAction(nameof(Index));
    }

}
