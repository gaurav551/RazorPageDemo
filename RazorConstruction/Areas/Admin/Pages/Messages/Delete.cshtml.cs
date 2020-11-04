using System.Linq;
using Construction.BackEnd.Data;
using Construction.BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorConstruction.Areas.Admin.Pages.Messages
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext context;
        public DeleteModel(ApplicationDbContext context)
        {
            this.context = context;


        }
        [BindProperty]
        public Message Message { get; set; }
        public void OnGet(int id)
        {
            Message = context.Messages.FirstOrDefault(x => x.Id == id);

        }
        public IActionResult OnPost()
        {
            context.Messages.Remove(Message);
            context.SaveChanges();
            return RedirectToPage("Inbox");
        }

    }
}