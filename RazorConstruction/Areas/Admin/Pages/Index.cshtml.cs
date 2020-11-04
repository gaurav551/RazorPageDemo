using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Construction.BackEnd.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorConstruction.Areas.Admin
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string Message { get; set; }

        private readonly IUnitOfWork unitOfWork;

        public IndexModel(ILogger<IndexModel> logger, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            _logger = logger;

        }
        public int ProjectsCount { get; set; }
        public int MembersCount { get; set; }
        public int JobsCount { get; set; }
        public int ServicesCount { get; set; }

        public void OnGet()
        {
            ProjectsCount = unitOfWork.projectRepository.Count();
           MembersCount = unitOfWork.memberRepository.Count();
           JobsCount = unitOfWork.jobRepository.Count();
           ServicesCount = unitOfWork.serviceRepository.Count();
            System.Console.WriteLine("Got me");
            Message = "Hey guyss";

        }
    }
}
