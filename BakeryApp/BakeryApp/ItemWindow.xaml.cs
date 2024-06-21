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
using System.Windows.Shapes;

namespace BakeryApp
{
    /// <summary>
    /// Логика взаимодействия для ItemWindow.xaml
    /// </summary>
    public partial class ItemWindow : Window
    {
        private Order _currentOrder = new Order();
        private ItemOrder _currentItemOrder = new ItemOrder();
        public ItemWindow(Order selectedOrder)
        {
            InitializeComponent();
            _currentOrder = selectedOrder;
            cbProduct.ItemsSource = BakeryEntities.GetContext().Item.ToList();

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                BakeryEntities.GetContext().ItemOrder.Add(_currentItemOrder);

                _currentItemOrder.idOrder = _currentOrder.id;
                _currentItemOrder.idItem = Convert.ToInt32(cbProduct.SelectedIndex)+1;
                _currentItemOrder.quantity = Convert.ToInt32(tbCount.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            StringBuilder errors = new StringBuilder();
            if (_currentItemOrder.idItem == 0)
                errors.AppendLine("Выберите продукцию");
            if (_currentItemOrder.quantity == 0)
                errors.AppendLine("Укажите количество");
            if (_currentItemOrder.quantity <= 0)
                errors.AppendLine("Количество должно быть больше 0");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            try
            {
                BakeryEntities.GetContext().ItemOrder.Add(_currentItemOrder);
                BakeryEntities.GetContext().SaveChanges();
                var rez = MessageBox.Show("Продукция сохранена", "Информация о продукции", MessageBoxButton.OK);
                if (rez == MessageBoxResult.OK)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данные не были сохранены");
            this.Close();
        }
    }
}
