using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL.Models;

namespace TaskManager.DAL.Repositories.Interface
{
    public interface ITaskRepository : IGenerRepository<TaskEntity>
    {
        // Add here method specific to TaskRepository
    }
}
