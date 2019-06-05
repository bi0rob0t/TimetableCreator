using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using TimetableGenerator.Views;

namespace TimetableGenerator.ViewModels
{
    class MainWindowVM : ViewModelBase
    {

        public DelegateCommand<Window> OpenDatabaseWindow
        {
            get
            {

                return new DelegateCommand<Window>((w) =>
                {                    
                    DatabaseConfigureWindow window = new DatabaseConfigureWindow();
                    DatabaseConfigureWindowVM vm = new DatabaseConfigureWindowVM();
                    window.DataContext = vm;
                    w.Close();
                    window.Show();
                    //MainWindow mainWindow = new MainWindow();
                    //MainWindowViewModel vm = new MainWindowViewModel();
                    //mainWindow.DataContext = vm;
                    //w.Close();
                    //mainWindow.Show();


                });

            }
        }
        public DelegateCommand<Window> OpenConfigureTimetableWindow
        {
            get
            {

                return new DelegateCommand<Window>((w) =>
                {
                    ConfigureTimetable window = new ConfigureTimetable();
                    ConfigureTimetableVM vm = new ConfigureTimetableVM();
                    window.DataContext = vm;
                    w.Close();
                    window.Show();
                    //MainWindow mainWindow = new MainWindow();
                    //MainWindowViewModel vm = new MainWindowViewModel();
                    //mainWindow.DataContext = vm;
                    //w.Close();
                    //mainWindow.Show();


                });

            }
        }
    }
}
