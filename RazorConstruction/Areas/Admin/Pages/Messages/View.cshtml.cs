using System.Linq;
using Construction.BackEnd.Data;
using Construction.BackEnd.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorConstruction.Areas.Admin.Pages.Messages
{
    public class ViewModel : PageModel
    {
        private readonly ApplicationDbContext context;
        public ViewModel(ApplicationDbContext context)
        {
            this.context = context;

        }
        
        public Message Message{get;set;}
        public void OnGet(int id)
        {
            Message = context.Messages.FirstOrDefault(x=>x.Id==id);

        }

    }
}