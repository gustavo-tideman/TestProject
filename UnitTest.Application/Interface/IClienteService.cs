using UnitTest.Application.ViewModel;

namespace UnitTest.Application.Interface
{
    public interface IClienteService
    {
        ClienteViewModel Adicionar(ClienteViewModel model);
    }
}
