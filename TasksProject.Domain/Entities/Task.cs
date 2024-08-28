using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksProject.Domain.Entities;
    public partial class Task
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public int? State { get; set; }

        public int? Priority { get; set; }

        public int? UserId { get; set; }

        public virtual ICollection<TaskCategory> TaskCategories { get; set; } = new List<TaskCategory>();

        public virtual User? User { get; set; }
    }

