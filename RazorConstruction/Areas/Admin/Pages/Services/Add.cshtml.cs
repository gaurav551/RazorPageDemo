using Construction.BackEnd.Models;
using Construction.BackEnd.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorConstruction.Areas.Admin.Pages.Services
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public Service Service { get; set; }
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
           
            unitOfWork.serviceRepository.Create(Service);
            return RedirectToPage("View");
        }
        
    }
}