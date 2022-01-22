using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PKPBialystok.MVVM.Model
{
    class Dish
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Image DishImage { get; set; }
        public double Price { get; set; }
        public Visibility Available { get; set; }
        public string Header { get { return string.Format("{0} {1}", Name, Price ); } }
    }
}
