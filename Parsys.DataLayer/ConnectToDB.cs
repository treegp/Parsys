using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parsys.DataLayer
{

    public class ConnectTo
    {
        public async Task<int> ServerOrDatabase(SqlConnectionStringBuilder conBuilder, bool WithMaster)
        {
            if (WithMaster)
            {
                conBuilder.InitialCatalog = "master";
                using (SqlConnection con = new SqlConnection(conBuilder.ConnectionString))
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
                using (SqlConnection con = new SqlConnection(conBuilder.ConnectionString))
                {
                    SqlCommand com = new SqlCommand("select count(*) from sys.databases where name=N'" + conBuilder.InitialCatalog.ToString() + "'",con);

                    try
                    {
                        int result = (int)await com.ExecuteScalarAsync();
                        return result;
                    }
                    catch
                    {
                        MessageBox.Show("خطای غیر منتظره!/nلطفا با ادمین سیستم ارتباط برقرار نمایید");
                        return 0;
                    }
                }



            }
        }




    }
}
