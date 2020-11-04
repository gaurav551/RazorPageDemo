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
    public class CareersModel : PageModel
    {
        private readonly ILogger<CareersModel> _logger;
        public string Message { get; set; }
        private readonly IUnitOfWork unitOfWork;

        public CareersModel(ILogger<CareersModel> logger, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            _logger = logger;



        }
        public List<Job> Jobs { get; set; }
        public Job Job { get; set; }
        //int latestId = unitOfWork.jobRepository.GetSingle;
        

        public void OnGet(int? id)
        {
            Message = unitOfWork.contactRepository.GetFirst().Email;
            if(id!=null)
            Job = unitOfWork.jobRepository.GetSingle(x=>x.Id==id);
            else
            Job = unitOfWork.jobRepository.GetFirst();
           
            Jobs = unitOfWork.jobRepository.GetList();
           

        }
    }
}
