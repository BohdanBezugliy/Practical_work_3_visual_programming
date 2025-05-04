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

namespace Practical_work_3_visual_programming
{
    /// <summary>
    /// Interaction logic for UserControlLogin.xaml
    /// </summary>
    public partial class UserControlLogin : UserControl
    {
        public UserControlLogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (usernameBox.Text.Length > 0 && passwdBox.Password.Length > 0)
            {
                txtMessageLogin.Foreground = Brushes.Green;
                txtMessageLogin.Text = "Вхід успішний!";
            }
            else if (usernameBox.Text.Length == 0)
            {
                txtMessageLogin.Foreground = Brushes.Red;
                txtMessageLogin.Text = "Будь ласка, заповніть усі поля! (Поле нікнейм пусте)";
                usernameBox.Focus();
            }
            else if (passwdBox.Password.Length == 0) {
                txtMessageLogin.Foreground = Brushes.Red;
                txtMessageLogin.Text = "Будь ласка, заповніть усі поля! (Поле пароль пусте)";
                passwdBox.Focus();
            }
        }

        private void Button_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Button_Click(sender, e);
            }
        }
    }
}
