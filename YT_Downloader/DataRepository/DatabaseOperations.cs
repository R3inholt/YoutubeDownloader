using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YT_Downloader;

namespace DataRepository
{
    static class DatabaseOperations
    {
        public static void AddNewUserGuid(string userGuid)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\amadi\source\repos\YT_Downloader\YT_Downloader\DownloadHistoryDB.mdf; Integrated Security = True");

            try
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Users VALUES (@userGuid)", conn);
                cmd.Parameters.AddWithValue("@userGuid", userGuid);

                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while adding new guid to database: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void AddNewRecord(string currentGuid, string title, string format, string savePath)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\amadi\source\repos\YT_Downloader\YT_Downloader\DownloadHistoryDB.mdf; Integrated Security = True");

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO FilesHistory (Guid, Title, Format, [Save path]) VALUES (@currentGuid, @title, @format, @savePath)",conn);
                cmd.Parameters.AddWithValue("@currentGuid", currentGuid);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@format", format);
                cmd.Parameters.AddWithValue("@savePath", savePath);

                conn.Open();

                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while adding new record to database: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable FillDataGridView(string guid)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\amadi\source\repos\YT_Downloader\YT_Downloader\DownloadHistoryDB.mdf; Integrated Security = True");
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [FilesHistory] WHERE Guid LIKE @guid", conn);
                cmd.Parameters.AddWithValue("@guid", guid);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                return dt;

            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured while populating history table: " + ex.Message);
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
