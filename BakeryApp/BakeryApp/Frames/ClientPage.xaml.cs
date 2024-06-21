using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

namespace BakeryApp.Frames
{
    /// <summary>
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
            dGridClients.ItemsSource = BakeryEntities.GetContext().Client.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ClientAddPage());
        }

        private void tbSearh_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _currentClient = BakeryEntities.GetContext().Client.ToList();
            if (tbSearh.Text != null)
            {
                _currentClient = BakeryEntities.GetContext().Client.Where(p => p.name.ToLower().Contains(tbSearh.Text.ToLower()) ||
                p.phone.ToLower().Contains(tbSearh.Text.ToLower()) ||
                p.email.ToLower().Contains(tbSearh.Text.ToLower()) ||
                p.address.ToLower().Contains(tbSearh.Text.ToLower()) ||
                p.id.ToString().Contains(tbSearh.Text.ToLower()) ||
                p.INN.ToString().Contains(tbSearh.Text.ToLower())).ToList();
            }
            dGridClients.ItemsSource = _currentClient;
        }
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            tbSearh.Text = null;
            dGridClients.ItemsSource = BakeryEntities.GetContext().Client.ToList();
        }
    }
}
