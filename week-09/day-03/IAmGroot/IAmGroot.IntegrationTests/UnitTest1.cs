using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace IAmGroot.IntegrationTests
{
    public class GuardianTests
    {
        private HttpClient Client;
        private TestServer Server;

        public GuardianTests()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GrootShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/groot");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GrootShouldReturnOKJson()
        {
            //act
            var response = await Client.GetAsync("/groot?message=somemessage");
            string json = await response.Content.ReadAsStringAsync();
            //assert
            Assert.Equal("{\"recived\":\"somemessage\",\"translated\":\"I am Groot!\"}", json);
        }

        [Fact]
        public async Task GrootShouldReturnErrorJson()
        {
            //act
            var response = await Client.GetAsync("/groot?message=");
            string json = await response.Content.ReadAsStringAsync();
            //assert
            Assert.Equal("{\"error\":\"I am Groot!\"}", json);
        }
    }

    
}
