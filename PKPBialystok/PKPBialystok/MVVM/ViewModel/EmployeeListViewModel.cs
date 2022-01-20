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
    class EmployeeListViewModel : ObservableObject
    {

        public EmployeeListViewModel()
        {

        }

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
