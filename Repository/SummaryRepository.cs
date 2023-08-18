using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SummaryRepository : RepositoryBase<Summary>, ISummaryRepository
    {
        public SummaryRepository(RepositoryContext repositoryContext) : base(repositoryContext) 
        { 
        }
    }
}
