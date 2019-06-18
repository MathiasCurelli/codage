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

namespace calculette
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // 0
        {
            screen.Text = screen.Text + "0";
        }

        private void One_Click(object sender, RoutedEventArgs e) // 1
        {
            screen.Text = screen.Text + "1";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "3";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "4";
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "5";
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "6";
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "7";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "8";
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "9";
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "/";
        }

        private void Mult_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "*";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "-";
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "+";
        }


        private void Button_Click(object sender, RoutedEventArgs e) // CLear
        {
            screen.Text = "";
        }
        private void Result_Click(object sender, RoutedEventArgs e) // =
        {
            if (screen.Text != "")
            {
                Type scriptType = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));

                dynamic obj = Activator.CreateInstance(scriptType, false);
                obj.Language = "javascript";

                string str = null;
                try
                {
                    var res = obj.Eval(screen.Text);
                    str = Convert.ToString(res);
                    screen.Text = screen.Text + "=" + str;
                }
                catch (SystemException)
                {
                    screen.Text = "Erreur de syntax";
                }
            }
        }
    }
}
