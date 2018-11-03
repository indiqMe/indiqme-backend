using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using IndiqMe.Api;
using System.Net.Http;

namespace IndiqMe.Test.Integration.Base
{
    public class IntegrationTestBase
    {
        public TestServer Server { get; set; }
        public HttpClient Client { get; set; }

        public IntegrationTestBase()
        {
            Server = new TestServer(new WebHostBuilder()
                    .UseStartup<Startup>());
            Client = Server.CreateClient();
        }
    }
}
