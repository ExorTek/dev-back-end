using DevBackEnd.DataAccess.Abstract;
using Microsoft.Extensions.Configuration;

namespace DevBackEnd.DataAccess.Concrete.DbConfiguration
{
    public class ServerConfiguration:IServerConfiguration<string>
    {
        public string ConnectionServer()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration["ConnectionStrings:Connection"];
            return connectionString;
        }
    }
}