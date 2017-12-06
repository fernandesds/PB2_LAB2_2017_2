using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2Guilherme.Models
{
    public class TrabalhoContext
    {
        {
    public class TrabalhoContext : DbContext
        {
            public class TrabalhoContext() : base("name=TrabalhoContext")
    {
    }

    public DbSet<Participante> Participantes { get; set; }

            public DbSet<Trabalho> Trabalhos { get; set; }

            public DbSet<Avaliacao> Avaliacaos { get; set; }

            public DbSet<Endereco> Enderecos { get; set; }

            public DbSet<Categoria> Categorias { get; set; }


            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                //Remove convenções de pluralização
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                //Remove conveções de deleção em cascata
                modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
                modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

                modelBuilder.Configurations.Add(new ConfiguracaoAvaliacao());
                modelBuilder.Configurations.Add(new CofiguracaoTrabalho());
                modelBuilder.Configurations.Add(new ConfiguracaoParticipante());
                modelBuilder.Configurations.Add(new ConfiguracaoCategoria());

                //Adicionando configurações globais do Fluent API
                modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

                modelBuilder.Properties<string>()
                    .Configure(p => p.HasMaxLength(200));

                modelBuilder.Properties<DateTime>()
                    .Configure(p => p.HasColumnType("datetime2"));

                //Mapeia todas as classes para o tipo stored procedures
                modelBuilder.Types()
                    .Configure(t => t.MapToStoredProcedures());
            }
        }
    }
}
}