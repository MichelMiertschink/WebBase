using AutoMapper;
using WebBase.Dtos;

namespace WebBase.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}
