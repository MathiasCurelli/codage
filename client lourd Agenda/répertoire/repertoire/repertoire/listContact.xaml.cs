using repertoire.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace repertoire
{
    /// <summary>
    /// Logique d'interaction pour listContact.xaml
    /// </summary>
    public partial class listContact : Window
    {
        public listContact()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            try
            {
                int idConnectedUser = users.IdUserConnected;
                DataSet dataSet = Contact.SearchForContacts(idConnectedUser); // exécution de la methode search dans ma classe contact
                contactDataGrid.DataContext = dataSet.Tables[0];
            }
            catch
            {
                MessageBox.Show("Une erreur est survenue, veuillez réessayer.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
