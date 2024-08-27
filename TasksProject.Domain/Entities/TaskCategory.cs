using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksProject.Domain.Entities
{
    public partial class TaskCategory
    {
        public int Id { get; set; }

        public int? TaskId { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }

        public virtual Task? Task { get; set; }
    }
}
