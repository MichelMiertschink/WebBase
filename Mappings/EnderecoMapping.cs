using AutoMapper;
using WebBase.Dtos;
using WebBase.Models;

namespace WebBase.Mappings
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, Endereco>();
            CreateMap<Endereco, EnderecoResponse>();
        }
    }
}
