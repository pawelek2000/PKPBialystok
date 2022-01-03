﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PKPBialystok.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy OrderDisplayWindow.xaml
    /// </summary>
    public partial class OrderDisplayWindow : Window
    {
        public OrderDisplayWindow()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(HandleEsc);
        }
        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                var OrderDisplay = new LoginWindow();
                OrderDisplay.Show();
                Close();
            }
        }
    }
}
