using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace TabelaUnica.Entidades.Mapeamento
{
    public class PessoaMap : ClassMap<Pessoa>
    {
        public PessoaMap()
        {
            Table("Pessoa");
            Id(x => x.Id, "[Id]").GeneratedBy.Identity();
            Map(x => x.Cidade, "[Cidade]").Not.Nullable().Length(50);
            Map(x => x.Nome, "[Nome]").Not.Nullable().Length(50);
            Map(x => x.Numero, "[Numero]").Not.Nullable().Length(10);
            Map(x => x.Pais, "[Pais]").Not.Nullable().Length(50);
            Map(x => x.Endereco, "[Endereco]").Not.Nullable().Length(255);
            Map(x => x.Telefone, "[Telefone]").Not.Nullable().Length(10);
            Map(x => x.UF, "[UF]").Not.Nullable().Length(2);
            DiscriminateSubClassesOnColumn("Tipo").Not.Nullable().Length(50);
        }
    }
}
