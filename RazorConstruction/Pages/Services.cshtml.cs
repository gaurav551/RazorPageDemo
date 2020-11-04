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
    public class ServicesModel : PageModel
    {
        private readonly ILogger<ServicesModel> _logger;
        public string Message { get; set; }
        private readonly IUnitOfWork unitOfWork;

        public ServicesModel(ILogger<ServicesModel> logger, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            _logger = logger;

        }

        public List<Service> Services { get; set; }

        public void OnGet()
        {

            Services = unitOfWork.serviceRepository.GetList();
        }
    }
}
