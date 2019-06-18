using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repertoire.Model
{
    class Contact
    {
        public static string IdUserConnected { get; private set; }

        public static void SaveInfo(string lastname, string firstname, string mail, string phoneNumber, string address)
        {
            try
            {
                // Query.  
                string query = "INSERT INTO [repertory].[dbo].[contact] ([lastname], [firstname], [mail], [phoneNumber], [address], [idUser] )" +
                                " VALUES ('" + lastname + "', '" + firstname + "', '" + mail + "', '" + phoneNumber + "', '" + address + "', '" + users.IdUserConnected + "')";

                // Execute.  
                MainWindow.executeQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataSet SearchForContacts(int IdUserConnected)
        {
            try
            {
                string query = "SELECT [lastname], [firstname], [mail], [phoneNumber], [address] FROM [dbo].[contact] WHERE [idUser] = '" + IdUserConnected + "';";
                return MainWindow.ExecuteDataSetQuery(query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
