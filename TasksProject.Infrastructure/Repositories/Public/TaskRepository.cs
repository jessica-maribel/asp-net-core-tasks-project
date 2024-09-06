
using TasksProject.Infrastructure.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksProject.Domain.Entities;
using Task = TasksProject.Domain.Entities.Task;

namespace TasksProject.Infrastructure.Repositories.Public;

public class TaskRepository(TaskmanagerbdContext _context) 
{
    public async Task<Task> SaveAsync(Task task)
    {
        await _context.Tasks.AddAsync(task);
        await _context.SaveChangesAsync();
        return task;
    }

}