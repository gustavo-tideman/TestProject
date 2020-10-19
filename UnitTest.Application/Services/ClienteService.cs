using AutoMapper;
using UnitTest.Application.Interface;
using UnitTest.Application.ViewModel;
using UnitTest.Data.Interface;
using UnitTest.Data.Model;

namespace UnitTest.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public ClienteViewModel Adicionar(ClienteViewModel model)
        {
            var cliente = _mapper.Map<Cliente>(model);
            _clienteRepository.Adicionar(cliente);
            return model;
        }
    }
}