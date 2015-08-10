using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using EF7UWP.Models;

namespace EF7UWPMigrations
{
    [ContextType(typeof(DadosContext))]
    partial class EstruturaInicial
    {
        public override string Id
        {
            get { return "20150810173123_EstruturaInicial"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
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
