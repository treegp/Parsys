using Parsys.DataLayer.Connections.ProviderAbstracts;
using Parsys.DataLayer.Connections.ProviderMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsys.IoC
{
    public class TypesRegistery :StructureMap.Registry
    {
        public TypesRegistery()
        {
            For<IConnection>().Use<ConnectToSQL>();
        }
    }
}
