using Construction.BackEnd.Data;
using Construction.BackEnd.Models;
using Construction.BackEnd.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorConstruction.Areas.Admin.Pages.Careers
{
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork unitOfWork;
        public EditModel(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [BindProperty]

        public Job Job { get; set; } 
        public void OnGet(int id)
        {
            Job = unitOfWork.jobRepository.GetSingle(x=>x.Id==id);
        }
        public IActionResult OnPost()
        {
            unitOfWork.jobRepository.Update(Job);
            return RedirectToPage("View");
        }

    }
}