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
using System.Windows.Navigation;
using System.Windows.Shapes;
using PKPBialystok.Windows;

namespace PKPBialystok.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy SelfServiceCheckoutLoginView.xaml
    /// </summary>
    public partial class SelfServiceCheckoutLoginView : UserControl
    {
        public SelfServiceCheckoutLoginView()
        {
            InitializeComponent();
        }
        private void SelfServiseCheckout_Click(object sender, RoutedEventArgs e)
        {
            var OrderDisplay = new SelfServiceCheckoutWindow();
            var CurrentWindow = Application.Current.Windows[0];
            CurrentWindow.Close();
            OrderDisplay.Show();

        }
    }
}
