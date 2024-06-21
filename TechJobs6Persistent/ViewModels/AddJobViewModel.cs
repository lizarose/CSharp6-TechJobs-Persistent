using System.ComponentModel.DataAnnotations;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Job name is required.")]
        public string? Name { get; set; }
        public int? EmployerId { get; set; }
        public List<Employer>? SelectListItem { get; set; }
    }
}