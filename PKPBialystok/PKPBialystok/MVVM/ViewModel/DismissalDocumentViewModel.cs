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
    class DismissalDocumentViewModel : ObservableObject
    {
        public DismissalDocumentViewModel()
        {

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
    }
}

  
