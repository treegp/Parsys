using System;
using System.Reflection;

namespace Parsys.DataLayer.Entities.EntityModels
{
    public class GenericRepoModel
    {
        [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
        public class Table : Attribute
        {
            public string Schema { get; set; }
            public string Name { get; set; }


            public Table(string schema = "dbo")
            {
                Schema = schema;
                Name = typeof(Table).Name;
            }
        }

        [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
        public class Column : Attribute
        {
            public bool PrimaryKey { get; set; }
            public bool Computed { get; set; }
            public bool Required { get; set; }

            public Column(bool required = false, bool computed = false, bool primaryKey = false)
            {
                PrimaryKey = primaryKey;
                Computed = computed;
                Required = required;
            }
        }

    }

    public class ColumnSpecifics

    {
        public PropertyInfo ColumnType { get; set; }
        public string ColumnName { get; set; }
        public string PropertyName { get; set; }
        public bool Required { get; set; }
        public bool PrimaryKey { get; set; }
        public bool Computed { get; set; }
    }
}
