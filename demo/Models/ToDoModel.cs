using System;

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
