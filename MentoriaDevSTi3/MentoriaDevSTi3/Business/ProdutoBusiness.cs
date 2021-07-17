using MentoriaDevSti3.Data.Context;
using MentoriaDevSti3.Data.Entidades;
using MentoriaDevSTi3.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentoriaDevSTi3.Business
{
    public class ProdutoBusiness
    {
        private readonly MentoriaDevSti3Context _context; 

        public ProdutoBusiness()
        {
            _context = new MentoriaDevSti3Context();
        }

        public void Adicionar(ProdutoViewModel produtoViewMode)
        {
            _context.Produtos.Add(new Produto
            {
                Nome = produtoViewMode.Nome,
                Valor = produtoViewMode.Valor,
            });

            _context.SaveChanges();
        }

        public void Alterar(ProdutoViewModel produtoViewModel)
        {
            var produto = _context.Produtos.First(x => x.Id == produtoViewModel.Id);

            produto.Nome = produtoViewModel.Nome;
            produto.Valor = produtoViewModel.Valor;

            _context.SaveChanges();
        }

        public void Remover(long id)
        {
            var produto = _context.Produtos.First(x => x.Id == id);

            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }

        public List<ProdutoViewModel> Listar()
        {
            return _context.Produtos.AsNoTracking()                
                .Select(s => new ProdutoViewModel
                {
                    Id = s.Id,
                    Nome = s.Nome,
                    Valor = s.Valor
                }).ToList()
                .OrderBy(x => x.Nome).ToList();
        }
    }
}
