using Microsoft.AspNetCore.Mvc;
using PersonRecommendationApp.Models.ViewModels;
using PersonRecommendationApp.Services;

namespace PersonRecommendationApp.Controllers;

public class PersonController : Controller
{
    private readonly IPersonRepository _personRepo;

    public PersonController(IPersonRepository personRepo)
    {
        _personRepo = personRepo;
    }

    public async Task<IActionResult> Index()
    {
        var allPeople = await _personRepo.ReadAllAsync();
        var peopleVM = allPeople.Select(p =>
            new PersonDetailsVM
            {
                Id = p.Id,
                DateOfBirth = p.DateOfBirth,
                FirstName = p.FirstName,
                LastName = p.LastName,
                MiddleName = p.MiddleName,
                NumberOfRecommendations = p.Recommendations.Count(),
            });
        return View(peopleVM);
    }

    public async Task<IActionResult> Details(int id)
    {
        var p = await _personRepo.ReadAsync(id);
        var personVM = new PersonDetailsVM
        {
            Id = p.Id,
            DateOfBirth = p.DateOfBirth,
            FirstName = p.FirstName,
            LastName = p.LastName,
            MiddleName = p.MiddleName,
            NumberOfRecommendations = p.Recommendations.Count(),
        };
        return View(personVM);
    }
}
