using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKPBialystok.Core;

namespace PKPBialystok.MVVM.ViewModel
{
    
    class LoginWindowViewModel : ObservableObject
    {
        public RelayCommand EmployeeLoginViewCommand { get; set; }
        public RelayCommand OrderDisplayViewCommand { get; set; }
        public RelayCommand SelfServiceCheckoutViewCommand { get; set; }

        public EmployeeLoginViewModel EmployeeLoginVM { get; set; }
        public OrderDisplayLoginViewModel OrderDisplayLoginVM { get; set; }
        public SelfServiceCheckoutLoginViewModel SelfServiceCheckoutLoginVM { get; set; }

        public LoginWindowViewModel()
        {
            EmployeeLoginVM = new EmployeeLoginViewModel();
            OrderDisplayLoginVM = new OrderDisplayLoginViewModel();
            SelfServiceCheckoutLoginVM = new SelfServiceCheckoutLoginViewModel();
            CurrentLoginView = EmployeeLoginVM;

            EmployeeLoginViewCommand = new RelayCommand(o =>
            {
                CurrentLoginView = EmployeeLoginVM;            
            });

            OrderDisplayViewCommand = new RelayCommand(o =>
            {
                CurrentLoginView = OrderDisplayLoginVM;
            });

            SelfServiceCheckoutViewCommand = new RelayCommand(o =>
            {
                CurrentLoginView = SelfServiceCheckoutLoginVM;
            });
        }

        public object CurrentLoginView
        {
            get { return _currentLoginView; }
            set
            {
                _currentLoginView = value;
                OnPropertyChanged();
            }
        }
        private object _currentLoginView;
    }
}
