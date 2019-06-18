using repertoire.Model;
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
using System.Windows.Shapes;

namespace repertoire
{
    /// <summary>
    /// Logique d'interaction pour login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();

        }

        private void BtnBackMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Déclaration et attribution des variables
            string password = passwordboxLoginPassword.Password.ToString();
            string mail = textboxLoginMail.Text;
            // Execution de la requete afin de récuperer id de utilisateur si il existe
            string login = users.Login(mail, password);
            // Si requete ne renvoie pas null ou rien
            if (!String.IsNullOrEmpty(login))
            {
                // On stock le login dans une attribut de la classe Users
                users.IdUserConnected = int.Parse(login);
                textblockErrorLogin.Text = "Identification réussie !";
                // Instanciation  de la fenêtre profil
                Profil profilWindow = new Profil();
                // Affichage de la fenêtre profil
                profilWindow.Show();
                // Fermeture de la fenêtre actuelle
                this.Close();

            }
        }

        
    }
}
