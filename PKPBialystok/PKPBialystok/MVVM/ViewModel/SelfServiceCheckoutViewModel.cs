using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using PKPBialystok.Core;
using PKPBialystok.Windows;

namespace PKPBialystok.MVVM.ViewModel
{
    class SelfServiceCheckoutViewModel : ObservableObject
    {
        SSCStartViewModel SSCStartVM { get; set; }
        HelpViewModel HelpVM { get; set; }
        CartViewModel CartVM { get; set; }
        PaymentViewModel PaymentVM { get; set; }
        PaymentAcceptedViewModel PaymentAcceptedVM { get; set; }
        PaymentDeniedViewModel PaymentDeniedVM { get; set; }
        MalpkaFoundationViewModel MalpkaVM { get; set; }
        public RelayCommand StartOrderingCommand { get; set; }
        public RelayCommand BackToStartCommand { get; set; }
        public RelayCommand AskForHelpCommand { get; set; }
        public RelayCommand GoToCartCommand { get; set; }
        public RelayCommand ExitCartViewCommand { get; set; }
        public RelayCommand MalpkaViewCommand { get; set; }
        public RelayCommand PaymentViewCommand { get; set; }
        public int AcceptTime { get; set; }

        DispatcherTimer PaymentTimer { get; set; }
        public SelfServiceCheckoutViewModel()
        {
            SSCStartVM = new SSCStartViewModel();
            HelpVM = new HelpViewModel();
            CartVM = new CartViewModel();
            MalpkaVM = new MalpkaFoundationViewModel();
            PaymentAcceptedVM = new PaymentAcceptedViewModel();
            PaymentDeniedVM = new PaymentDeniedViewModel();
            PaymentVM = new PaymentViewModel();
            CurrentView = null;

            PaymentTimer = new DispatcherTimer();
            PaymentTimer.Interval = new TimeSpan(0, 0, 1);

            StartButton = new Button();
            CartViewButton = new Button();
            MalpkaViewButton = new Button();
            MalpkaBackViewButton = new Button();

            HelpBarBorder = new Border();

            MalpkaViewButton.Visibility = Visibility.Hidden;
            MalpkaBackViewButton.Visibility = Visibility.Hidden;
            CartViewButton.Visibility = Visibility.Hidden;
            HelpBarBorder.Visibility = Visibility.Hidden;
            StartButton.Visibility = Visibility.Visible;

            StartOrderingCommand = new RelayCommand(o => {
                SSCStartVM = new SSCStartViewModel();
                CartVM = new CartViewModel();
                CurrentView = SSCStartVM;
                StartButton.Visibility = Visibility.Hidden;
                HelpBarBorder.Visibility = Visibility.Visible;

            });
            BackToStartCommand = new RelayCommand(o => 
            {
                CurrentView = null;
                StartButton.Visibility = Visibility.Visible;
                HelpBarBorder.Visibility = Visibility.Hidden;
            });

            AskForHelpCommand = new RelayCommand(o=>
            {
                HelpVM = new HelpViewModel();
                CurrentView = HelpVM;
                StartButton.Visibility = Visibility.Hidden;
                HelpBarBorder.Visibility = Visibility.Hidden;
            });

            GoToCartCommand = new RelayCommand(o =>
            {
                CurrentView = CartVM;
                HelpBarBorder.Visibility = Visibility.Hidden;
                CartViewButton.Visibility = Visibility.Visible;
                MalpkaViewButton.Visibility = Visibility.Hidden;
                MalpkaBackViewButton.Visibility = Visibility.Hidden;
            });

            ExitCartViewCommand = new RelayCommand(o =>
            {
                CurrentView = SSCStartVM;
                HelpBarBorder.Visibility = Visibility.Visible;
                CartViewButton.Visibility = Visibility.Hidden;
            });

            MalpkaViewCommand = new RelayCommand(o =>
            {
                CurrentView = MalpkaVM;
                CartViewButton.Visibility = Visibility.Hidden;
                MalpkaBackViewButton.Visibility = Visibility.Visible;
                MalpkaViewButton.Visibility = Visibility.Visible;
            });

            PaymentViewCommand = new RelayCommand(o =>
            {
                AcceptTime = 5;
                PaymentTimer = new DispatcherTimer();
                PaymentTimer.Tick += new EventHandler(UpdateProgresBar);
                PaymentTimer.Interval = new TimeSpan(0, 0, 1);
                PaymentTimer.Start();
                CurrentView = PaymentVM;
                MalpkaBackViewButton.Visibility = Visibility.Hidden;
                MalpkaViewButton.Visibility = Visibility.Hidden;
                

            });
        }

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

        public Button StartButton
        {
            get { return _startButton; }
            set
            {
                _startButton = value;
                OnPropertyChanged();
            }
        }
        private Button _startButton;

        public Border HelpBarBorder
        {
            get { return _helpBarBorder; }
            set
            {
                _helpBarBorder = value;
                OnPropertyChanged();
            }
        }
        private Border _helpBarBorder;

        public Button CartViewButton
        {
            get { return _cartViewButton; }
            set
            {
                _cartViewButton = value;
                OnPropertyChanged();
            }
        }
        private Button _cartViewButton;

        public Button MalpkaBackViewButton
        {
            get { return _malpkaBackViewButton; }
            set
            {
                _malpkaBackViewButton = value;
                OnPropertyChanged();
            }
        }
        private Button _malpkaBackViewButton;

        public Button MalpkaViewButton
        {
            get { return _malpkaViewButton; }
            set
            {
                _malpkaViewButton = value;
                OnPropertyChanged();
            }
        }
        private Button _malpkaViewButton;

        public void UpdateProgresBar(object sender, EventArgs e)
        {
            PaymentVM.ProgresBarValue--;
            if (PaymentVM.ProgresBarValue == 0)
            {
                PaymentVM.ProgresBarValue = 30;
                PaymentTimer.Stop();
            }
            if (PaymentVM.ProgresBarValue == 25)
            {
                PaymentVM.ProgresBarValue = 30;
                PaymentTimer.Stop();
                CurrentView = PaymentAcceptedVM;
                PaymentTimer.Tick += new EventHandler(PaymentAccepted);
                PaymentTimer.Start();
            }
        }

        public void PaymentAccepted(object sender, EventArgs e)
        {
            AcceptTime--;
            if (AcceptTime == 0)
            {
                AcceptTime = 5;
                PaymentTimer.Stop();
                CurrentView = null;
                StartButton.Visibility = Visibility.Visible;

            }

        }
    }


}
