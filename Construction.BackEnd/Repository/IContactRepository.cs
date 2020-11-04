using Construction.BackEnd.GenericRepository;
using Construction.BackEnd.Models;

namespace Construction.BackEnd.Repository
{
    public interface IContactRepository : IGenericRepository<Contact>
    {
         bool CheckIfExist();
         Contact GetContact();
         
    }
   
}