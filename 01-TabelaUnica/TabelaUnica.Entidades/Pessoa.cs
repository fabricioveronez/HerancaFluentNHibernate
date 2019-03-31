using System;
using System.Collections.Generic;
using System.Text;

namespace TabelaUnica.Entidades
{
    public class Pessoa
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Endereco { get; set; }
        public virtual string Numero { get; set; }
        public virtual string Cidade { get; set; }
        public virtual string Pais { get; set; }
        public virtual string UF { get; set; }
        public virtual string Telefone { get; set; }
    }
}
