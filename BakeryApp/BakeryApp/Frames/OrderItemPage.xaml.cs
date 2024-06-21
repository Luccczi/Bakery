using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Логика взаимодействия для OrderItemPage.xaml
    /// </summary>
    public partial class OrderItemPage : Page
    {
        private Order _currentOrder = new Order();
        public OrderItemPage(Order selectedOrder)
        {
            InitializeComponent();
            _currentOrder = selectedOrder; 

            UpLoad();
        }
        public void UpLoad()
        {
            dGridItemOrder.ItemsSource = BakeryEntities.GetContext().ItemOrder.ToList().Where(p => p.idOrder == _currentOrder.id);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ItemWindow itemWindow = new ItemWindow(_currentOrder);
            itemWindow.ShowDialog();
            UpLoad();
            
        }
        
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new OrderPage());
        }
    }
}
