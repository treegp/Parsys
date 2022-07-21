using Parsys.DataLayer.Connections.ProviderAbstracts;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Parsys.DataLayer.Connections.ProviderMethods
{
    public class ConnectToSQL : IConnection
    {
        SqlConnectionStringBuilder sqlCon = new SqlConnectionStringBuilder();
        string dbConnectionName = "parsysdb";

        public ConnectToSQL(string Connection)
        {
            sqlCon.ConnectionString = Connection;
        }

        public async Task<bool> CheckConnection()
        {
            SqlConnectionStringBuilder masterCon = sqlCon;
            masterCon.InitialCatalog = "master";
            using (SqlConnection con = new SqlConnection(masterCon.ConnectionString))
            {
                try
                {
                    await con.OpenAsync();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public async Task<bool> CheckDatabase()
        {
            SqlConnectionStringBuilder masterCon = sqlCon;
            masterCon.InitialCatalog = "master";
            using (SqlConnection con = new SqlConnection(masterCon.ConnectionString))
            {
                try
                {
                    await con.OpenAsync();
                    SqlCommand com = new SqlCommand("select count(*) from sys.databases where name= N'" + dbConnectionName + "'", con);
                    if ((int)await com.ExecuteScalarAsync() == 1)
                        return true;
                }
                catch { }
                return false;

            }
        }

        public async Task<bool> CreateDatabase(string script)
        {
            SqlConnectionStringBuilder masterCon = sqlCon;
            masterCon.InitialCatalog = "master";
            using (SqlConnection con = new SqlConnection(masterCon.ConnectionString))
            {
                try
                {
                    await con.OpenAsync();
                    SqlCommand com = new SqlCommand("create database " + dbConnectionName, con);
                    if ((await com.ExecuteNonQueryAsync() == 1))
                    {
                        using (SqlConnection conScript = new SqlConnection(sqlCon.ConnectionString))
                        {
                            await conScript.OpenAsync();
                            string scriptText = Properties.Resources.script.Replace("[ShopDb]", "[" + dbConnectionName + "]");
                            SqlCommand comScript = new SqlCommand(scriptText, con);
                            if (await comScript.ExecuteNonQueryAsync() == 1)
                                return true;
                        }
                    }
                }
                catch { }
                return false;
            }
        }


        public void RefreshConnection(string connection)
        {
            var configManager = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configManager.ConnectionStrings.ConnectionStrings["PARSYS"].ConnectionString = connection;
            configManager.Save(ConfigurationSaveMode.Modified,true);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
