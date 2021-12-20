﻿// <auto-generated />
using System;
using AGV.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AGV.Migrations
{
    [DbContext(typeof(AGVContext))]
    [Migration("20211214212400_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AGV.Models.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID PEDIDO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPedido"), 1L, 1);

                    b.Property<string>("cupomDesconto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Cupom de Desconto");

                    b.Property<int>("promocao")
                        .HasColumnType("int")
                        .HasColumnName("Promoção");

                    b.Property<string>("tipoPagamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Tipo de Pagamento");

                    b.HasKey("IdPedido");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("AGV.Models.Servico", b =>
                {
                    b.Property<int>("Idservico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID Serviço");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idservico"), 1L, 1);

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Cidade");

                    b.Property<DateTime>("dataIda")
                        .HasColumnType("datetime2")
                        .HasColumnName("Data da Ida");

                    b.Property<DateTime>("dataVolta")
                        .HasColumnType("datetime2")
                        .HasColumnName("Data da Volta");

                    b.Property<float>("preco")
                        .HasColumnType("real")
                        .HasColumnName("Preço");

                    b.Property<int>("qtdPassageiros")
                        .HasColumnType("int")
                        .HasColumnName("Quantidade de Passageiros");

                    b.HasKey("Idservico");

                    b.ToTable("Serviço");
                });

            modelBuilder.Entity("AGV.Models.Usuario", b =>
                {
                    b.Property<int>("Idusuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID Usuario");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idusuario"), 1L, 1);

                    b.Property<int?>("ServicoIdservico")
                        .HasColumnType("int");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CPF");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Endereço");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.HasKey("Idusuario");

                    b.HasIndex("ServicoIdservico");

                    b.ToTable("Usuário");
                });

            modelBuilder.Entity("AGV.Models.Usuario", b =>
                {
                    b.HasOne("AGV.Models.Servico", null)
                        .WithMany("UsuariosServico")
                        .HasForeignKey("ServicoIdservico");
                });

            modelBuilder.Entity("AGV.Models.Servico", b =>
                {
                    b.Navigation("UsuariosServico");
                });
#pragma warning restore 612, 618
        }
    }
}
