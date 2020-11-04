using System.Collections.Generic;
using System.Linq;
using Construction.BackEnd.Data;
using Construction.BackEnd.Models;
using Construction.BackEnd.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorConstruction.Areas.Admin.Pages.Privacy
{
    public class ManageModel : PageModel
    {
        private readonly ILogger<ManageModel> _logger;
        public string Message { get; set; }
        private readonly IUnitOfWork unitOfWork;
      

        public ManageModel(ILogger<ManageModel> logger, IUnitOfWork unitOfWork)
        {
           
            this.unitOfWork = unitOfWork;
            _logger = logger;

        }

        [BindProperty]
        public Construction.BackEnd.Models.Privacy Privacy { get; set; }

        public void OnGet()
        {

            Privacy = unitOfWork.privacyRepository.GetFirst();

        }
        public IActionResult OnPost()
        {
            if(!unitOfWork.privacyRepository.CheckIfExist())
            {
            System.Console.WriteLine("Not Exist"); 
            unitOfWork.privacyRepository.Create(Privacy);
            }
            else 
            {
                System.Console.WriteLine("Exists");
                unitOfWork.privacyRepository.Update(Privacy);
            }
           
            Message = "Privacy Policy Updated!";
            

            return RedirectToPage();
        }

    }
}