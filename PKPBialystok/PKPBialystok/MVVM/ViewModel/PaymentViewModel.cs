using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using PKPBialystok.Core;

namespace PKPBialystok.MVVM.ViewModel
{
    class PaymentViewModel : ObservableObject
    {
        
        public PaymentViewModel()
        {
            ProgresBarValue = 30;
        }

        public int ProgresBarValue
        {
            get { return _progresBarValue; }
            set
            {
                _progresBarValue = value;
                OnPropertyChanged();
            }
        }
        private int _progresBarValue;
    }
}
