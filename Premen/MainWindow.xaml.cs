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
        List<Dictionary<string, string>> users = new List<Dictionary<string, string>>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            
            Dictionary<string, string> user = new Dictionary<string, string>()
            {
                {"username", username.Text },
                { "lastname", lastname.Text },
                { "password", password.Text },
                {"age", date.Text += 1},
            };
           
            users.Add(user);
            MessageBox.Show("Successfully");
            username.Clear();
            lastname.Clear();
            password.Clear();
            date.Clear();
        }
        private void Event_Click(object sender, RoutedEventArgs e)
        {
            users.ForEach((element) =>
            {
               All.Content = ($"username: {element["username"]},lastname : {element["lastname"]}, password: {element["password"]} date: {element["age"]}");
            });

        }
    }
}
