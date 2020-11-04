using Construction.BackEnd.Models;
using Construction.BackEnd.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorConstruction.Areas.Admin.Pages.Services
{
    public class DeleteModel : PageModel
    {
                private readonly IUnitOfWork unitOfWork;

         public DeleteModel(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        [BindProperty]
        public Service Service{get;set;}
        public void OnGet(int id)
        {
            Service = unitOfWork.serviceRepository.GetSingle(x=>x.Id==id);

        }
        public IActionResult OnPost()
        {
            unitOfWork.serviceRepository.Remove(Service);
            return RedirectToPage("View");
        }
        
    }
}