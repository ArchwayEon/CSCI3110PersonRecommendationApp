using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PersonRecommendationApp.Models.ViewModels;

public class PersonDetailsVM
{
    public int Id { get; set; }
    [DisplayName("First Name")]
    public string? FirstName { get; set; }
    [DisplayName("Middle Name")]
    public string? MiddleName { get; set; }
    [DisplayName("Last Name")]
    public string LastName { get; set; } = String.Empty;
    [DisplayName("Date of Birth")]
    public DateTime DateOfBirth { get; set; }
    [DisplayName("Number of Recommendations")]
    public int NumberOfRecommendations { get; set; }
}
