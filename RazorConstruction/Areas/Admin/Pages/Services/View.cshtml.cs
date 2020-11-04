using System.Collections.Generic;
using Construction.BackEnd.Models;
using Construction.BackEnd.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorConstruction.Areas.Admin.Pages.Services
{
    public class ViewModel : PageModel
    {
        
       [BindProperty]
        public List<Service> Services { get; set; }
       private readonly IUnitOfWork unitOfWork;

        public ViewModel(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void OnGet()
        {
            Services = unitOfWork.serviceRepository.GetList();

        }
        // public IActionResult OnPost()
        // {
           
        //     return RedirectToPage("View");
        // }
    }
}