using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace TabelaUnica.Entidades.Mapeamento
{
    public class PessoaJuridicaMap : SubclassMap<PessoaJuridica>
    {
        public PessoaJuridicaMap()
        {
            Map(x => x.CNPJ, "[CNPJ]").Not.Nullable().Length(14);
            Map(x => x.RazaoSocial, "[RazaoSocial]").Not.Nullable().Length(50);
        }
    }
}
