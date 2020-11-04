using Construction.BackEnd.Models;
using Construction.BackEnd.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorConstruction.Areas.Admin.Pages.Careers
{
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork unitOfWork;
        public DeleteModel(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
       [BindProperty]
        public Job Job {get;set;}
        public IActionResult OnGet(int id)
        {
             Job = unitOfWork.jobRepository.GetSingle(x=>x.Id==id);
             return Page();
            
        }
        public IActionResult OnPost()
        {
             var job = unitOfWork.jobRepository.GetSingle(x=>x.Id==Job.Id);
             unitOfWork.jobRepository.Remove(job);
            return RedirectToPage("View");
        }

    }
}