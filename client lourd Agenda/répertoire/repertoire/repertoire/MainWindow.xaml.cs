using repertoire.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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


namespace repertoire
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int executeQuery(string query)
        {
            // Initialization.  
            int rowCount = 0;
            string strConn = "data source=DELL-PC\\SQLEXPRESS;initial catalog=repertory;integrated security=True;multipleactiveresultsets=True; database=repertory; integrated security=SSPI;";
            SqlConnection sqlConnection = new SqlConnection(strConn);
            SqlCommand sqlCommand = new SqlCommand();
            try
            {
                // Settings.  
                sqlCommand.CommandText = query;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandTimeout = 12 * 3600; //// Setting timeeout for longer queries to 12 hours.  

                // Open.  
                sqlConnection.Open();

                // Result.  
                rowCount = sqlCommand.ExecuteNonQuery();

                // Close.  
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                // Close.  
                sqlConnection.Close();

                throw ex;
            }
            return rowCount;
        }
        public static string ExecuteQueryString(string query)
        {
            // Initialisation. 
            string result = null;
            string strConn = "data source=DELL-PC\\SQLEXPRESS;initial catalog=repertory;integrated security=True;multipleactiveresultsets=True; database=repertory; integrated security=SSPI;";
            SqlConnection sqlConnection = new SqlConnection(strConn);
            SqlCommand sqlCommand = new SqlCommand();
            try
            {
                // Parametres.  
                sqlCommand.CommandText = query;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;
                //sqlCommand.CommandTimeout = 12 * 3600;
                // Open la connexion.   
                sqlConnection.Open();
                // on stock le résultat de l'execution. .  
                result = sqlCommand.ExecuteScalar().ToString();

                // Ferme la connexion..  
                sqlConnection.Close();
            }
            catch
            {
                // Ferme la connexion..  
                sqlConnection.Close();
                result = null;
            }
            // Retourne la variable string result
            return result;
        }

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            string lastnameRegex = @"^([a-zA-Z .&'-]+)$";
            string firstnameRegex = @"^([a-zA-Z .&'-]+)$";
            string mailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            string usernameRegex = @"^([a-zA-Z .&'-]+)$";
            try
            {
                // Initialisation.  
                string lastname = this.txtLastname.Text;
                string firstname = this.txtFirstname.Text;
                string username = this.txtUsername.Text;
                string mail = this.txtMail.Text;
                string password = this.txtPassword.Password.ToString();
                string passwordConfirm = this.txtConfirmPassword.Password.ToString();

                // Verification. 
                bool isValid = true;
                if (string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(password))
                {
                    // Display Message 
                    isValid = false;
                    MessageBox.Show("Les champs ne peuvent rester vides ! Veuillez les remplir !", "Echec", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (!Regex.IsMatch(lastname, lastnameRegex))
                {
                    isValid = false;
                    MessageBox.Show("Merci de saisir un nom valide", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (!Regex.IsMatch(firstname, firstnameRegex))
                {
                    isValid = false;
                    MessageBox.Show("Merci de saisir un prénom valide", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (!Regex.IsMatch(username, usernameRegex))
                {
                    isValid = false;
                    MessageBox.Show("Merci de saisir un pseudo valide", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (!Regex.IsMatch(mail, mailRegex))
                {
                    isValid = false;
                    MessageBox.Show("Merci de saisir un mail valide", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    // Vérification si le mail existe
                    if (!String.IsNullOrEmpty(users.VerifMail(mail)))
                    {
                        TextBlockMailErrorMessage.Text = mail + " ce mail existe déjà";

                        // Remet les champs password a zéro
                        txtPassword.Password = null;
                        txtConfirmPassword.Password = null;
                        isValid = false;

                    }
                    else
                    {
                        TextBlockMailErrorMessage.Text = "";
                    }

                    if (!Regex.IsMatch(password, lastnameRegex))
                    {
                        isValid = false;
                        MessageBox.Show("Merci de saisir un mot de passe valide", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    if (txtPassword.Password != txtConfirmPassword.Password)
                    {
                        isValid = false;
                        MessageBox.Show("Les mots de passes saisis ne sont pas identiques, attention !", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    if (isValid)
                    {
                        // Sauvegarde les infos.  
                        users.SaveInfo(lastname, firstname, username, mail, password);

                        // affichage du Message de succès et effaçage des champs text  
                        MessageBox.Show("Enregistré avec succès !", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
                        txtLastname.Text = string.Empty;
                        txtFirstname.Text = string.Empty;
                        txtUsername.Text = string.Empty;
                        txtMail.Text = string.Empty;
                        txtPassword.Password = string.Empty;
                        txtConfirmPassword.Password = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                // Display Message  
                MessageBox.Show("Une erreur est survenue, veuillez réessayer.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }        
        }
        private void Hyperlink_Returne_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            login login = new login(); // j'instancie mon objet avec la fenêtre login
            login.Show();
            this.Close();
        }
        public static DataSet ExecuteDataSetQuery(string query)
        {
            string strConn = "data source=DELL-PC\\SQLEXPRESS;initial catalog=repertory;integrated security=True;multipleactiveresultsets=True; database=repertory; integrated security=SSPI;";

            // instanciation d'un objet de type sqlConnection
            SqlConnection sqlConnection = new SqlConnection(strConn);

            // ouverture de la connexion
            sqlConnection.Open();

            // id de l'utilisateur actuellement connecté
            int idConnectedUser = users.IdUserConnected;
            //query
            SqlCommand sqlCommand = new SqlCommand();

            // attribution de valeurs aux attributs de l'objet sqlCommand
            sqlCommand.CommandText = query;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandTimeout = 2 * 3600;

            // instanciation d'un objet adapter de la classe SqlDataAdaptateur
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCommand;
            // instanciation d'un objet dataSet de la classe DataSet
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet); // remplis l'objet adapter avec l'objet dataSet 

            // fermeture de la connexion
            sqlConnection.Close();

            return dataSet;
        }

    }
}



