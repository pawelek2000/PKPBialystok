using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PKPBialystok.Core;

namespace PKPBialystok.MVVM.ViewModel
{
    
    class KitchenViewModel : ObservableObject
    {
        public RelayCommand KitchenOrdersViewCommand { get; set; }
        public RelayCommand AvailableMenuViewCommand { get; set; }
        public RelayCommand BackMainViewCommand { get; set; }


        public KitchenOrdersViewModel KitchenOrdersVM { get; set; }
        public AvailableMenuViewModel AvailableMenuVM { get; set; }
    public KitchenViewModel()
        {
            ButtonVisibility = Visibility.Visible;
            KitchenOrdersViewCommand = new RelayCommand(o=> 
            {
                KitchenOrdersVM = new KitchenOrdersViewModel();
                CurrentView = KitchenOrdersVM;
                ButtonVisibility = Visibility.Hidden;
            });

            AvailableMenuViewCommand = new RelayCommand(o =>
            {
                AvailableMenuVM = new AvailableMenuViewModel();
                CurrentView = AvailableMenuVM;
                ButtonVisibility = Visibility.Hidden;
            });

            BackMainViewCommand = new RelayCommand(o=> 
            {
                CurrentView = null;
                ButtonVisibility = Visibility.Visible;
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

        public Visibility ButtonVisibility
        {
            get { return _buttonVisibility; }
            set
            {
                _buttonVisibility = value;
                OnPropertyChanged();
            }
        }
        private Visibility _buttonVisibility;
    }

}
