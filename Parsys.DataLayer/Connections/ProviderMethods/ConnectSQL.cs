using Parsys.DataLayer.Connections.ProviderAbstracts;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Parsys.DataLayer.Connections.ProviderMethods
{
    public class ConnectToSQL : IConnection
    {
        private SqlConnectionStringBuilder sqlCon = new SqlConnectionStringBuilder();
        private readonly SqlConnectionStringBuilder masterCon = new SqlConnectionStringBuilder();
        public string DbConnectionName { get => "parsysdb"; }

        public ConnectToSQL()
        {
            GetConnection();
        }



        public async Task<bool> CheckConnection()
        {
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
            using (SqlConnection con = new SqlConnection(masterCon.ConnectionString))
            {
                try
                {
                    await con.OpenAsync();
                    SqlCommand com = new SqlCommand("select count(*) from sys.databases where name= N'" + DbConnectionName + "'", con);
                    if ((int)await com.ExecuteScalarAsync() == 1)
                        return true;
                    return false;
                }
                catch { return false; }
            }
        }



        public async Task<bool> CreateDatabase(string script)
        {
            using (SqlConnection con = new SqlConnection(masterCon.ConnectionString))
            {
                try
                {
                    await con.OpenAsync();
                    SqlCommand com = new SqlCommand("create database " + DbConnectionName, con);
                    await com.ExecuteNonQueryAsync();
                    using (SqlConnection conScript = new SqlConnection(sqlCon.ConnectionString))
                    {
                        await conScript.OpenAsync();
                        string scriptText = script.Replace("[ShopDb]", "[" + DbConnectionName + "]");
                        SqlCommand comScript = new SqlCommand(scriptText, con);
                        if (await comScript.ExecuteNonQueryAsync() == 1)
                            return true;
                    }
                    return false;
                }
                catch { return false; }
            }
        }



        public string GetConnection()
        {
            ConfigurationManager.RefreshSection("connectionStrings");
            sqlCon.ConnectionString = ConfigurationManager.ConnectionStrings["PARSYS"].ConnectionString;
            masterCon.ConnectionString = sqlCon.ConnectionString;
            masterCon.InitialCatalog = "master";
            return sqlCon.ConnectionString;
        }



        public void SetConnection(string ConnectionsString)
        {
            var configManager = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configManager.ConnectionStrings.ConnectionStrings["PARSYS"].ConnectionString = ConnectionsString;
            configManager.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
