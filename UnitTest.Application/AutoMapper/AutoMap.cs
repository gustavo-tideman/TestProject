using AutoMapper;
using UnitTest.Data.Model;
using UnitTest.Application.ViewModel;

namespace UnitTest.Application.AutoMapper
{
    public class AutoMap : Profile
    {
        public AutoMap()
        {
            CreateMap<ClienteViewModel, Cliente>().ReverseMap();
        }
    }
}