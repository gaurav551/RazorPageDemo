using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Threading.Tasks;
using Construction.BackEnd.Models;
using Construction.BackEnd.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorConstruction.Areas.Admin.Pages.Careers
{
    public class AddModel : PageModel
    {
        private readonly ILogger<AddModel> _logger;
        public string Message { get; set; }
        private readonly IUnitOfWork unitOfWork;

        public AddModel(ILogger<AddModel> logger, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            _logger = logger;

        }
        [BindProperty]
        [Required]
        public IFormFile Image { get; set; }
        [BindProperty]
        public Job Job { get; set; }
         

        public void OnGet()
        {
            
         

        }
        public IActionResult OnPostAsync()
        {
            unitOfWork.jobRepository.Create(Job);
           
           
            return RedirectToPage("./View");

        }
    }

}
