using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PKPBialystok.Core;

namespace PKPBialystok.MVVM.ViewModel
{
    class ManagerViewModel : ObservableObject
    {
        public RelayCommand MenuButtonCommand { get; set; }
        public ManagerViewModel()
        {
            StackPanelVisibility = Visibility.Visible;
            MenuButtonCommand = new RelayCommand(o=> 
            {
                if (StackPanelVisibility != Visibility.Visible)
                    StackPanelVisibility = Visibility.Visible;
                else
                    StackPanelVisibility = Visibility.Hidden;
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
    }
}
