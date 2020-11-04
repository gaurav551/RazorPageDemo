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
    public class PortfolioModel : PageModel
    {
        private readonly ILogger<PortfolioModel> _logger;
        private readonly IUnitOfWork unitOfWork;

       public PortfolioModel(ILogger<PortfolioModel> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            this.unitOfWork = unitOfWork;
        }
        public string Message {get;set;}

        
         public List<Project> Projects { get; set; }

        public void OnGet()
        {
             Projects = unitOfWork.projectRepository.GetList();
           

        }
    }
}
