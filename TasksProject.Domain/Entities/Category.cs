using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksProject.Domain.Entities;

    public partial class Category
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public virtual ICollection<TaskCategory> TaskCategories { get; set; } = new List<TaskCategory>();
    }

