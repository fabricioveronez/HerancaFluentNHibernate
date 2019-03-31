using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace TabelaUnica.Entidades.Mapeamento
{
    public class PessoaFisicaMap : SubclassMap<PessoaFisica>
    {
        public PessoaFisicaMap()
        {
            Map(x => x.CPF, "[CPF]").Not.Nullable().Length(11);
            Map(x => x.DataNascimento, "[DataNascimento]").Not.Nullable();
        }
    }
}
