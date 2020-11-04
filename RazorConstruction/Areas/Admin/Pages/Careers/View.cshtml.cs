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
    public class ViewModel : PageModel
    {
        private readonly ILogger<ViewModel> _logger;
        public string Message { get; set; }
        private readonly IUnitOfWork unitOfWork;

        public ViewModel(ILogger<ViewModel> logger, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            _logger = logger;

        }
        [BindProperty]
        [Required]
        public IFormFile Image { get; set; }
        [BindProperty]
        public List<Job> Jobs { get; set; }
         

        public void OnGet()
        {
           Jobs = unitOfWork.jobRepository.GetList();
         

        }
        public IActionResult OnPostAsync()
        {
           
            return RedirectToPage("./View");

        }
    }

}
