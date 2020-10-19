using System.IO;
using UnitTest.Library;
using Unit.Test.Configuration;
using Xunit;

namespace Unit.Test
{
    [TestCaseOrderer("UnitTest.Test.Configuration.PriorityOrderer", "UnitTest.Test")]    
    public class DiretorioIOTest
    {
        [Fact(DisplayName = "Diretorio_CriarDiretorio_DeveCriarUmDiretorio"), TestPriority(1)]        
        public void Diretorio_CriarDiretorio_DeveCriarUmDiretorio()
        {
            //Arrange
            var pasta = @"c:\DiretorioTeste";
            var estrutura = new DiretorioIO();

            //Act
            estrutura.CriarDiretorio(pasta);
            var existe = Directory.Exists(pasta);

            //Assert
            Assert.True(existe);
        }

        [Fact(DisplayName = "Diretorio_RemoverDiretorio_DeveApagarUmDiretorio"), TestPriority(2)]
        public void Diretorio_RemoverDiretorio_DeveApagarUmDiretorio()
        {
            //Arrange
            var pasta = @"c:\DiretorioTeste";
            var estrutura = new DiretorioIO();

            //Act
            estrutura.RemoverDiretorio(pasta);
            var existe = Directory.Exists(pasta);

            //Assert
            Assert.False(existe);
        }
    }
}
