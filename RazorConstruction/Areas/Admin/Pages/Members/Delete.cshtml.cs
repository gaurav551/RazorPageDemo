using System.Linq;
using Construction.BackEnd.Data;
using Construction.BackEnd.Models;
using Construction.BackEnd.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorConstruction.Areas.Admin.Pages.Members
{
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _context;

        public DeleteModel(IUnitOfWork context)
        {
            _context = context;
        }
        [BindProperty]
        public Member Member {get;set;}
        public IActionResult OnGet(int id)
        {
             Member = _context.memberRepository.GetSingle(x=>x.Id==id);
             return Page();
            
        }
        public IActionResult OnPost()
        {
             var member = _context.memberRepository.GetSingle(x=>x.Id==Member.Id);
             _context.memberRepository.Remove(member);
            return RedirectToPage("View");
        }
        
    }
}