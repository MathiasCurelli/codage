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
    /// Logique d'interaction pour addAppointment.xaml
    /// </summary>
    public partial class addAppointment : Page
    {
        Model1 db = new Model1();

        public addAppointment()
        {
            InitializeComponent();
            bindCombo();
            bindComboList();
        }

        public List<customer> idCustomer { get; set; } //Affichage des clients dans les comboBox
        private void bindCombo()
        {
            idCustomer = db.customers.ToList();
            dropDownListCustomers.DataContext = idCustomer;
        }
        public List<broker> idBroker { get; set; }
        private void bindComboList()
        {
            idBroker = db.brokers.ToList();
            dropDownListBrokers.DataContext = idBroker;
        }

        private void SaveAppointment_Click(object sender, RoutedEventArgs e) //Enregistrer les RDVs
        {

            ////Regex
            //string lastnameRegex = @"^([a-zA-Z .&'-]+)$";
            //string firstnameRegex = @"^([a-zA-Z .&'-]+)$";
            //string mailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            //string phoneRegex = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            bool isValid = true; // Vérification de saisie des données
            if (string.IsNullOrEmpty(dropDownListCustomers.Text))
            {
                isValid = false;
                MessageBox.Show("Veuillez sélectionner un client");
            }
            if(string.IsNullOrEmpty(dropDownListBrokers.Text))
            {
                isValid = false;
                MessageBox.Show("Veuillez sélectionner un courtier");
            }
            if (string.IsNullOrEmpty(datepickerAppointment.Text))
            {
                isValid = false;
                MessageBox.Show("Saisir une date de RDV");
            }
            if (datepickerAppointment.SelectedDate < DateTime.Now)
            {
                isValid = false;
                MessageBox.Show("Choisir une date supérieure à celle d'aujourd'hui");
            }
            if (string.IsNullOrEmpty(hourAppointment.Text))
            {
                isValid = false;
                MessageBox.Show("Saisir une heure de RDV");
            }
            if (string.IsNullOrEmpty(minuteAppointment.Text))
            {
                isValid = false;
                MessageBox.Show("Saisir la minute");
            }
            if (string.IsNullOrEmpty(subjectAppointment.Text))
            {
                isValid = false;
                MessageBox.Show("Saisir le motif de ce RDV");
            }

            if (isValid == true) // Si isValid est true
            {
                try { //Permettra de m'indiquer lors de l'éxécution de ma méthode s'il se déclare une erreur
                // Ajout bdd
            DateTime DatePickerTime = datepickerAppointment.SelectedDate.Value;
            DatePickerTime = DatePickerTime.AddHours(double.Parse(hourAppointment.Text));
            DatePickerTime = DatePickerTime.AddMinutes(double.Parse(minuteAppointment.Text));
            
                appointment newappointment = new appointment();
                newappointment.idBroker = int.Parse(dropDownListBrokers.SelectedValue.ToString());
                newappointment.idCustomer = int.Parse(dropDownListCustomers.SelectedValue.ToString());
                newappointment.dateHour = DatePickerTime;
                newappointment.subject = subjectAppointment.Text;
                db.appointments.Add(newappointment);
                db.SaveChanges();
                MessageBox.Show("RDV enregistré avec succès !", "Ajout réussi", MessageBoxButton.OK);
                }
                catch
                {
                    MessageBox.Show("Erreur survenue", "Erreur", MessageBoxButton.OK);
                }
            }
        }      
    }
}
