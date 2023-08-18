using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TimestampRepository : RepositoryBase<Timestamp>, ITimestampRepository
    {
        public TimestampRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
