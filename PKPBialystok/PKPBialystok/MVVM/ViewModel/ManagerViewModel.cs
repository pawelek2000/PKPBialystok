using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PKPBialystok.Core;
using PKPBialystok.MVVM.Model;

namespace PKPBialystok.MVVM.ViewModel
{
    class ManagerViewModel : ObservableObject
    {
        public RelayCommand MenuButtonCommand { get; set; }
        public RelayCommand EmployeeViewCommand { get; set; }
        public EmployeeListViewModel EmployeeListVM { get; set; }
        public ManagerViewModel()
        {
            EmployeeList = new ObservableCollection<Employee>();
            StackPanelVisibility = Visibility.Visible;
            EmployeeListVM = new EmployeeListViewModel();
            MenuButtonCommand = new RelayCommand(o=> 
            {
                if (StackPanelVisibility != Visibility.Visible)
                    StackPanelVisibility = Visibility.Visible;
                else
                    StackPanelVisibility = Visibility.Hidden;
            });

            EmployeeViewCommand = new RelayCommand(o=> 
            {
                EmployeeListVM.EmployeeList = EmployeeList;

                CurrentView = EmployeeListVM;

            });

            EmployeeList.Add(new Employee 
            {
                Name = "Marcin",
                Surname = "Mlecz",
                Age = 32,
                JobPosition = "Kucharz"
            });

            EmployeeList.Add(new Employee
            {
                Name = "Julia",
                Surname = "Mlecz",
                Age = 33,
                JobPosition = "Kucharz"
            });

            EmployeeList.Add(new Employee
            {
                Name = "Dariusz",
                Surname = "Kaczmarek",
                Age = 43,
                JobPosition = "Kucharz"
            });

            EmployeeList.Add(new Employee
            {
                Name = "Jan",
                Surname = "Urban",
                Age = 22,
                JobPosition = "Sprzedawca"
            });

            EmployeeList.Add(new Employee
            {
                Name = "Martyna",
                Surname = "Glazur",
                Age = 24,
                JobPosition = "Sprzedawca"
            });

            EmployeeList.Add(new Employee
            {
                Name = "Przemysław",
                Surname = "Mickiewicz",
                Age = 31,
                JobPosition = "Sprzedawca"
            });

            EmployeeList.Add(new Employee
            {
                Name = "Dariusz",
                Surname = "Miodulski",
                Age = 31,
                JobPosition = "Szefo"
            });
        }

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        private object _currentView;

        public Visibility StackPanelVisibility
        {
            get { return _stackPanelVisibility; }
            set
            {
                _stackPanelVisibility = value;
                OnPropertyChanged();
            }
        }
        private Visibility _stackPanelVisibility;

        public ObservableCollection<Employee> EmployeeList
        {
            get { return _employeeList; }
            set
            {
                _employeeList = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Employee> _employeeList;
    }
}
