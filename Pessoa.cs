﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElemento.Models
{
    public class Pessoa
    {
      
        private string nome;
        private string cpf;
        private string endereco;
        private string senha;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Senha { get => senha; set => senha = value; }

        public string Salva(Pessoa pessoa)
        {
           

            if (string.IsNullOrEmpty(pessoa.Nome) ||
                    string.IsNullOrEmpty(pessoa.Cpf) ||
                    string.IsNullOrEmpty(pessoa.Senha))
            {
               
                return "Um dos campos obrigatórios não foi preenchido";
            }
            else
            {
                return "Salvo com sucesso";
            }
        }
    }
}