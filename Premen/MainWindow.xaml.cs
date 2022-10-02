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

namespace Premen
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> users = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Event_Click(object sender, RoutedEventArgs e)
        {
            All.Content = ($"Username {users[0]} Lastname {users[1]} Password {users[2]} ");
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            

            users.Add(username.Text);
            users.Add(lastname.Text);
            users.Add(password.Text);
            MessageBox.Show("Successfully");
            username.Clear();
            lastname.Clear();
            password.Clear();
        }
    }
}
