﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using practica3.Context;

#nullable disable

namespace practica3.Migrations
{
    [DbContext(typeof(LibroContext))]
    partial class LibroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("practica3.Models.EDITORIAL", b =>
                {
                    b.Property<int>("IDEditorial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDEditorial"));

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Editorial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_del_contacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDEditorial");

                    b.ToTable("EDITORIAL");
                });

            modelBuilder.Entity("practica3.Models.INVENTARIO", b =>
                {
                    b.Property<int>("IDinventario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDinventario"));

                    b.Property<int>("Existencia")
                        .HasColumnType("int");

                    b.Property<int>("IDLibro")
                        .HasColumnType("int");

                    b.Property<int>("IDSucursal")
                        .HasColumnType("int");

                    b.HasKey("IDinventario");

                    b.ToTable("INVENTARIO");
                });

            modelBuilder.Entity("practica3.Models.LIBRO", b =>
                {
                    b.Property<int>("IDLibro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDLibro"));

                    b.Property<string>("AUTOR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Año")
                        .HasColumnType("int");

                    b.Property<string>("COMENTARIOS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FOTO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDEditorial")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PRECIO")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TITULO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDLibro");

                    b.ToTable("LIBRO");
                });

            modelBuilder.Entity("practica3.Models.SUCURSAL", b =>
                {
                    b.Property<int>("IDSucursal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDSucursal"));

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_del_encargado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sucursal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDSucursal");

                    b.ToTable("SUCURSAL");
                });
#pragma warning restore 612, 618
        }
    }
}
