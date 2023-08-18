using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IVideoRepository Video { get; }
        ITimestampRepository Timestamp { get; }
        ISummaryRepository Summary { get; }
        Task SaveAsync();
    }
}
