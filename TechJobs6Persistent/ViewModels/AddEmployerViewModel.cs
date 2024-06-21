using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(35, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 35 characters long.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public string? Location { get; set; }
    }

}