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
    class DocumentGeneratorViewModel : ObservableObject
    {
        public DismissalDocumentViewModel DismissalDocumentVM { get; set; }
        public ReprimandDocumentViewModel ReprimandDocumentVM { get; set; }
        public EmploymentDocumentViewModel EmploymentDocumentVM { get; set; }

        public RelayCommand DismissalDocumentViewCommand { get; set; }
        public RelayCommand ReprimandDocumentViewCommand { get; set; }
        public RelayCommand EmploymentDocumentViewCommand { get; set; }
        public DocumentGeneratorViewModel()
        {
            DismissalDocumentViewCommand = new RelayCommand(o=>
            {
                DismissalDocumentVM = new DismissalDocumentViewModel();
                DismissalDocumentVM.AccountList = AccountList;
                CurrentView = DismissalDocumentVM;
            });

            ReprimandDocumentViewCommand = new RelayCommand(o=> 
            {
                ReprimandDocumentVM = new ReprimandDocumentViewModel();
                CurrentView = ReprimandDocumentVM;
            });

            EmploymentDocumentViewCommand = new RelayCommand(o =>
            {
                EmploymentDocumentVM = new EmploymentDocumentViewModel();
                CurrentView = EmploymentDocumentVM;
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
