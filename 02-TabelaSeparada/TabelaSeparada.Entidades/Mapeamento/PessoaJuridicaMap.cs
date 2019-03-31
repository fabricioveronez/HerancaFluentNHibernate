using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace TabelaSeparada.Entidades.Mapeamento
{
    public class PessoaJuridicaMap : SubclassMap<PessoaJuridica>
    {
        public PessoaJuridicaMap()
        {
            Table("[PessoaJuridica]");
            KeyColumn("[PessoaJuridicaId]");
            Map(c => c.CNPJ, "[CNPJ]").Not.Nullable().Length(14);
            Map(c => c.RazaoSocial, "[RazaoSocial]").Not.Nullable().Length(50);
        }
    }
}
