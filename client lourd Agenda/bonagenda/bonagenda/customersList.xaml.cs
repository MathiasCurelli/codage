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
using System.Data.Entity; // A rajouter pour afficher nos clients dans la liste
using System.Text.RegularExpressions;

namespace bonagenda
{
    /// <summary>
    /// Logique d'interaction pour customersList.xaml
    /// </summary>
    public partial class customersList : Page
    {
        Model1 db = new Model1();

        CollectionViewSource custViewSource; // Pour ajouter dans la liste

        public customersList()
        {
            InitializeComponent();

            custViewSource = ((CollectionViewSource)(FindResource("customerViewSource")));
        }
        private void customersList_Loaded(object sender, RoutedEventArgs e)
        {
            db.customers.Load();
            custViewSource.Source = db.customers.Local;
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e) //Update client
        {
            //Regex
            string lastnameRegex = @"^([a-zA-Z .&'-]+)$";
            string firstnameRegex = @"^([a-zA-Z .&'-]+)$";
            string mailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            string phoneRegex = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

            customer updateCustomers = new customer();
            if (!String.IsNullOrEmpty(lastnameChange.Text)) // Conditions pour vérifier les informations rentrées par l'utilisateur
            {
                if (Regex.IsMatch(lastnameChange.Text, lastnameRegex))
                {
                    updateCustomers.lastname = lastnameChange.Text;
                }
                else
                {
                    nameChange.Text = "Merci de saisir un nom valide";
                }

                if (!String.IsNullOrEmpty(firstnameChange.Text))
                {
                    if (Regex.IsMatch(firstnameChange.Text, firstnameRegex))
                    {
                        updateCustomers.firstname = firstnameChange.Text;
                    }
                    else
                    {
                        firstChange.Text = "Merci de saisir un prénom valide";
                    }

                    if (!String.IsNullOrEmpty(mailChange.Text))
                    {
                        if (Regex.IsMatch(mailChange.Text, mailRegex))
                        {
                            updateCustomers.mail = mailChange.Text;
                        }
                        else
                        {
                            emailChange.Text = "Adresse mail invalide";
                        }

                        if (!String.IsNullOrEmpty(phoneNumberChange.Text))
                        {
                            if (Regex.IsMatch(phoneNumberChange.Text, phoneRegex))
                            {
                                updateCustomers.phoneNumber = phoneNumberChange.Text;
                            }
                            else
                            {
                                phoneChange.Text = "Numéro de téléphone non valide";
                            }

                            updateCustomers.budget = int.Parse(budgetChange.Text);

                            updateCustomers.lastname = lastnameChange.Text;
                            updateCustomers.firstname = firstnameChange.Text;
                            updateCustomers.mail = mailChange.Text;
                            updateCustomers.phoneNumber = phoneChange.Text;
                            updateCustomers.budget = int.Parse(budgetChange.Text);
                            MessageBox.Show("Modifications enregistrés !");
                            db.SaveChanges();
                        }
                        else
                        {
                            phoneNumberChange.Text = "Saisir un numéro de téléphone";
                        }
                    }
                    else
                    {
                        emailChange.Text = "Erreur, saisir une adresse mail";
                    }
                }
                else
                {
                    firstChange.Text = "Erreur, saisir un prénom";
                }
            }
            else
            {
                nameChange.Text = "Erreur, saisir un nom";
            }
        }


        private void DeleteBtn_Click(object sender, RoutedEventArgs e) //Méthode pour supprimer un client
        {          
            MessageBoxResult alertMessage = MessageBox.Show("Souhaitez-vous supprimez ce client?", "Confirmation", MessageBoxButton.YesNo);
            if (alertMessage == MessageBoxResult.Yes)
            {
                try
                {
                    int customerId = (customerDataGrid.SelectedItem as customer).idCustomer; //défini une variable Id qui , dans la grille customer, selectionnera dans ma table customer de ma BDD, l'id du client sélectionné
                    customer deleteCustomer = db.customers.Where(m => m.idCustomer == customerId).SingleOrDefault(); //Défini une variable qui va indiquer qui supprimer dans ma table client
                    db.customers.Remove(deleteCustomer); //Efface dans la table client le client à partir de son id
                    db.SaveChanges(); // Sauvegarde la suppression
                    MessageBox.Show("Client effacé !");
                }

                catch
                {
                    MessageBox.Show("Une erreur s'est produite, veuillez réessayer.");
                }
            }                         
        }
    }
}


