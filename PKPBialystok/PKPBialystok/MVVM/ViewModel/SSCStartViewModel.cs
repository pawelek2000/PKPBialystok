using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using PKPBialystok.Core;
using PKPBialystok.MVVM.Model;

namespace PKPBialystok.MVVM.ViewModel
{
    class SSCStartViewModel : ObservableObject
    {
        public ObservableCollection<Category> CategoryList { get; set; }
        public RelayCommand DishInfoCommand { get; set; }
        public RelayCommand CategoryButtonCommand { get; set; }
        public RelayCommand AddToCartCommand { get; set; }
        public RelayCommand ExitDishInfoCommand { get; set; }
        public DishDetailsViewModel DishDetailsVM { get; set; }

        
        public SSCStartViewModel()
        {
            CategoryList = new ObservableCollection<Category>();
            DishList = new ObservableCollection<Dish>();
            DishDetailsVM = new DishDetailsViewModel();
            DetailBorder = new Border();
            DetailBorder.Visibility = Visibility.Hidden;
            List<string> ChickenDishList = new List<string> {"Kurczak smażony", "Kurczak pieczony","Kurczak panierowany","Kurczak paskudny","Kurczak po Podlaskiemu" };
            List<string> SandwichDishList = new List<string> { "Kanapka elegancka", "Kanapka dostojna", "Kanapka Hajnowska", "Kanapka Białowieska", "Kanapka kieczonym pomidorem"};
            List<string> BoxDishList = new List<string> {"Zestaw Kleosin", "Zestaw Choroszcz"};
            List<string> EDishList = new List<string> { "Chleb żytni", "Ziemniaki" };
            List<string> DessertsDishList = new List<string> { "Cukier", "Miód" };
            List<string> DrinksDishList = new List<string> { "Mleko", "Herbata" };
            Category c = new Category{
            Name = "Kurczaki"
            };
            CategoryList.Add(c);
            c = new Category
            {
                Name = "Kanapki"
            };
            CategoryList.Add(c);

            c = new Category
            {
                Name = "Zestawy"
            };
            CategoryList.Add(c);

            c = new Category
            {
                Name = "Dodatki"
            };
            CategoryList.Add(c);
            c = new Category
            {
                Name = "Desery"
            };
            CategoryList.Add(c);
            c = new Category
            {
                Name = "Napoje"
            };
            CategoryList.Add(c);

            FillDishList(ChickenDishList);

            AddToCartCommand = new RelayCommand(o => 
            {
                CurrentView = null;
                DetailBorder.Visibility = Visibility.Hidden;
            });

            ExitDishInfoCommand = new RelayCommand(o =>
            {
                CurrentView = null;
                DetailBorder.Visibility = Visibility.Hidden;
            });
            DishInfoCommand = new RelayCommand(o=>
            {
                SelectedDish = (o as Dish);
                DishDetailsVM.CurrentDish = SelectedDish;
                CurrentView = DishDetailsVM;
                DetailBorder.Visibility = Visibility.Visible;
            });

            CategoryButtonCommand = new RelayCommand(o =>
           {
               SelectedCategory = (o as Category);
               switch (SelectedCategory.Name) 
               {
                   case "Kanapki":
                       {
                           FillDishList(SandwichDishList);
                           break;
                       }
                   case "Kurczaki":
                       {
                           FillDishList(ChickenDishList);
                           break;
                       }
                   case "Zestawy":
                       {
                           FillDishList(BoxDishList);
                           break;
                       }
                   case "Dodatki":
                       {
                           FillDishList(EDishList);
                           break;
                       }
                   case "Desery":
                       {
                           FillDishList(DessertsDishList);
                           break;
                       }
                   case "Napoje":
                       {
                           FillDishList(DrinksDishList);
                           break;
                       }
               }
           });
        }

        public void FillDishList(List<string> dishnamelist) 
        {
            DishList = new ObservableCollection<Dish>();
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
                DishList.Add(d);
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

        public Category SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;
                OnPropertyChanged();
            }
        }
        private Category _selectedCategory;

        public ObservableCollection<Dish> DishList
        {
            get { return _dishList; }
            set
            {
                _dishList = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Dish> _dishList;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        private object _currentView;

        public Border DetailBorder
        {
            get { return _detailBorder; }
            set
            {
                _detailBorder = value;
                OnPropertyChanged();
            }
        }
        private Border _detailBorder;
    }
}
