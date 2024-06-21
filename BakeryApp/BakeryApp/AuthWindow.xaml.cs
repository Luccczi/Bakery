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
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        private User _currentUser = new User();
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _currentUser = BakeryEntities.GetContext().User.FirstOrDefault(c => c.login == tbLogin.Text && c.password == pbPass.Password);
                if (_currentUser == null)
                {
                    throw new Exception("Пользователь не найден");
                }

                if (_currentUser != null)
                {
                    MessageBox.Show("Успешный вход");
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ОШИБКA", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
