using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKPBialystok.Core;
using PKPBialystok.MVVM.Model;

namespace PKPBialystok.MVVM.ViewModel
{
    class DishDetailsViewModel : ObservableObject
    {
        public Dish CurrentDish { get; set; }
        public DishDetailsViewModel()
        {
            
        }
    }
}
