using Construction.BackEnd.Models;
using Construction.BackEnd.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorConstruction.Areas.Admin.Pages.Projects
{
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork unitOfWork;
        public DeleteModel(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        [BindProperty]
        public Project Project{get;set;}
        public void OnGet(int id)
        {
            Project = unitOfWork.projectRepository.GetSingle(x=>x.Id==id);

        }
        public IActionResult OnPost()
        {
            unitOfWork.projectRepository.Remove(Project);
            return RedirectToPage("View");
        }

    }
}