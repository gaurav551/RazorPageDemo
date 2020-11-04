using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Construction.BackEnd.Data;
using Construction.BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorConstruction.Areas.Admin.Messages
{
    public class InboxModel : PageModel
    {
       
        public List<Message> Messages { get; set; }
        private readonly ApplicationDbContext context;
        public InboxModel(ApplicationDbContext context)
        {
            this.context = context;

        }

    

        public void OnGet()
        {
            System.Console.WriteLine("Got me");
            Messages = context.Messages.OrderByDescending(x=>x.Id).ToList();

        }
    }
}
