using Caliburn.Micro;
using demo.Models;
using System;
using System.Collections.Generic;
using LiveCharts;
using LiveCharts.Wpf;

namespace demo.ViewModels
{
    class DashboardChildViewModel : Screen
    {
        // Don't manipulate this _firstName do it in FirstName
        // just Properties not constructor
        private BindableCollection<ToDoModel> _toDo = new BindableCollection<ToDoModel>();
        public SeriesCollection SeriesCollection { get; private set; }
        public string[] Labels { get; set; }
        //public List<ToDoModel> ToDo { get; set; }
        public object Count { get; set; }

        public DateTime GetDateNow = DateTime.Now;
        public DashboardChildViewModel()
        {
            ToDo.Add(new ToDoModel { Id = 1, Name = "Task1", Complete = true, Description = "Testing todo 1", CreatedDate = GetDateNow, UpdatedDate = GetDateNow });
            ToDo.Add(new ToDoModel { Id = 2, Name = "Task2", Complete = false, Description = "Testing todo 2", CreatedDate = GetDateNow, UpdatedDate = GetDateNow });
            ToDo.Add(new ToDoModel { Id = 3, Name = "Task3", Complete = false, Description = "Testing todo 3", CreatedDate = GetDateNow, UpdatedDate = GetDateNow });
            Cartesian();
        }
        public BindableCollection<ToDoModel> ToDo
        {
            get { return _toDo; }
            set { _toDo = value; }
        }


        public string AllToDo
        {
            get
            {
                string testing = String.Format("{0}", ToDo.Count);
                return testing;
            }

        }

        public string AllToDoDone
        {
            get
            {
                int CountColletionToDo = 0;
                for (int i = 0; i < ToDo.Count; i++)
                {
                    if (ToDo[i].Complete == true)
                        CountColletionToDo += 1;
                }
                string testing = String.Format("{0}", CountColletionToDo);
                return testing;
            }

        }

      
        public void Cartesian()
        {
            int one = 0, two = 0, three = 0, four = 0, five = 0, six = 0, seven = 0, eight = 0, nine = 0, ten = 0, eleven = 0, twelve = 0;
            int oneNot = 0, twoNot = 0, threeNot = 0, fourNot = 0, fiveNot = 0, sixNot = 0, sevenNot = 0, eightNot = 0, nineNot = 0, tenNot = 0, elevenNot = 0, twelveNot = 0;

            for (int i = 0; i < ToDo.Count; i++)
            {
                switch (ToDo[i].CreatedDate.Month)
                {
                    case 1:
                            if (ToDo[i].Complete == true)  one += 1;
                            else oneNot += 1;
                        break;
                    case 2:
                        if (ToDo[i].Complete == true) two += 1;
                        else twoNot += 1;
                        break;
                    case 3:
                        if (ToDo[i].Complete == true) three += 1;
                        else threeNot += 1;
                        break;
                    case 4:
                        if (ToDo[i].Complete == true) four += 1;
                        else fourNot += 1;
                        break;
                    case 5:
                        if (ToDo[i].Complete == true) five += 1;
                        else fiveNot += 1;
                        break;
                    case 6:
                        if (ToDo[i].Complete == true) six += 1;
                        else sixNot += 1;
                        break;
                    case 7:
                        if (ToDo[i].Complete == true) seven += 1;
                        else sevenNot += 1;
                        break;
                    case 8:
                        if (ToDo[i].Complete == true) eight += 1;
                        else eightNot += 1;
                        break;
                    case 9:
                        if (ToDo[i].Complete == true) nine += 1;
                        else nineNot += 1;
                        break;
                    case 10:
                        if (ToDo[i].Complete == true) ten += 1;
                        else tenNot += 1;
                        break;
                    case 11:
                        if (ToDo[i].Complete == true) eleven += 1;
                        else elevenNot += 1;
                        break;
                    default:
                        if (ToDo[i].Complete == true) twelve += 1;
                        else twelveNot += 1;
                        break;
                }
            }
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title= "Done" ,Values = new ChartValues<double> { one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve }
                },
                new LineSeries
                {
                    Title= "Not Done" ,Values = new ChartValues<double> { oneNot, twoNot, threeNot, fourNot, fiveNot, sixNot, sevenNot, eightNot, nineNot, tenNot, elevenNot, twelveNot }
                }
            };

            Labels = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"}; 
        }
    }
}
