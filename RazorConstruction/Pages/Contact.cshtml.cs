using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Construction.BackEnd.Data;
using Construction.BackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorConstruction.Pages
{
    [BindProperties]
    public class ContactModel : PageModel
    {
        private readonly ILogger<ContactModel> _logger;

        private readonly ApplicationDbContext context;

        public ContactModel(ILogger<ContactModel> logger, ApplicationDbContext context)
        {
            this.context = context;
            _logger = logger;

        }


        public Message Message { get; set; }
        public Contact Contact { get; set; }

        public string result { get; set; }
        public IFormFile Attachment { get; set; }

        public void OnGet()
        {
            Contact = context.Contacts.FirstOrDefault();


        }
        public IActionResult OnPost()
        {
            context.Messages.Add(Message);
            context.SaveChanges();

            result = "Your message was sent";
            //FileUploads
            if(Attachment!=null)
            {
            var fileName = Guid.NewGuid().ToString() + Attachment.FileName; 
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/attachments", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
             Attachment.CopyTo(fileStream);
            }
            }
            return RedirectToPage("contact");
        }
    }
}
