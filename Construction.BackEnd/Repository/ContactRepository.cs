using System.Linq;
using Construction.BackEnd.Data;
using Construction.BackEnd.GenericRepository;
using Construction.BackEnd.Models;

namespace Construction.BackEnd.Repository
{
    public class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        private readonly ApplicationDbContext context;
        public ContactRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;

        }

        public bool CheckIfExist()
        {
            if(context.Contacts.Any()) return true;
            else return false;
            
        }

        public Contact GetContact()
        {
           return context.Contacts.FirstOrDefault();
        }
    }
}