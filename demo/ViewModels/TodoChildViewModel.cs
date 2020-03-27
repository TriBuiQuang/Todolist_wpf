using Caliburn.Micro;
using demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.ViewModels
{
    class TodoChildViewModel : Screen
	{
		private BindableCollection<ToDoModel> _toDo = new BindableCollection<ToDoModel>();
		private ToDoModel _toDoList;

		public TodoChildViewModel()
		{
			ToDo.Add(new ToDoModel { Id= 1, Name="Task1", Complete=true, Description = "Testing todo 1" , CreatedDate=DateTime.Now, UpdatedDate= DateTime.Now });
			ToDo.Add(new ToDoModel { Id = 2, Name = "Task2", Complete = false, Description = "Testing todo 2", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
			ToDo.Add(new ToDoModel { Id = 3, Name = "Task3", Complete = false, Description = "Testing todo 3", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
		}

		public BindableCollection<ToDoModel> ToDo
		{
			get { return _toDo; }
			set { _toDo = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}


	}
}
