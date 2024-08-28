using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TasksProject.Domain.Entities;

namespace TasksProject.Domain.Interfaces.Repositories.Public
{
    public interface ICategoryRepository
    {
        public Task<List<Category>> FindAllAsync(int state);
    }
}
