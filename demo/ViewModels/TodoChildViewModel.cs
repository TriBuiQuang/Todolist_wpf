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
		private string _name;
		private string _description;
		private int _id;
		private bool _complete;
		private DateTime _createdDate;
		private DateTime _updatedDate;
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

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public  DateTime CreatedDate
		{
			get { return _createdDate; }
			set { _createdDate = value; }
		}

		
		public DateTime UpdatedDate
		{
			get { return _updatedDate; }
			set { _updatedDate = value; }
		}

		public string Description
		{
			get { return _description; }
			set { _description = value; NotifyOfPropertyChange(() => Description); }
		}	

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		public bool Complete
		{
			get { return _complete; }
			set { _complete = value; }
		}


		public void AddTodo(string description)
		{
			int MaxId = _toDo.Max(x => x.Id) + 1;
			ToDo.Add(new ToDoModel { 
				Id = MaxId , 
				Name = "Task" + MaxId, 
				Complete = false, 
				Description = description,
				CreatedDate = DateTime.Now, 
				UpdatedDate = DateTime.Now 
			});
			Description = "";
		}


	}
}
