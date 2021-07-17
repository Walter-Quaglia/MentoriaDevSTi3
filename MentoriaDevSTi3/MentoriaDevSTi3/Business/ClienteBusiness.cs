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
    public class ClienteBusiness 
    {
        private readonly MentoriaDevSti3Context _context;

        public ClienteBusiness()
        {
            _context = new MentoriaDevSti3Context(); 
        }

        public void  Adicionar(ClienteViewModel clienteViewModel)
        {
            _context.Clientes.Add(new Cliente
            {
                Nome = clienteViewModel.Nome,
                DataNascimento = clienteViewModel.DataNascimento,
                Endereco = clienteViewModel.Endereco,
                Cidade = clienteViewModel.Cidade,
                Cep = clienteViewModel.Cep
            });

            _context.SaveChanges();
        }

        public void Alterar(ClienteViewModel clienteViewModel)
        {
            var cliente = _context.Clientes.First(x => x.Id == clienteViewModel.Id);

            cliente.Nome = clienteViewModel.Nome;
            cliente.DataNascimento = clienteViewModel.DataNascimento;
            cliente.Endereco = clienteViewModel.Endereco;
            cliente.Cidade = clienteViewModel.Cidade;
            cliente.Cep = clienteViewModel.Cep;

            _context.SaveChanges();
        }

        public void Remover(long id)
        {
            var cliente = _context.Clientes.First(x => x.Id == id);

            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }

        public List<ClienteViewModel> Listar()
        {
            return _context.Clientes.AsNoTracking()
                .Select(s => new ClienteViewModel
                {
                    Id = s.Id,
                    Nome = s.Nome,
                    DataNascimento = s.DataNascimento,
                    Endereco = s.Endereco,
                    Cidade = s.Cidade,
                    Cep = s.Cep
                }).ToList()
                .OrderBy(x => x.Nome).ToList();
        }

    }
}
