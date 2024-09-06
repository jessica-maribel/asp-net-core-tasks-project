using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksProject.Domain.Entities;
using TasksProject.Infrastructure.Connections;

namespace TasksProject.Infrastructure.Repositories.Public
{
    public class CategoryRepository(TaskmanagerbdContext _context) 
    {
       public async Task<Category> SaveAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }
    }
}
