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
using WPF_Shovkun_PR12.Application_Data;

namespace WPF_Shovkun_PR12.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            var userObj = Appconnect.modelOdb.T1.FirstOrDefault(x => x.login == txbLogin.Text && x.password == psbPassword.Password);
            if (userObj == null)
            {
                MessageBox.Show("Такого пользователя нет!", "Ошибка авторизации!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            try
            {
                switch (userObj.IdRole)
                {
                    case 1:
                        if (txbLogin.Text == userObj.login && psbPassword.Password == userObj.password)
                        MessageBox.Show("Здравствуйте, Администратор " + userObj.name + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        Appframe.frameMain.Navigate(new PageMenuAdmin.PageMenuAdmin());
                        break;
                    case 2:
                        if (txbLogin.Text == userObj.login && psbPassword.Password == userObj.password)
                            MessageBox.Show("Здравствуйте, Ученик " + userObj.name + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        Appframe.frameMain.Navigate(new PageStudent.PageAccountStudent());
                        break;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка" + Ex.Message.ToString() + "Критическая ошибка приложения!!!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            Appframe.frameMain.Navigate(new PageCreateAcc());
        }
    }
}
