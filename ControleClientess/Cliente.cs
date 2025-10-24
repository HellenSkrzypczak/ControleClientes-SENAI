﻿namespace ControleClientess
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Genero Genero { get; set; }
        public string Cep { get; set; }

        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public bool? Erro { get; set; }
    }
}
