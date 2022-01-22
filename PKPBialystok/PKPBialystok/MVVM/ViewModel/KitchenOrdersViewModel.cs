using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using PKPBialystok.Core;
using PKPBialystok.MVVM.Model;

namespace PKPBialystok.MVVM.ViewModel
{
    class KitchenOrdersViewModel : ObservableObject 
    {

        public RelayCommand DeleteCommand { get; set; }
        
        public KitchenOrdersViewModel()
        {
            List<string> RandomList = new List<string> { "Mleko", "Herbata", "Zestaw Kleosin", "Zestaw Choroszcz", "Kanapka dostojna", "Kanapka Hajnowska", "Kurczak panierowany", "Kurczak paskudny" };
            FillDishList(RandomList);
            DeleteCommand = new RelayCommand(o =>
            {

                SelectedDish = (o as Dish);
                CartList.Remove(SelectedDish);
            });
        }
        public ObservableCollection<Dish> CartList
        {
            get { return _cartList; }
            set
            {
                _cartList = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Dish> _cartList;

        public void FillDishList(List<string> dishnamelist)
        {
            CartList = new ObservableCollection<Dish>();
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"..\..\Images\DishImage.jpg", UriKind.Relative);
            bi.EndInit();
            Random rnd = new Random();
            foreach (var dish in dishnamelist)
            {
                var d = new Dish
                {
                    Name = dish,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    DishImage = new Image(),
                    Price = rnd.Next(1, 49)
                };
                d.DishImage.Stretch = System.Windows.Media.Stretch.Fill;
                d.DishImage.Source = bi;
                CartList.Add(d);
            }
        }

        public Dish SelectedDish
        {
            get { return _selectedDish; }
            set
            {
                _selectedDish = value;
                OnPropertyChanged();
            }
        }
        private Dish _selectedDish;
    }
}
