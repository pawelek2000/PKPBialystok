using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKPBialystok.Core;
using PKPBialystok.MVVM.Model;

namespace PKPBialystok.MVVM.ViewModel
{
    class AccountsListViewModel :ObservableObject
    {
        public RegisterViewModel RegisterVM { get; set; }

        public RelayCommand RegisterViewCommand { get; set; }
        public AccountsListViewModel()
        {
            

            RegisterViewCommand = new RelayCommand(o=>
            {
                RegisterVM = new RegisterViewModel();
                CurrentView = RegisterVM;
            });
        }

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
    }
}
