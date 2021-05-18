using System;
using Microsoft;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calander
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Create a Calendar that displays dates through
            // Januarary 31, 2009 and has dates that are not selectable.
            Calendar calendarWithBlackoutDates = new Calendar();
            DateTime moment = new DateTime(2021,4,1);
            calendarWithBlackoutDates.IsTodayHighlighted = false;
            calendarWithBlackoutDates.DisplayDate = new DateTime(moment.Year, moment.Month, moment.Day);
            calendarWithBlackoutDates.DisplayDateEnd = new DateTime(moment.Year, moment.Month+1, moment.Day);
            calendarWithBlackoutDates.SelectionMode = CalendarSelectionMode.MultipleRange;
            int dayInMonth = Convert.ToInt32(DateTime.DaysInMonth(moment.Year,moment.Month));
            byte counterOfDay = 1;
            byte fistDayState = byte.Parse(fistDay.Text);
            // Add the dates that are not selectable.
            //calendarWithBlackoutDates.BlackoutDates.Add(
            //    new CalendarDateRange(new DateTime(2009, 1, 2), new DateTime(2009, 1, 4)));
            //calendarWithBlackoutDates.BlackoutDates.Add(
            //    new CalendarDateRange(new DateTime(2009, 1, 9)));
            //calendarWithBlackoutDates.BlackoutDates.Add(
            //    new CalendarDateRange(new DateTime(2009, 1, 16)));
            //calendarWithBlackoutDates.BlackoutDates.Add(
            //    new CalendarDateRange(new DateTime(2009, 1, 23), new DateTime(2009, 1, 25)));
            //calendarWithBlackoutDates.BlackoutDates.Add(
            //    new CalendarDateRange(new DateTime(2009, 1, 30)));
            //// Add the selected dates.
            //calendarWithBlackoutDates.SelectedDates.Add(
            //    new DateTime(2009, 1, 5));
            //calendarWithBlackoutDates.SelectedDates.AddRange(
            //    new DateTime(2009, 1, 12), new DateTime(2009, 1, 15));
            //calendarWithBlackoutDates.SelectedDates.Add(
            //    new DateTime(2009, 1, 27));
            byte z = 0;
            for (int j = fistDayState; j < dayInMonth; j++)
                {
                
                    if (counterOfDay == 1 || counterOfDay == 2)
                    {
                        calendarWithBlackoutDates.SelectedDates.Add(
                  new DateTime(moment.Year, moment.Month, j));
                    if (dayInMonth>30||dayInMonth>31)
                    {

                    }
                    }
                    else if (counterOfDay > 3)
                    {
                        counterOfDay = 0;
                    }
                    counterOfDay++;
                }
            
            
            // root is a Panel that is defined elswhere.
            mainwindow.Children.Add(calendarWithBlackoutDates);
        }
        //private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    DateTime? selectedDate = Cal1.SelectedDate;

        //    MessageBox.Show(selectedDate.Value.Date.ToShortDateString());
        //}
    }
}
