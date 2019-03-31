using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using TabelaUnica.Entidades;
using TabelaUnica.Entidades.Mapeamento;
using System.Linq;

namespace TabelaUnica.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                            .Database(MsSqlConfiguration.MsSql2012.ConnectionString("Data Source=localhost;Initial Catalog=HerancaNHibernate;User ID=sa;Password=NHibernate@123")
                            .ShowSql().FormatSql())
                            .Mappings(m =>
                                m.FluentMappings
                                .AddFromAssemblyOf<PessoaMap>())
                            .BuildSessionFactory();

            ISession session = sessionFactory.OpenSession();

            PessoaFisica pf = new PessoaFisica()
            {
                Cidade = "Rio de Janeiro",
                CPF = "45042960716",
                DataNascimento = DateTime.Now.AddYears(-20),
                Endereco = "Rua de Teste",
                Nome = "Fulano da Silva",
                Numero = "3434",
                Pais = "Brasil",
                Telefone = "99999-9999",
                UF = "RJ"
            };

            session.SaveOrUpdate(pf);

            PessoaJuridica pj = new PessoaJuridica()
            {
                Cidade = "Rio de Janeiro",
                CNPJ = "00000000000",
                RazaoSocial = "Nome Razao Social",
                Endereco = "Rua de Teste Empresa",
                Nome = "Empresa Teste",
                Numero = "0000",
                Pais = "Brasil",
                Telefone = "99999-9999",
                UF = "RJ"
            };

            session.SaveOrUpdate(pj);
            session.Flush();

            var pessoas = session.Query<Pessoa>().Count();
            System.Console.WriteLine($"Quantidade de entidades do tipo Pessoa: {pessoas}");

            var pessoasFisicas = session.Query<PessoaFisica>().Count();
            System.Console.WriteLine($"Quantidade de entidades do tipo PessoaFisica: {pessoasFisicas}");

            var pessoasJuridicas = session.Query<PessoaJuridica>().Count();
            System.Console.WriteLine($"Quantidade de entidades do tipo PessoaJuridica: {pessoasJuridicas}");
        }
    }
}
