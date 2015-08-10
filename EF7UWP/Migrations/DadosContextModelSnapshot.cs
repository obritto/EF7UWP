using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using EF7UWP.Models;

namespace EF7UWPMigrations
{
    [ContextType(typeof(DadosContext))]
    partial class DadosContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("EF7UWP.Models.Pessoa", b =>
                {
                    b.Property<int>("idPessoa")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nome")
                        .Required();

                    b.Property<string>("telefone");

                    b.Key("idPessoa");
                });
        }
    }
}
