using System;
using System.Collections.Generic;
using System.Text;

namespace TabelaSeparada.Entidades
{
    public class PessoaJuridica : Pessoa
    {
        public virtual string RazaoSocial { get; set; }
        public virtual string CNPJ { get; set; }
    }
}
