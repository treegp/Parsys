using Parsys.DataLayer.Connections.ProviderAbstracts;
using Parsys.DataLayer.Connections.ProviderMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parsys.DataLayer.Entities.EntityAbstracts;
using Parsys.DataLayer.Entities.EntityMethods;
using Parsys.DataLayer.Entities.EntityModels;

namespace Parsys.WinClient.IoC
{
    public class TypesRegistery :StructureMap.Registry
    {
        public TypesRegistery()
        {
            For<IConnection>().Use<ConnectToSQL>();
            For<ICorporationsRepository>().Use<CorporationsRepository>();
        }
    }
}
