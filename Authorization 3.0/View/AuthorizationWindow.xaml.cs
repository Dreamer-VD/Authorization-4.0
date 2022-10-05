using Authorization_3._0.Core;
using Authorization_3._0.View;
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

namespace Authorization_3._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnSingIn_Click(object sender, RoutedEventArgs e)
        {
            var users = UserParser.Parse("users3.txt").ToList();

            foreach (var user in users)
            {
                if(user.Login == tbLogin.Text && user.Password == tbPassword.Text)
                {
                    if (user.Role == "Admin")
                    {
                        new UserListWindow().Show();
                        Close();
                    }
                    else if (user.Role == "Manager")
                    {
                        new ManagerWindow().Show();
                        Close();
                    }
                    else if (user.Role == "Client")
                    {
                        new UserWindow().Show();
                        Close();
                    }
                    break;
                }
            }
        }
    }
}
