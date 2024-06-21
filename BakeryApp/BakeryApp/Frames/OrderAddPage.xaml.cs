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

namespace BakeryApp.Frames
{
    /// <summary>
    /// Логика взаимодействия для OrderAddPage.xaml
    /// </summary>
    public partial class OrderAddPage : Page
    {
        private Order _currentOrder = new Order();

        public OrderAddPage(Order selectedOrder)
        {
            InitializeComponent();

            if (selectedOrder != null)
                _currentOrder = selectedOrder;

            DataContext = _currentOrder;
            cbClient.ItemsSource = BakeryEntities.GetContext().Client.ToList();
            dpDateEnd.Text = _currentOrder.dateEnd.ToString();

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (_currentOrder.id == 0)
            {
                BakeryEntities.GetContext().Order.Add(_currentOrder);
                _currentOrder.dateOrder = DateTime.Now;
                _currentOrder.idStatus = 1;
                _currentOrder.cost = 0;
            }
            try
            {
                _currentOrder.idUser = 1;
                _currentOrder.cost = Convert.ToDecimal(tbCost.Text);
                _currentOrder.dateEnd = dpDateEnd.SelectedDate;
                BakeryEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            Manager.MainFrame.Navigate(new OrderPage());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new OrderPage());
        }
    }
}
