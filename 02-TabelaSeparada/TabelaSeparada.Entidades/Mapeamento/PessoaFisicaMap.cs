using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace TabelaSeparada.Entidades.Mapeamento
{
    public class PessoaFisicaMap : SubclassMap<PessoaFisica>
    {
        public PessoaFisicaMap()
        {
            Table("[PessoaFisica]");
            KeyColumn("[PessoaFisicaId]");
            Map(c => c.CPF, "[CPF]").Not.Nullable().Length(11);
            Map(c => c.DataNascimento, "[DataNascimento]").Not.Nullable();
        }
    }
}
