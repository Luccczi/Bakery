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
    /// Логика взаимодействия для ClientAddPage.xaml
    /// </summary>
    public partial class ClientAddPage : Page
    {
        private Client _currentClient = new Client();

        public ClientAddPage()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (tbName.Text == "")
                errors.AppendLine("Укажите имя");
            if (tbPhone.Text == "")
                errors.AppendLine("Укажите телефон");
            if (tbINN.Text == "")
                errors.AppendLine("Укажите ИНН");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            _currentClient.name = tbName.Text;
            _currentClient.phone = tbPhone.Text;
            _currentClient.email = tbEmail.Text;
            _currentClient.address = tbAddress.Text;
            _currentClient.INN = tbINN.Text;

                
            try
            {
                BakeryEntities.GetContext().Client.Add(_currentClient);
                BakeryEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            Manager.MainFrame.Navigate(new ClientPage());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данные не сохранены");
            Manager.MainFrame.Navigate(new ClientPage());
            Manager.MainFrame = Manager.MainFrame;
        }
    }
}
