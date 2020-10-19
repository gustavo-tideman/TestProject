using Automated.Test.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UnitTest.Web;
using Xunit;

namespace Automated.Test
{
    [Collection(nameof(IntegrationWebTestsFixtureCollection))]
    public class Cliente
    {
        private readonly IntegrationTestsFixture<Startup> _testsFixture;

        public Cliente(IntegrationTestsFixture<Startup> testsFixture)
        {

        }

        [Fact(DisplayName = "Realizar cadastro com sucesso")]
        public void Usuario_RealizarCadastro_DeveExecutarComSucesso()
        {
            // Arrange
            var browser = new SeleniumHelper(Browser.Chrome, new ConfigurationHelper(), false);
            browser.IrParaUrl("https://www.verisys.com.br/");
            browser.PreencherTextBoxPorId("txtName", "Dunha");
            browser.PreencherTextBoxPorId("txtEmail", "dunha@teste.com.br");

            // Act

            // Assert
        }
    }
}
