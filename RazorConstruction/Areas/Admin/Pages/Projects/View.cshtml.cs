using System.Collections.Generic;
using Construction.BackEnd.Models;
using Construction.BackEnd.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorConstruction.Areas.Admin.Pages.Projects
{
    public class ViewModel : PageModel
    {
        private readonly IUnitOfWork unitOfWork;
        public ViewModel(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        
        public List<Project> Projects { get; set; }
        public void OnGet()
        {
            Projects = unitOfWork.projectRepository.GetList();

        }

    }
}