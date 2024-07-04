using WebBase.Dtos;
using WebBase.Models;

namespace WebBase.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<Endereco>> BuscarEnderecoPorCep(string cep);
        Task<ResponseGenerico<List<Banco>>> BuscarTodosBancos();
        Task<ResponseGenerico<Banco>> BuscarBanco(string codigoBanco);
    }
}
