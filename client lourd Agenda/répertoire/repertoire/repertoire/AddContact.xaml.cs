using repertoire.Model;
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
using System.Windows.Shapes;

namespace repertoire
{
    /// <summary>
    /// Logique d'interaction pour AddContact.xaml
    /// </summary>
    public partial class AddContact : Window
    {
        public AddContact()
        {
            InitializeComponent();
        }

        private void AddContactBtn_Click(object sender, RoutedEventArgs e)
        {
            string regexName = @"^[A-Za-zéàèêëïîç\- ]+$";
            string regexMail = @"^[A-Z-a-z-0-9-.éàèîÏôöùüûêëç]{2,}@[A-Z-a-z-0-9éèàêâùïüëç]{2,}[.][a-z]{2,6}$";
            int id = users.IdUserConnected;
            string firstname = textBoxLastname.Text;
            string lastname = textBoxFirstname.Text;
            string mail = textBoxMail.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            string address = textBoxAdress.Text;
            bool isValid = true;
            if (!String.IsNullOrEmpty(firstname))
            {
                if (!Regex.IsMatch(firstname, regexName))
                {
                    MessageBox.Show("Saisie non valide");
                    isValid = false;
                }                
            }
            else
            {
                MessageBox.Show("Le champs est vide");
                isValid = false;
            }
            if (String.IsNullOrEmpty(lastname))
            {
                MessageBox.Show("Saisie non valide");
                isValid = false;
            }
            
            if (String.IsNullOrEmpty(mail))
            {
                MessageBox.Show("Saisie non valide");
                isValid = false;
            }
            
            if (String.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Saisie non valide");
                isValid = false;
            }
            
            if (String.IsNullOrEmpty(address))
            {
                MessageBox.Show("Saisie non valide");
                isValid = false;
            }
            
            if (isValid)
            {
                // Execution de la méthode register de la classe contact
                Contact.SaveInfo(lastname, firstname, mail, phoneNumber, address);
                // Message de validation de l'ajout
                MessageBox.Show("Votre contact a été ajouté avec succès !", "Message de confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
                // Remet les champs a zéro
                textBoxLastname.Text = null;
                textBoxFirstname.Text = null;
                textBoxMail.Text = null;
                textBoxPhoneNumber.Text = null;                
                textBoxAdress.Text = null;

            }
        }

    }
}

