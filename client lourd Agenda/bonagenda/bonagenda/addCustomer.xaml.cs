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
    /// Logique d'interaction pour addCustomer.xaml
    /// </summary>
    public partial class addCustomer : Page
    {
        Model1 db = new Model1(); // Initialisation de la BDD
        public addCustomer()
        {
            InitializeComponent();
        }
        
        // attention trop de if imbriqués et tu pourrais attribuer les valeurs à tes attributs que quand tout est valid plutot qu'a chaque verif 
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //Regex
            string lastnameRegex = @"^([a-zA-Z .&'-]+)$";
            string firstnameRegex = @"^([a-zA-Z .&'-]+)$";
            string mailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            string phoneRegex = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            string budgetRegex = @"/^[0-9]+$"; //à suppr si tu l'utilises pas 
            // Ajout bdd
            customer newcustomer = new customer(); //Pour insérer dans la BDD et sauvegarder les ajouts

            if (!String.IsNullOrEmpty(lastname.Text)) // Conditions pour vérifier les informations rentrées par l'utilisateur
            {
                if (Regex.IsMatch(lastname.Text, lastnameRegex))
                {
                    newcustomer.lastname = lastname.Text;
                }
                else
                {
                    Name.Text = "Merci de saisir un nom valide";
                }

                if (!String.IsNullOrEmpty(firstname.Text))
                {
                    if (Regex.IsMatch(firstname.Text, firstnameRegex))
                    {
                        newcustomer.firstname = firstname.Text;
                    }
                    else
                    {
                        firstName.Text = "Merci de saisir un prénom valide";
                    }

                    if (!String.IsNullOrEmpty(mail.Text))
                    {
                        if (Regex.IsMatch(mail.Text, mailRegex))
                        {
                            newcustomer.mail = mail.Text;
                        }
                        if (mail != null)
                        {
                            Email.Text = "Adresse mail déjà prise";
                        }
                        else
                        {
                            Email.Text = "Adresse mail invalide";
                        }

                        if (!String.IsNullOrEmpty(phoneNumber.Text))
                        {
                            if (Regex.IsMatch(phoneNumber.Text, phoneRegex))
                            {
                                newcustomer.phoneNumber = phoneNumber.Text;
                            }
                            else
                            {
                                Phone.Text = "Numéro de téléphone non valide";
                            }

                            newcustomer.budget = int.Parse(budget.Text);

                            db.customers.Add(newcustomer);
                            db.SaveChanges();
                            MessageBox.Show("Client enregistré avec succès !");

                            lastname.Text = string.Empty;
                            firstname.Text = string.Empty;
                            mail.Text = string.Empty;
                            phoneNumber.Text = string.Empty;
                            budget.Text = string.Empty;
                        }
                        else
                        {
                            Phone.Text = "Saisir un numéro de téléphone";
                        }
                    }
                    else
                    {
                        Email.Text = "Erreur, saisir une adresse mail";
                    }
                }
                else
                {
                    firstName.Text = "Erreur, saisir un prénom valide";
                }
            }
            else
            {
                Name.Text = "Erreur, saisir un nom valide";
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e) //Rediriger vers ma liste client au clic sur le bouton annuler
        {
            // appel une page            
            this.NavigationService.Navigate(new customersList());
        }
    }
}



