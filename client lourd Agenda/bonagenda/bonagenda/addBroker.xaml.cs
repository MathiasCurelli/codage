using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Logique d'interaction pour addBroker.xaml
    /// </summary>
    public partial class addBroker : Page
    {
        Model1 db = new Model1();
        public addBroker()
        {
            InitializeComponent();
        }

        private void SaveBroker_Click(object sender, RoutedEventArgs e)
        {
            //Regex
            string lastnameRegex = @"^([a-zA-Z .&'-]+)$";
            string firstnameRegex = @"^([a-zA-Z .&'-]+)$";
            string mailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            string phoneRegex = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            
            // Ajout bdd
            broker newbroker = new broker(); //Pour insérer dans la BDD et sauvegarder les ajouts

            if (!String.IsNullOrEmpty(lastnameBroker.Text)) // Conditions pour vérifier les informations rentrées par l'utilisateur
            {
                if (Regex.IsMatch(lastnameBroker.Text, lastnameRegex))
                {
                    newbroker.lastname = lastnameBroker.Text;
                }
                else
                {
                    lastnameBrokerError.Text = "Merci de saisir un nom valide";
                }

                if (!String.IsNullOrEmpty(firstnameBroker.Text))
                {
                    if (Regex.IsMatch(firstnameBroker.Text, firstnameRegex))
                    {
                        newbroker.firstname = firstnameBroker.Text;
                    }
                    else
                    {
                        firstnameBrokerError.Text = "Merci de saisir un prénom valide";
                    }

                    if (!String.IsNullOrEmpty(mailBroker.Text))
                    {
                        if (Regex.IsMatch(mailBroker.Text, mailRegex))
                        {
                            newbroker.mail = mailBroker.Text;
                        }
                        else
                        {
                            mailBrokerError.Text = "Adresse mail invalide";
                        }

                        if (!String.IsNullOrEmpty(phoneNumberBroker.Text))
                        {
                            if (Regex.IsMatch(phoneNumberBroker.Text, phoneRegex))
                            {
                                newbroker.phoneNumber = phoneNumberBroker.Text;
                            }
                            else
                            {
                                phoneNumberBrokerError.Text = "Numéro de téléphone non valide";
                            }
                           
                            db.brokers.Add(newbroker);
                            db.SaveChanges();
                            MessageBox.Show("Courtier enregistré avec succès !");

                            lastnameBroker.Text = string.Empty;
                            firstnameBroker.Text = string.Empty;
                            mailBroker.Text = string.Empty;
                            phoneNumberBroker.Text = string.Empty;                           
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

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            // appel une page
            Uri pageFunctionUri = new Uri("brokersList.xaml", UriKind.Relative);
            this.NavigationService.Navigate(pageFunctionUri);
        }
    }
}

