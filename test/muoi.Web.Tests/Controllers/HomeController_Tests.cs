using System.Threading.Tasks;
using muoi.Models.TokenAuth;
using muoi.Web.Controllers;
using Shouldly;
using Xunit;

namespace muoi.Web.Tests.Controllers
{
    public class HomeController_Tests: muoiWebTestBase
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