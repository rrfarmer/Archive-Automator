using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IVideoRepository> _videoRepository;
        private readonly Lazy<ITimestampRepository> _timestampRepository;
        private readonly Lazy<ISummaryRepository> _summaryRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _videoRepository = new Lazy<IVideoRepository>(() => new VideoRepository(repositoryContext));
            _timestampRepository = new Lazy<ITimestampRepository>(() => new TimestampRepository(repositoryContext));
            _summaryRepository = new Lazy<ISummaryRepository>(() => new SummaryRepository(repositoryContext));
        }

        public IVideoRepository Video => _videoRepository.Value;
        public ITimestampRepository Timestamp => _timestampRepository.Value;
        public ISummaryRepository Summary => _summaryRepository.Value;

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
