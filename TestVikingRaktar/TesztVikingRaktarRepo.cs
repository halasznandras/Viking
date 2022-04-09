using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Security.Policy;
using System.Threading.Tasks;
using VikingRaktar;
using Xunit;

namespace TestVikingRaktar
{
    //TDD

    public class TesztVikingRaktarRepo: IClassFixture<WebApplicationFactory<VikingRaktar.Startup>>
    {
        private readonly WebApplicationFactory<VikingRaktar.Startup> _factory;

        public TesztVikingRaktarRepo(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        
        [Theory]
        [InlineData("/"]
        [InlineData("/Home/Index"]
        [InlineData("/Raktar/Index"]
        [InlineData("/Raktar/Details"]
        [InlineData("/Raktar/Edit"]
        [InlineData("/Raktar/Create"]
        public async Task TesztRaktarIndexPage(string title)

    
        {

            //Arrange, Act, Assert
            //Arrange

            var client = _factory.CreateClient();

            //act
            var response = await client.GetAsync("/Raktar/Index");
            //var response = await client.GetAsync(Url);
            var pageContent = await response.Content.ReadAsStringAsync();
            var content = pageContent.ToString();
            //int code = (int)response.StatusCode;

            //assert
            Assert.Contains(title, content);
            //Assert.Equal(200, code);

        }

    }
}
