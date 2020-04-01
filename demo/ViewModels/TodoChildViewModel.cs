using Caliburn.Micro;
using demo.Models;
using System;
using System.Linq;
using System.Windows;

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
		private string _contentAddToDo = "Add";
		public DateTime GetDateNow = DateTime.Now;
		public TodoChildViewModel()
		{
			ToDo.Add(new ToDoModel { Id = 1, Name = "Task1", Complete = true, Description = "Testing todo 1", CreatedDate = GetDateNow, UpdatedDate = GetDateNow });
			ToDo.Add(new ToDoModel { Id = 2, Name = "Task2", Complete = false, Description = "Testing todo 2", CreatedDate = GetDateNow, UpdatedDate = GetDateNow });
			ToDo.Add(new ToDoModel { Id = 3, Name = "Task3", Complete = false, Description = "Testing todo 3", CreatedDate = GetDateNow, UpdatedDate = GetDateNow });
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

		public DateTime CreatedDate
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
		public string TxtAddBlock { get; set;  }
		public ToDoModel TxtTodo { get; set;  }
		public string ContentAddToDo
	{
			get { return _contentAddToDo; }
			set { _contentAddToDo = value; NotifyOfPropertyChange(() => ContentAddToDo); }
		}

		public bool CanAddTodo(string txtAddBlock) => !String.IsNullOrWhiteSpace(txtAddBlock);
		public void AddTodo(string txtAddBlock = null)
		{
			int MaxId = 1;
			if (_toDo.Count > 0) MaxId = _toDo.Max(x => x.Id) + 1;
			if (TxtTodo == null)
			{
				ToDo.Add(new ToDoModel
				{
					Id = MaxId,
					Name = "Task" + MaxId,
					Complete = false,
					Description = txtAddBlock,
					CreatedDate = GetDateNow,
					UpdatedDate = GetDateNow
				});
			}
			else
			{
				TxtTodo.Description = txtAddBlock;
				TxtTodo.UpdatedDate = GetDateNow;
				ToDo.Refresh();
				TxtTodo = null;
				ContentAddToDo = "Add";
			}
			TxtAddBlock = "";
			NotifyOfPropertyChange(() => TxtAddBlock);
		}

		public void EditTodo(ToDoModel todo)
		{
			ContentAddToDo = "Edit";
			TxtTodo = todo;
			TxtAddBlock = todo.Description;
			NotifyOfPropertyChange(() => TxtAddBlock);
		}

		public void DeleteTodo(ToDoModel todo)
		{
			ToDo.Remove(todo);
		}

	}
}
