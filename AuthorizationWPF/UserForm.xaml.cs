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

namespace AuthorizationWPF
{
    /// <summary>
    /// Логика взаимодействия для UserForm.xaml
    /// </summary>
    public partial class UserForm : Page
    {
        public MainWindow mWindow;
        public UserForm(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mWindow = mainWindow;
        }
    }
}
