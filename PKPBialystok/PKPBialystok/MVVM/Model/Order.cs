﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PKPBialystok.MVVM.Model
{
    class Order
    {   
        public int OrderID { get; set; }
        public int OrderColumn { get; set; }
        public int OrderRow { get; set; }
    }
}
