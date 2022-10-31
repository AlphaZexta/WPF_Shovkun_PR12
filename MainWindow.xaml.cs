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
using WPF_Shovkun_PR12.PageMain;

namespace WPF_Shovkun_PR12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Appconnect.modelOdb = new firstEntities();
            Appframe.frameMain = FrmMain;

            FrmMain.Navigate(new PageLogin());
        }
    }
}
