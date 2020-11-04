using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Construction.BackEnd.Data;
using Construction.BackEnd.Models;
using Construction.BackEnd.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorConstruction.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {

        public string Message { get; set; }
      
        private readonly IUnitOfWork _context;

        public IndexModel(IUnitOfWork IUnitOfWork)
        {
            _context = IUnitOfWork;


        }
        public List<Member> Members { get; set; }
        public List<Project> Projects { get; set; }
        public List<Service> Services { get; set; }

        public void OnGet()
        {
            Members = _context.memberRepository.GetList();
            Projects = _context.projectRepository.GetList();
            Services = _context.serviceRepository.GetList();


           
            
            Message = "Hey guyss";

        }
    }
}
