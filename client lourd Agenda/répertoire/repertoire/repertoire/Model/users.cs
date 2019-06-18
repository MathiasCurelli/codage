using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace repertoire.Model
{
    public class users
    {
        
        public static int IdUserConnected;

        public static void SaveInfo(string lastname, string firstname, string username, string mail, string password)
        {
            try
            {
                // Query.  
                string query = "INSERT INTO [repertory].[dbo].[users] ([lastname], [firstname], [username], [mail], [password] )" +
                                " VALUES ('" + lastname + "', '" + firstname + "', '" + username + "', '" + mail + "', '" + password + "')";

                // Execute.  
                MainWindow.executeQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        public static string VerifMail(string mail)
        {
            // Déclaration de la variable mailR en NULL
            string mailR = null;
            // Rêquete SQL
            string query = "SELECT [mail] FROM [repertory].[dbo].[users] AS [users]" +
                    " WHERE [users].[mail] = '" + mail + "'";
            // On stock le résultat de la rêquete dans la variable mailR
            mailR = MainWindow.ExecuteQueryString(query);
            // Retourne la variable mailR
            return mailR;
        }
        public static string Login(string mail, string password)
        {
            // Rêquete SQL
            string query = "SELECT [idUser] FROM [repertory].[dbo].[Users] AS [Users]" +
                    " WHERE [Users].[mail] = '" + mail + "';";
            // On stock le résultat de la rêquete dans la variable login
            string login = MainWindow.ExecuteQueryString(query);
            // Retourne la variable login
            return login;
        }
    }
}
