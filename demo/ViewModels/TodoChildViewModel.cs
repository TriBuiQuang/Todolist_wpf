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
			ToDo.Add(new ToDoModel { Id= 1, Describtion = "Testing todo 1" , CreatedDate=DateTime.Now, UpdatedDate= DateTime.Now });
			ToDo.Add(new ToDoModel { Id = 2, Describtion = "Testing todo 2", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
			ToDo.Add(new ToDoModel { Id = 3, Describtion = "Testing todo 3", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
		}

		public BindableCollection<ToDoModel> ToDo
		{
			get { return _toDo; }
			set { _toDo = value; }
		}
	}
}
