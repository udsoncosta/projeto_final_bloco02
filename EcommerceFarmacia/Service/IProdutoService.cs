﻿using EcommerceFarmacia.Model;

namespace EcommerceFarmacia.Service
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> GetAll();
        Task<Produto?> GetById(long id);
        Task<IEnumerable<Produto>> GetByNome(string nome);
        Task<IEnumerable<Produto>> GetByDescricao(string descricao);
        Task<Produto?> Create(Produto produto);
        Task<Produto?> Update(Produto produto);
        Task Delete(Produto produto);
    }
}