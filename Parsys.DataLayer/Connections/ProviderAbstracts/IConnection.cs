using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsys.DataLayer.Connections.ProviderAbstracts
{
    public interface IConnection
    {
            Task<bool> CheckConnection();
            Task<bool> CheckDatabase();
            Task<bool> CreateDatabase(string script);
            void RefreshConnection(string connection);
    }
}
