using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Construction.BackEnd.Models;
using Construction.BackEnd.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorConstruction.Areas.Admin.Pages.Projects
{
    public class AddModel : PageModel
    {
         [BindProperty]
        [Required]
        public IFormFile Image { get; set; }
        [BindProperty]
        public Project Project {get;set;}
        private readonly IUnitOfWork unitOfWork;

        public AddModel(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            System.Console.WriteLine("Added");
            var imageName = Guid.NewGuid().ToString() + Image.FileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/projects", imageName);
          
            using(var fileStream = new FileStream(path, FileMode.Create))
            {
                Image.CopyTo(fileStream);
            }
            Project.PhotoUrl = imageName;
            unitOfWork.projectRepository.Create(Project);
            return RedirectToPage("View");
        }
        
    }
}