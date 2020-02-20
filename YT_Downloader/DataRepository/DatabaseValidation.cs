using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataRepository
{
    static class DatabaseValidation
    {
        public static bool CheckUserGuid(string userGuid)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amadi\source\repos\YT_Downloader\YT_Downloader\DownloadHistoryDB.mdf;Integrated Security=True");
            bool _ifGuidExists = false;

            try
            {                
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT Guid FROM Users WHERE Guid = @Guid", conn);
                cmd.Parameters.AddWithValue("@Guid", userGuid);

                int _affectedRows = cmd.ExecuteNonQuery();

                if (_affectedRows > 0)
                    _ifGuidExists = true;
                else
                    _ifGuidExists = false;

                MessageBox.Show("Checked succesfuly!");

                return _ifGuidExists;

            }
            catch(Exception ex)
            {
                MessageBox.Show("An error ocurred while reading data from database: " + ex.Message);
                return _ifGuidExists;
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
