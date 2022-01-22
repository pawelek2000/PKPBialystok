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
    class BranchStatisticsViewModel : ObservableObject
    {
        public BranchStatisticsViewModel()
        {

        }

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
    }
}
