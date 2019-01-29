using ghContract;
using ghEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ghRepository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ghRepositoryContext _context;
        private IghArchiveRepository _gharchive;

        public RepositoryWrapper(ghRepositoryContext context)
        {
            _context = context;
        }
        public IghArchiveRepository gharchive
        {
            get
            {
                if(_gharchive == null)
                {
                    _gharchive = new ghArchiveRepository(_context);
                }
                return _gharchive;
            }
        }

       
    }
}
