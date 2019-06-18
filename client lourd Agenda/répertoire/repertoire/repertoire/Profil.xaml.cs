using repertoire.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Logique d'interaction pour Profil.xaml
    /// </summary>
    public partial class Profil : Window
    {
        private string strConn;
        private string mail;
        private string password;
        private string idConnectedUser;

        public Profil()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int id = users.IdUserConnected;
            textblockTitle.Text = id.ToString();

            SqlConnection con = new SqlConnection("data source=DELL-PC\\SQLEXPRESS;initial catalog=repertory;integrated security=True;multipleactiveresultsets=True; database=repertory; integrated security=SSPI;");
            // Ouverture de la connexion
            con.Open();

            string query = "SELECT [lastname], [firstname], [username], [mail] FROM [repertory].[dbo].[users] WHERE [idUser] = '" + id + "';";
            //attribution de valeurs aux attributs de l'objet sqlcommand1
            SqlCommand sqlCommand1 = new SqlCommand(query, con);
            sqlCommand1.CommandText = query;
            sqlCommand1.CommandType = CommandType.Text;
            sqlCommand1.Connection = con;
            sqlCommand1.CommandTimeout = 2 * 3600;
            // instanciation d'un objet adapter de la classe sqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCommand1;
            DataSet dataSet = new DataSet();           
            adapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count > 0) // Si la première table contient au moins une ligne, récup les infors stockées dedans, sinon message d'erreur
            {
                //Stockage des données du tableau dataset dans des variables
                string userName = dataSet.Tables[0].Rows[0]["username"].ToString();
                string userLastname = dataSet.Tables[0].Rows[0]["lastname"].ToString();
                string userFirstname = dataSet.Tables[0].Rows[0]["firstname"].ToString();                
                string userMail = dataSet.Tables[0].Rows[0]["mail"].ToString();
                textblockTitle.Text = userName; //Sending value from one form to another form.  
                profilLastname.Text = userLastname;
                profilFirstname.Text = userFirstname;
                profilUsername.Text = userName;
                profilMail.Text = userMail;
            }
            else
            {
                MessageBox.Show("Erreur, veuillez réessayer");
            }
            con.Close();
        }
        private void AddContact_Click(object sender, RoutedEventArgs e)
        {
            AddContact addContact = new AddContact();
            addContact.Show();
            this.Close();
        }

        private void ListContact_Click(object sender, RoutedEventArgs e)
        {
            listContact listContact = new listContact();
            listContact.Show();
            this.Close();
        }
    }
}
