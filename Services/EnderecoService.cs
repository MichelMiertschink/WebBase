﻿using AutoMapper;
using WebBase.Dtos;
using WebBase.Interfaces;

namespace WebBase.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public EnderecoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep)
        {
            var endereco = await _brasilApi.BuscarEnderecoPorCep(cep);
            return _mapper.Map<ResponseGenerico<EnderecoResponse>>(endereco);
        }
    }
}
