﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientess
{
    public class ClienteRepository
    {
        private readonly AppDbContext _context;
        public ClienteRepository()
        {
            _context = new AppDbContext();
        }
        public void Adicionar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }
        public List<Cliente> ListarTodos()
        {
            return _context.Clientes.ToList();
        }
        public Cliente ObterPorId(int id)
        {
            return _context.Clientes.Find(id);
        }
        public void Atualizar(Cliente cliente)
        {
            Cliente clienteExistente = ObterPorId(cliente.Id);
            if (clienteExistente != null)
            {
                clienteExistente.Nome = cliente.Nome;
                clienteExistente.Email = cliente.Email;
                clienteExistente.Genero = cliente.Genero;
                clienteExistente.Cep = cliente.Cep;
                clienteExistente.Logradouro = cliente.Logradouro;
                clienteExistente.Bairro = cliente.Bairro;
                clienteExistente.Cidade = cliente.Cidade;
                clienteExistente.Estado = cliente.Estado;
                _context.SaveChanges();
            }
        }
        public void Remover(int id)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }

}
