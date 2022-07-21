using System.Threading.Tasks;

namespace Parsys.DataLayer.Connections.ProviderAbstracts
{
    public interface IConnection
    {
        string DbConnectionName { get;  }

        Task<bool> CheckConnection();
        Task<bool> CheckDatabase();
        Task<bool> CreateDatabase(string script);
        void SetConnection(string connection);
        string GetConnection();
    }
}
