using System;
using System.Collections.Generic;
using System.Text;

namespace TabelaUnica.Entidades
{
    public class PessoaFisica : Pessoa
    {
        public virtual DateTime DataNascimento { get; set; }
        public virtual string CPF { get; set; }
    }
}
