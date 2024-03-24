using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL.Data;

namespace TaskManager.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        TaskManagerContext Context { get; }
        public Task SaveChangesAsync();
    }
}
