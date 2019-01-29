using ghContract;
using ghEntities;
using ghEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ghRepository
{
    public class ghArchiveRepository: RepositoryBase<ghArchive>, IghArchiveRepository
    {
        public ghArchiveRepository(ghRepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }

        public void CreateghArchive(ghArchive gharchive)
        {
            throw new NotImplementedException();
        }

        public void DeleteghArchive(ghArchive gharchive)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ghArchive> GetAllghArchives()
        {
            return FindAll().OrderBy(a => a.Name);
        }

        public void UpdateghArchive(ghArchive gharchive)
        {
            throw new NotImplementedException();
        }
    }
}
