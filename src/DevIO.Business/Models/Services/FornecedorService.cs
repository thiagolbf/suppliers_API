﻿

using DevIO.Business.Interfaces;

namespace DevIO.Business.Models.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository)
        {        
           _fornecedorRepository = fornecedorRepository;
        }
        public async Task Adicionar(Fornecedor fornecedor)
        {
            //Validar se a entidade é consistente
            //Validar se ja não existe outro fornecedor com o mesmo documento

            await _fornecedorRepository.Adicionar(fornecedor);
        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
           await _fornecedorRepository.Atualizar(fornecedor);
        }
 
        public async Task Remover(Guid id)
        {
            await _fornecedorRepository.Remover(id);
        }
        public void Dispose()
        {
            _fornecedorRepository?.Dispose();
        }
    }
}
