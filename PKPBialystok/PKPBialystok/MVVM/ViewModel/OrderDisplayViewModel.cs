using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using PKPBialystok.Core;
using PKPBialystok.MVVM.Model;

namespace PKPBialystok.MVVM.ViewModel
{
    
    class OrderDisplayViewModel : ObservableObject
    {
        public BindableCollection<Order> Orders { get; set; }
        public BindableCollection<Order> DoneOrders { get; set; }


        public OrderDisplayViewModel()
        {
            DoneOrders = new BindableCollection<Order>();
            Orders = new BindableCollection<Order>();
            Random rnd = new Random();
            int column = 0;
            int row = 0;
            for (int i = 0; i < rnd.Next(1,21); i++) 
            {
                var order = new Order
                {
                    OrderID = rnd.Next(50),
                    OrderColumn = column,
                    OrderRow = row
                };
                column++;
                if (column > 5) { column = 0; row++; }
                Orders.Add(order);
            }
            column = 0;
            row = 0;
            for (int i = 0; i < rnd.Next(1, 21); i++)
            {
                var order = new Order
                {
                    OrderID = rnd.Next(50),
                    OrderColumn = column,
                    OrderRow = row
                };
                column++;
                if (column > 5) { column = 0; row++; }
                DoneOrders.Add(order);
            }
        }
    }
}
