using System;
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
    /// Logika interakcji dla klasy LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(Handle123);
        }
        private void Handle123(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                var OrderDisplay = new ManagerWindow();
                OrderDisplay.Show();
                Close();
            }
            if (e.Key == Key.F2)
            {
                var OrderDisplay = new KitchenWindow();
                OrderDisplay.Show();
                Close();
            }
        }
    }
}
