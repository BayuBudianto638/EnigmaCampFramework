using System.Threading.Tasks;
using EnigmaCamp.Models.TokenAuth;
using EnigmaCamp.Web.Controllers;
using Shouldly;
using Xunit;

namespace EnigmaCamp.Web.Tests.Controllers
{
    public class HomeController_Tests: EnigmaCampWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}