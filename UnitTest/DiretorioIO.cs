using System.IO;

namespace UnitTest.Library
{
    public class DiretorioIO
    {
        public void PrepararEstrutura()
        {
            string path = @"c:\DiretorioTeste";

            if (VerificarDiretorioExistente(path))
            {
                RemoverDiretorio(path);
            }
            CriarDiretorio(path);
        }

        public void CriarDiretorio(string path)
        {            
            Directory.CreateDirectory(path);
        }

        public void RemoverDiretorio(string path)
        {
            var diretorio = new DirectoryInfo(path);
            diretorio.Delete(true);
        }

        public bool VerificarDiretorioExistente(string path)
        {
            if (Directory.Exists(path))
            {
                return true;
            }
            return false;
        }
    }
}
