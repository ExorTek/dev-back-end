using System.Reflection;
using DevBackEnd.Core.DataAccess.NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Extensions.Configuration;
using NHibernate;

namespace DevBackEnd.DataAccess.Concrete.NHibernate.Helper
{
    public class SqlServerHelper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            //return Fluently.Configure()
            //    .Database(MsSqlConfiguration.MsSql2012.ConnectionString(c =>
            //        c.Server("MEMET").Database("ETRADE").TrustedConnection()))
            //    .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).BuildSessionFactory();
            //

            //const string connectionString = @"server=MEMET;Database=ETRADE;Integrated Security=true";
            //return Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString))
            //    .Mappings(t => t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).BuildSessionFactory();

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration["ConnectionStrings:MsSqlServer"];

            return Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString))
                .Mappings(t => t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).BuildSessionFactory();
        }
    }
}