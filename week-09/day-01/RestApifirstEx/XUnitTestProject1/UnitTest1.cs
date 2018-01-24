using System;
using Xunit;
using RestApifirstEx.Entities;
using RestApifirstEx.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace RestApifirstEx.XUnitTestProject1
{
    public class UnitTest1
    {

        private readonly TestServer server;
        private readonly HttpClient client;

        public UnitTest1()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            client = server.CreateClient();
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
