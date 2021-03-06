// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test.Data;

namespace Test.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210309215334_appcontext1")]
    partial class appcontext1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Test.Data.Entities.CertificateUploads", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("BscCertFileName")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("BscCertFileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ProfessionalCertFileName")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ProfessionalCertFileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("WaecCertFileName")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("WaecCertFileType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("certificateUploads");
                });

            modelBuilder.Entity("Test.Data.Entities.PersonalDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CVFileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("CVFiles")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ContactAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("personalDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
