using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksProject.Domain.Entities
{
    public partial class User
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Mail { get; set; }

        public string? Password { get; set; }

        public int? State { get; set; }

        public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}
