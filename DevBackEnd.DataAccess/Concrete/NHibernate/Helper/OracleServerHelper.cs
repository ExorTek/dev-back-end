using DevBackEnd.Core.DataAccess.NHibernate;
using FluentNHibernate.Cfg;
using Microsoft.Extensions.Configuration;
using NHibernate;
using System.Reflection;
using FluentNHibernate.Cfg.Db;

namespace DevBackEnd.DataAccess.Concrete.NHibernate.Helper
{
    public class OracleServerHelper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration["ConnectionStrings:OracleServer"];
#pragma warning disable 618
            return Fluently.Configure().Database(OracleClientConfiguration.Oracle10.ConnectionString(connectionString))
#pragma warning restore 618
                .Mappings(t => t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).BuildSessionFactory();
        }
    }
}