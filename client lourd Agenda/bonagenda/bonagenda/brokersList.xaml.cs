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
using System.Text.RegularExpressions;

namespace bonagenda
{
    /// <summary>
    /// Logique d'interaction pour brokersList.xaml
    /// </summary>
    public partial class brokersList : Page
    {
        Model1 db = new Model1();
        CollectionViewSource custViewSource; // Pour ajouter dans la liste
        public brokersList()
        {
            InitializeComponent();
            custViewSource = ((CollectionViewSource)(FindResource("brokerViewSource")));
        }
        private void brokersList_Loaded(object sender, RoutedEventArgs e)
        {
            db.brokers.Load();
            custViewSource.Source = db.brokers.Local;
        }

        private void UpdateBrokerBtn_Click(object sender, RoutedEventArgs e)
        {
            //Regex
            string lastnameRegex = @"^([a-zA-Z .&'-]+)$";
            string firstnameRegex = @"^([a-zA-Z .&'-]+)$";
            string mailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            string phoneRegex = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

            // Ajout bdd
            broker newbroker = new broker(); //Pour insérer dans la BDD et sauvegarder les ajouts

            if (!String.IsNullOrEmpty(lastnameBrokerChange.Text)) // Conditions pour vérifier les informations rentrées par l'utilisateur
            {
                if (Regex.IsMatch(lastnameBrokerChange.Text, lastnameRegex))
                {
                    newbroker.lastname = lastnameBrokerChange.Text;
                }
                else
                {
                    lastnameBrokerError.Text = "Merci de saisir un nom valide";
                }

                if (!String.IsNullOrEmpty(firstnameBrokerChange.Text))
                {
                    if (Regex.IsMatch(firstnameBrokerChange.Text, firstnameRegex))
                    {
                        newbroker.firstname = firstnameBrokerChange.Text;
                    }
                    else
                    {
                        firstnameBrokerError.Text = "Merci de saisir un prénom valide";
                    }

                    if (!String.IsNullOrEmpty(mailBrokerChange.Text))
                    {
                        if (Regex.IsMatch(mailBrokerChange.Text, mailRegex))
                        {
                            newbroker.mail = mailBrokerChange.Text;
                        }
                        else
                        {
                            mailBrokerError.Text = "Adresse mail invalide";
                        }

                        if (!String.IsNullOrEmpty(phoneNumberBrokerChange.Text))
                        {
                            if (Regex.IsMatch(phoneNumberBrokerChange.Text, phoneRegex))
                            {
                                newbroker.phoneNumber = phoneNumberBrokerChange.Text;
                            }
                            else
                            {
                                phoneNumberBrokerError.Text = "Numéro de téléphone non valide";
                            }
                            MessageBox.Show("Courtier modifié avec succès !");
                            db.SaveChanges();                            
                            lastnameBrokerChange.Text = string.Empty;
                            firstnameBrokerChange.Text = string.Empty;
                            mailBrokerChange.Text = string.Empty;
                            phoneNumberBrokerChange.Text = string.Empty;
                        }
                        else
                        {
                            phoneNumberBrokerError.Text = "Saisir un numéro de téléphone";
                        }
                    }
                    else
                    {
                        mailBrokerError.Text = "Erreur, saisir une adresse mail";
                    }
                }
                else
                {
                    firstnameBrokerError.Text = "Erreur, saisir un prénom";
                }
            }
            else
            {
                lastnameBrokerError.Text = "Erreur, saisir un nom";
            }
        }
    

        private void DeleteBrokerBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (brokerDataGrid.SelectedItem as broker).idBroker;
            var deleteBroker = db.brokers.Where(m => m.idBroker == Id).Single();
            db.brokers.Remove(deleteBroker);
            MessageBox.Show("Courtier effacé !");
            db.SaveChanges();
        }
    }
}
