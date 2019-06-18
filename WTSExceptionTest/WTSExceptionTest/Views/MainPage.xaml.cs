using System;

using Windows.UI.Xaml.Controls;

using WTSExceptionTest.ViewModels;

namespace WTSExceptionTest.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
