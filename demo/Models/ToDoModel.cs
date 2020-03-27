using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Models
{
    class ToDoModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public bool Complete { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
