using Construction.BackEnd.GenericRepository;
using Construction.BackEnd.Models;

namespace Construction.BackEnd.Repository
{
     public interface IPrivacyRepository : IGenericRepository<Privacy>
    {
         bool CheckIfExist();
        
         
    }
}