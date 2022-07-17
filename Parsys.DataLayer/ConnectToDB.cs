using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parsys.DataLayer
{

    public class ConnectTo
    {
        public async Task<int> ServerOrDatabase(string connectionStr, bool WithMaster)
        {
            SqlConnectionStringBuilder conMaster = new SqlConnectionStringBuilder();
            conMaster.ConnectionString = connectionStr;
            string initialCatalogString = conMaster.InitialCatalog;
            conMaster.InitialCatalog = "master";

            if (WithMaster)
            {
                using (SqlConnection con = new SqlConnection(conMaster.ConnectionString))
                {
                    try
                    {
                        await con.OpenAsync();
                        return 1;
                    }
                    catch
                    {
                        return 0;
                    }
                }
            }
            else
            {
                using (SqlConnection con = new SqlConnection(conMaster.ConnectionString))
                {
                    SqlCommand com = new SqlCommand("select count(*) from sys.databases where name=N'" + initialCatalogString + "'", con);

                    try
                    {
                        await con.OpenAsync();
                        int result = (int)await com.ExecuteScalarAsync();
                        return result;
                    }
                    catch
                    {
                        MessageBox.Show("خطای غیر منتظره! لطفا با ادمین سیستم ارتباط برقرار نمایید");
                        return 0;
                    }
                }



            }
        }

        public async Task InitialDatabase(string connectionStr, string dbName)
        {
            using (SqlConnection con = new SqlConnection(connectionStr))
            {
                SqlCommand com = new SqlCommand("create database " + dbName, con);
                await com.ExecuteNonQueryAsync();
            }
        }


        public async Task InitialTables(string connectionStr,string command)
        {
            using (SqlConnection con = new SqlConnection(connectionStr))
            {
                SqlCommand com = new SqlCommand(command, con);
                await com.ExecuteNonQueryAsync();
            }
        }



    }
}
