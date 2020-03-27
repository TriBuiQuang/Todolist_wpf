using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace demo.ViewModels
{
    class CalendarChildViewModel : Screen
    {

        int[] daysOfMonth = { 01, 02, 03, 04, 05, 06, 07, 08, 09, 10 };
        public CalendarChildViewModel()
        {
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Image Box = new Image();
            //        this.myGrid.Children.Add(Box);
            //    }
            //}
            //this.myGridCalendar.Children.Add(Box);
            int[] num = new int[DaysOfMonth()];
            for (int i = 0; i < DaysOfMonth(); i++)
            {
                int neki = i + 1;
                num[i] = neki;
            }
            DateOfMonth = num;
        }

        public int DaysOfMonth()
        {
            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            int Day = endDate.Day;
            return Day;
        }


        public int[] DateOfMonth       
        {
            get { return daysOfMonth; }
            set
            {
                daysOfMonth = value;
                NotifyOfPropertyChange(() => DateOfMonth);
            }
        }

    }
}
