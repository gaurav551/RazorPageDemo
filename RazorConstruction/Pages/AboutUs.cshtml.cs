using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Construction.BackEnd.Models;
using Construction.BackEnd.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorConstruction.Pages
{
    public class AboutUsModel : PageModel
    {
        private readonly ILogger<AboutUsModel> _logger;
        public string Message { get; set; }
        public List<Member> Members { get; set; }

        private readonly IUnitOfWork unitOfWork;

        public AboutUsModel(ILogger<AboutUsModel> logger, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            _logger = logger;

        }

        public void OnGet()
        {
             Members = unitOfWork.memberRepository.GetList();
            Message = "Hey guyss";

        }
    }
}
