using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Job name is required.")]
        public string? Name { get; set; }
        public int? EmployerId { get; set; }
        public List<SelectListItem>? Employer { get; set; }

        public AddJobViewModel (List<Employer> employers) {

            Employer = new List<SelectListItem>();

            foreach (var employ in employers)
            {
                Employer.Add(
                new SelectListItem
                {
                    Value = employ.Id.ToString(),
                    Text = employ.Name
                }); 
            }
        }

        public AddJobViewModel()
        {

        }
    }
}