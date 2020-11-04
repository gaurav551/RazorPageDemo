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

namespace RazorConstruction.Areas.Admin.Pages.Members
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
        public Member Member { get; set; }
         

        public void OnGet()
        {
            System.Console.WriteLine("Got me");
         

        }
        public IActionResult OnPost()
        {
            System.Console.WriteLine(Member.Designation);
            System.Console.WriteLine(Image.FileName);
            var imageName = Guid.NewGuid().ToString() + Image.FileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/members", imageName);
          
            using(var fileStream = new FileStream(path, FileMode.Create))
            {
                Image.CopyTo(fileStream);
            }
            Member.PhotoUrl = imageName;
            unitOfWork.memberRepository.Create(Member);
           

            return RedirectToPage("./View");

        }
    }

}
