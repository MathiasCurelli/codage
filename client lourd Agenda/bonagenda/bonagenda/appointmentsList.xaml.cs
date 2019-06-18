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
using System.Data.Entity;

namespace bonagenda
{
    /// <summary>
    /// Logique d'interaction pour appointmentsList.xaml
    /// </summary>
    public partial class appointmentsList : Page
    {
        Model1 db = new Model1();
        private CollectionViewSource custViewSource;

        public appointmentsList()
        {
            InitializeComponent();
            bindCombo();
            bindComboList();
            custViewSource = ((CollectionViewSource)(FindResource("appointmentViewSource")));
        }
        public List<broker> idBroker { get; set; }
        private void bindComboList()
        {
            idBroker = db.brokers.ToList();
            dropDownListBrokersChange.DataContext = idBroker;
        }
        public List<customer> idCustomer { get; set; } //Affichage des clients dans les comboBox
        private void bindCombo()
        {
            idCustomer = db.customers.ToList();
            dropDownListCustomersChange.DataContext = idCustomer;
        }

        private void SaveAppointment_Loaded(object sender, RoutedEventArgs e)
        {
            db.appointments.Load();
            custViewSource.Source = db.appointments.Local;
        }

        private void ModifyAppointment_Click(object sender, RoutedEventArgs e)
        {

            appointment updateAppointment = new appointment()
            {
                //updateAppointment.dateHour = double.Parse(changeDateAppointment.Text);
                idBroker = Convert.ToInt32(dropDownListBrokersChange.SelectedValue),
                idCustomer = Convert.ToInt32(dropDownListCustomersChange.SelectedValue),
                subject = changeSubjectAppointment.Text,

            };
            MessageBox.Show("Modifications enregistrées !");
            db.SaveChanges();


        }

        private void deleteAppointment_Click(object sender, RoutedEventArgs e) // Supprimer un rdv
        {
            // demande de confirmation
            MessageBoxResult answer = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce rendez-vous ? Cette opération est définitive", "Attention | Suppression", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            // si il réponds oui, supprimer, sinon close messagebox
            if (answer == MessageBoxResult.Yes)
            {
                try
                {
                    // delete requete linq
                    db.appointments.Remove(db.appointments.Find(int.Parse(idAppointmentTextBlock.Text)));
                    db.SaveChanges();
                    MessageBox.Show("Client supprimé avec succès", "Suppression réussie", MessageBoxButton.OK);
                }
                catch
                {
                    MessageBox.Show("Une erreur s'est produite, veuillez réessayer ultérieurement", "Erreur", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
    }
}



