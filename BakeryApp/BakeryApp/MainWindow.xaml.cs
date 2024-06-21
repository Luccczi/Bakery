using BakeryApp.Frames;
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

namespace BakeryApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new OrderPage());
            Manager.MainFrame = MainFrame;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ItemPage());
        }

        private void MenuOrder_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new OrderPage());
        }

        private void MenuClient_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ClientPage());
        }

        private void MenuClientAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ClientAddPage());
        }

        private void MenuOrderAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new OrderAddPage(null));
        }
    }
}
