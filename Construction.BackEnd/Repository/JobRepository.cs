using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Construction.BackEnd.Data;
using Construction.BackEnd.GenericRepository;
using Construction.BackEnd.Models;

namespace Construction.BackEnd.Repository
{
    public class JobRepository : GenericRepository<Job>, IJobRepository
    {
        public JobRepository(ApplicationDbContext c) : base(c)
        {
            
        }

        
    }
}