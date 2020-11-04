using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Construction.BackEnd.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorConstruction.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly IUnitOfWork unitOfWork;

        public PrivacyModel(ILogger<PrivacyModel> logger, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            _logger = logger;
        }
        public string PrivacyPolicy { get; set; }

        public void OnGet()
        {
            PrivacyPolicy = unitOfWork.privacyRepository.GetFirst().Policy;

        }
    }
}
