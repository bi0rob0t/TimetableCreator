using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using TimeTable.Models;
using TimeTable.Models.DBModels;

namespace TimetableGenerator.ViewModels
{
    class DatabaseConfigureWindowVM : ViewModelBase
    {
        public DatabaseConfigureWindowVM()
        {
            //Hours = new ObservableCollection<Hour>(_databaseProvider.());
            //Hours = new ObservableCollection<Group> { new Group { Id = 0, Name = "0", Population = 0 }, new Group { Id = 1, Name = "1", Population = 1 }, };
        }
        private DatabaseProvider _databaseProvider = new DatabaseProvider();

        public ObservableCollection<Hour> Hours { get; set; }

        public ICommand ViewAll
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var h = new ObservableCollection<Hour>(_databaseProvider.GetHours());
                    Hours.Clear();
                    foreach (var item in h)
                        Hours.Add(item);
                    MessageBox.Show(Hours[0].HourId.ToString());
                });

            }
        }
        
        public ICommand Clear
        {
            get
            {

                return new DelegateCommand(() =>
                {
                    
                    Hours.Clear();
                    MessageBox.Show("clear");
                });

            }
        }
    }
}
