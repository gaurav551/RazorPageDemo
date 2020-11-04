using System.Linq;
using Construction.BackEnd.Data;
using Construction.BackEnd.GenericRepository;
using Construction.BackEnd.Models;

namespace Construction.BackEnd.Repository
{
    public class PrivacyRepository : GenericRepository<Privacy>, IPrivacyRepository
    {
        private readonly ApplicationDbContext context;
        public PrivacyRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;

        }

        public bool CheckIfExist()
        {
            if(context.Privacy.Any()) return true;
            else return false;
            
        }

        
    }
}
