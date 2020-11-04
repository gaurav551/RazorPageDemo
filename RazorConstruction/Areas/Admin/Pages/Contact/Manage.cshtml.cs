using System.Collections.Generic;
using System.Linq;
using Construction.BackEnd.Data;
using Construction.BackEnd.Models;
using Construction.BackEnd.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorConstruction.Areas.Admin.Pages.Contact
{
    public class ManageModel : PageModel
    {
        private readonly ILogger<ManageModel> _logger;
        public string Message { get; set; }
        private readonly IUnitOfWork unitOfWork;
        private readonly ApplicationDbContext context;

        public ManageModel(ILogger<ManageModel> logger, IUnitOfWork unitOfWork, ApplicationDbContext context)
        {
            this.context = context;
            this.unitOfWork = unitOfWork;
            _logger = logger;

        }

        [BindProperty]
        public Construction.BackEnd.Models.Contact Contact { get; set; }

        public void OnGet()
        {

            Contact = unitOfWork.contactRepository.GetFirst();

        }
        public IActionResult OnPost()
        {
            if(!unitOfWork.contactRepository.CheckIfExist())
            { 
            unitOfWork.contactRepository.Create(Contact);
            }

            else 
            {
            unitOfWork.contactRepository.Update(Contact);
            }
           
            Message = "Contact Details Updated!";
            

            return Page();
        }

    }
}