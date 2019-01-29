using ghEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ghContract
{
    public interface IghArchiveRepository
    {
        IEnumerable<ghArchive> GetAllghArchives();
        void CreateghArchive(ghArchive gharchive);
        void UpdateghArchive(ghArchive gharchive);
        void DeleteghArchive(ghArchive gharchive);
    }
}
