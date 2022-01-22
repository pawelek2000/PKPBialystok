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
        public RelayCommand SaleDetailsViewCommand { get; set; }
        public RelayCommand AccountsListViewCommand { get; set; }
        public RelayCommand DocumentGeneratorViewCommand { get; set; }

        public EmployeeListViewModel EmployeeListVM { get; set; }
        public BranchStatisticsViewModel BranchStatisticsVM { get; set; }
        public AccountsListViewModel AccountsListVM { get; set; }
        public DocumentGeneratorViewModel DocumentGeneratorVM { get; set; }

        public ManagerViewModel()
        {
            SaleStatisticList = new ObservableCollection<SaleStatistic>();
            EmployeeList = new ObservableCollection<Employee>();
            AccountList = new ObservableCollection<Account>();

            StackPanelVisibility = Visibility.Visible;

            EmployeeListVM = new EmployeeListViewModel();
            BranchStatisticsVM = new BranchStatisticsViewModel();
            AccountsListVM = new AccountsListViewModel();

            DocumentGeneratorViewCommand = new RelayCommand(o=> 
            {
                DocumentGeneratorVM = new DocumentGeneratorViewModel();
                DocumentGeneratorVM.AccountList = AccountList;
                CurrentView = DocumentGeneratorVM;
            });

            MenuButtonCommand = new RelayCommand(o=> 
            {
                if (StackPanelVisibility != Visibility.Visible)
                    StackPanelVisibility = Visibility.Visible;
                else
                    StackPanelVisibility = Visibility.Hidden;
            });

            AccountsListViewCommand = new RelayCommand(o=> 
            {
                AccountsListVM = new AccountsListViewModel();
                AccountsListVM.AccountList = AccountList;
                CurrentView = AccountsListVM;
            });
            EmployeeViewCommand = new RelayCommand(o=> 
            {
                EmployeeListVM.EmployeeList = EmployeeList;

                CurrentView = EmployeeListVM;

            });

            SaleDetailsViewCommand = new RelayCommand(o=> 
            {
                BranchStatisticsVM.SaleStatisticList = SaleStatisticList;

                CurrentView = BranchStatisticsVM;

            });


            AccountList.Add(new Account
            { 
            Name = "Marcin",
            Surname = "Wertara",
            PESEL = "12345678901",
            Address = "Białystok, Mickieicza 1"
            });
            AccountList.Add(new Account
            {
                Name = "Darek",
                Surname = "Wertara",
                PESEL = "12345678902",
                Address = "Białystok, Mickieicza 3"
            });
            AccountList.Add(new Account
            {
                Name = "Szymon",
                Surname = "Mocarz",
                PESEL = "12325678901",
                Address = "Białystok, Mickieicza 2"
            });
            AccountList.Add(new Account
            {
                Name = "Krystyna",
                Surname = "Czubówna",
                PESEL = "09876543212",
                Address = "Białystok, Ptasia 1"
            });

            SaleStatisticList.Add(new SaleStatistic 
            {
                Expenses = 34000,
                Income = 53000,
                Month = "Styczeń"
            });

            SaleStatisticList.Add(new SaleStatistic
            {
                Expenses = 37000,
                Income = 68000,
                Month = "Luty"
            });
            SaleStatisticList.Add(new SaleStatistic
            {
                Expenses = 30000,
                Income = 55300,
                Month = "Marzec"
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

        public ObservableCollection<SaleStatistic> SaleStatisticList
        {
            get { return _saleStatisticList; }
            set
            {
                _saleStatisticList = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<SaleStatistic> _saleStatisticList;

        public ObservableCollection<Account> AccountList
        {
            get { return _accountList; }
            set
            {
                _accountList = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Account> _accountList;
    }
}
