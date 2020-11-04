using System.Collections.Generic;
using Construction.BackEnd.Models;
using Construction.BackEnd.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorConstruction.Areas.Admin.Pages.Members
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
        public List<Member> MemberList { get; set; }

        public void OnGet()
        {
           
            MemberList = unitOfWork.memberRepository.GetList();

        }
    }
}