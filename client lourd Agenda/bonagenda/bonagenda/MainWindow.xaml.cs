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

namespace bonagenda
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
        

        private void addCustomer_Click(object sender, RoutedEventArgs e) // au clic, la page addCustomer s'affichera dans ma Frame
        {
            Main.Content = new addCustomer(); // Main = nom de ma frame pour lui dire qu'on veut l'afficher dans cette frame là
        }

        private void customersList_Click(object sender, RoutedEventArgs e) // au clic, la page customersList s'affichera dans ma Frame
        {
            Main.Content = new customersList();
        }

        private void addBroker_Click(object sender, RoutedEventArgs e) // Lien vers ma page addBroker
        {
            Main.Content = new addBroker();
        }
        private void brokersList_Click(object sender, RoutedEventArgs e) // au clic, la page customersList s'affichera dans ma Frame
        {
            Main.Content = new brokersList();
        }
        private void addAppointment_Click(object sender, RoutedEventArgs e) // au clic, la page customersList s'affichera dans ma Frame
        {
            Main.Content = new addAppointment();
        }

        private void appointmentsList_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new appointmentsList();
        }
    }
}
