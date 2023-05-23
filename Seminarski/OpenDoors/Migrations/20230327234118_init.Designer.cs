﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenDoors.Data;

#nullable disable

namespace OpenDoors.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230327234118_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OpenDoors.Models.AutentifikacijaToken", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<string>("ipAdresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vrijednost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijemeEvidentiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("AutentifikacijaToken");
                });

            modelBuilder.Entity("OpenDoors.Models.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<string>("Predmet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sadrzaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("Email");
                });

            modelBuilder.Entity("OpenDoors.Models.Grad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostanskiBroj")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("OpenDoors.Models.KorisnickiNalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Verifikovan")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("KorisnickiNalog");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("OpenDoors.Models.KrajnjiKorisnikPromoKodovi", b =>
                {
                    b.Property<int>("KrajnjiKorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("PromoKodoviId")
                        .HasColumnType("int");

                    b.HasKey("KrajnjiKorisnikId", "PromoKodoviId");

                    b.HasIndex("PromoKodoviId");

                    b.ToTable("KrajnjiKorisnikPromoKodovi");
                });

            modelBuilder.Entity("OpenDoors.Models.KreditnaKartica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BrojKartice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CVV")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipKartice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datumIsteka")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.ToTable("KreditnaKartica");
                });

            modelBuilder.Entity("OpenDoors.Models.LogKretanjePoSistemu", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("exceptionMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ipAdresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isException")
                        .HasColumnType("bit");

                    b.Property<int>("korisnikID")
                        .HasColumnType("int");

                    b.Property<string>("postData")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("queryPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijeme")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("korisnikID");

                    b.ToTable("LogKretanjePoSistemu");
                });

            modelBuilder.Entity("OpenDoors.Models.Lokacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DioGrada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GradId");

                    b.ToTable("Lokacija");
                });

            modelBuilder.Entity("OpenDoors.Models.Nekretnina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Avans")
                        .HasColumnType("bit");

                    b.Property<int>("BrojKreveta")
                        .HasColumnType("int");

                    b.Property<int>("BrojKupatila")
                        .HasColumnType("int");

                    b.Property<int>("BrojKvadrata")
                        .HasColumnType("int");

                    b.Property<int>("BrojSoba")
                        .HasColumnType("int");

                    b.Property<double>("CijenaPoDanu")
                        .HasColumnType("float");

                    b.Property<DateTime>("DatumIzmjene")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPostavljanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("LokacijaId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("TipId")
                        .HasColumnType("int");

                    b.Property<int>("VlasnikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LokacijaId");

                    b.HasIndex("TipId");

                    b.HasIndex("VlasnikId");

                    b.ToTable("Nekretnina");
                });

            modelBuilder.Entity("OpenDoors.Models.NekretninaPogodnostiNekretnine", b =>
                {
                    b.Property<int>("NekretninaId")
                        .HasColumnType("int");

                    b.Property<int>("PogodnostiNekretnineId")
                        .HasColumnType("int");

                    b.HasKey("NekretninaId", "PogodnostiNekretnineId");

                    b.HasIndex("PogodnostiNekretnineId");

                    b.ToTable("NekretninaPogodnostiNekretnine");
                });

            modelBuilder.Entity("OpenDoors.Models.Notifikacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<int>("RezervacijaId")
                        .HasColumnType("int");

                    b.Property<string>("Sadrzaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("KorisnickiNalogId");

                    b.HasIndex("RezervacijaId");

                    b.ToTable("Notifikacija");
                });

            modelBuilder.Entity("OpenDoors.Models.PogodnostiNekretnine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PogodnostiNekretnine");
                });

            modelBuilder.Entity("OpenDoors.Models.PosebnaPonuda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DatumIsteka")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPocetka")
                        .HasColumnType("datetime2");

                    b.Property<int>("NekretninaId")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Popust")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NekretninaId");

                    b.ToTable("PosebnaPonuda");
                });

            modelBuilder.Entity("OpenDoors.Models.PromoKodovi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Kod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Popust")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Validan")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("PromoKodovi");
                });

            modelBuilder.Entity("OpenDoors.Models.Recenzije", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DatumModifikacije")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPostavljanja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Komentar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<int>("NekretninaId")
                        .HasColumnType("int");

                    b.Property<int>("Ocjena")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KorisnickiNalogId");

                    b.HasIndex("NekretninaId");

                    b.ToTable("Recenzije");
                });

            modelBuilder.Entity("OpenDoors.Models.Rezervacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrojOsoba")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<DateTime?>("DatumOtkazivanja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumRezervacije")
                        .HasColumnType("datetime2");

                    b.Property<int>("Djeca")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("KreditnaKarticaId")
                        .HasColumnType("int");

                    b.Property<int>("NekretninaId")
                        .HasColumnType("int");

                    b.Property<bool>("PovratNovca")
                        .HasColumnType("bit");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("KreditnaKarticaId");

                    b.HasIndex("NekretninaId");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("OpenDoors.Models.Slike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DatumPostavljanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("NekretninaId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Slika")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("NekretninaId");

                    b.ToTable("Slike");
                });

            modelBuilder.Entity("OpenDoors.Models.TipNekretnine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipNekretnine");
                });

            modelBuilder.Entity("OpenDoors.Models.Transakcija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Iznos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("KreditnaKarticaId")
                        .HasColumnType("int");

                    b.Property<string>("NacinPlacanja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NekretninaId")
                        .HasColumnType("int");

                    b.Property<string>("Popust")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RezervacijaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("KreditnaKarticaId");

                    b.HasIndex("NekretninaId");

                    b.HasIndex("RezervacijaId");

                    b.ToTable("Transakcija");
                });

            modelBuilder.Entity("OpenDoors.Models.Korisnik", b =>
                {
                    b.HasBaseType("OpenDoors.Models.KorisnickiNalog");

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GodinaRodjenja")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("slikaKorisnika")
                        .HasColumnType("varbinary(max)");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("OpenDoors.Models.KrajnjiKorisnik", b =>
                {
                    b.HasBaseType("OpenDoors.Models.Korisnik");

                    b.Property<int?>("BrojOtkazanihRezervacija")
                        .HasColumnType("int");

                    b.Property<int?>("BrojRezervacija")
                        .HasColumnType("int");

                    b.Property<bool?>("Registrovan")
                        .HasColumnType("bit");

                    b.Property<string>("Titula")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("KrajnjiKorisnik");
                });

            modelBuilder.Entity("OpenDoors.Models.Vlasnik", b =>
                {
                    b.HasBaseType("OpenDoors.Models.Korisnik");

                    b.Property<int?>("BrojNekretnina")
                        .HasColumnType("int");

                    b.Property<DateTime?>("IznajmljivateljOd")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titula")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Vlasnik");
                });

            modelBuilder.Entity("OpenDoors.Models.AutentifikacijaToken", b =>
                {
                    b.HasOne("OpenDoors.Models.KorisnickiNalog", "korisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnickiNalog");
                });

            modelBuilder.Entity("OpenDoors.Models.Email", b =>
                {
                    b.HasOne("OpenDoors.Models.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KorisnickiNalog");
                });

            modelBuilder.Entity("OpenDoors.Models.KrajnjiKorisnikPromoKodovi", b =>
                {
                    b.HasOne("OpenDoors.Models.KrajnjiKorisnik", "KrajnjiKorisnik")
                        .WithMany()
                        .HasForeignKey("KrajnjiKorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpenDoors.Models.PromoKodovi", "PromoKodovi")
                        .WithMany()
                        .HasForeignKey("PromoKodoviId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KrajnjiKorisnik");

                    b.Navigation("PromoKodovi");
                });

            modelBuilder.Entity("OpenDoors.Models.KreditnaKartica", b =>
                {
                    b.HasOne("OpenDoors.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("OpenDoors.Models.LogKretanjePoSistemu", b =>
                {
                    b.HasOne("OpenDoors.Models.KorisnickiNalog", "korisnik")
                        .WithMany()
                        .HasForeignKey("korisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnik");
                });

            modelBuilder.Entity("OpenDoors.Models.Lokacija", b =>
                {
                    b.HasOne("OpenDoors.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("OpenDoors.Models.Nekretnina", b =>
                {
                    b.HasOne("OpenDoors.Models.Lokacija", "Lokacija")
                        .WithMany()
                        .HasForeignKey("LokacijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpenDoors.Models.TipNekretnine", "Tip")
                        .WithMany()
                        .HasForeignKey("TipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpenDoors.Models.Vlasnik", "Vlasnik")
                        .WithMany()
                        .HasForeignKey("VlasnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lokacija");

                    b.Navigation("Tip");

                    b.Navigation("Vlasnik");
                });

            modelBuilder.Entity("OpenDoors.Models.NekretninaPogodnostiNekretnine", b =>
                {
                    b.HasOne("OpenDoors.Models.Nekretnina", "Nekretnina")
                        .WithMany()
                        .HasForeignKey("NekretninaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpenDoors.Models.PogodnostiNekretnine", "PogodnostiNekretnine")
                        .WithMany()
                        .HasForeignKey("PogodnostiNekretnineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nekretnina");

                    b.Navigation("PogodnostiNekretnine");
                });

            modelBuilder.Entity("OpenDoors.Models.Notifikacija", b =>
                {
                    b.HasOne("OpenDoors.Models.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpenDoors.Models.Rezervacija", "Rezervacija")
                        .WithMany()
                        .HasForeignKey("RezervacijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KorisnickiNalog");

                    b.Navigation("Rezervacija");
                });

            modelBuilder.Entity("OpenDoors.Models.PosebnaPonuda", b =>
                {
                    b.HasOne("OpenDoors.Models.Nekretnina", "Nekretnina")
                        .WithMany()
                        .HasForeignKey("NekretninaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nekretnina");
                });

            modelBuilder.Entity("OpenDoors.Models.Recenzije", b =>
                {
                    b.HasOne("OpenDoors.Models.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpenDoors.Models.Nekretnina", "Nekretnina")
                        .WithMany()
                        .HasForeignKey("NekretninaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KorisnickiNalog");

                    b.Navigation("Nekretnina");
                });

            modelBuilder.Entity("OpenDoors.Models.Rezervacija", b =>
                {
                    b.HasOne("OpenDoors.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpenDoors.Models.KreditnaKartica", "KreditnaKartica")
                        .WithMany()
                        .HasForeignKey("KreditnaKarticaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpenDoors.Models.Nekretnina", "Nekretnina")
                        .WithMany()
                        .HasForeignKey("NekretninaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("KreditnaKartica");

                    b.Navigation("Nekretnina");
                });

            modelBuilder.Entity("OpenDoors.Models.Slike", b =>
                {
                    b.HasOne("OpenDoors.Models.Nekretnina", "Nekretnina")
                        .WithMany()
                        .HasForeignKey("NekretninaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nekretnina");
                });

            modelBuilder.Entity("OpenDoors.Models.Transakcija", b =>
                {
                    b.HasOne("OpenDoors.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpenDoors.Models.KreditnaKartica", "KreditnaKartica")
                        .WithMany()
                        .HasForeignKey("KreditnaKarticaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpenDoors.Models.Nekretnina", "Nekretnina")
                        .WithMany()
                        .HasForeignKey("NekretninaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OpenDoors.Models.Rezervacija", "Rezervacija")
                        .WithMany()
                        .HasForeignKey("RezervacijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("KreditnaKartica");

                    b.Navigation("Nekretnina");

                    b.Navigation("Rezervacija");
                });

            modelBuilder.Entity("OpenDoors.Models.Korisnik", b =>
                {
                    b.HasOne("OpenDoors.Models.KorisnickiNalog", null)
                        .WithOne()
                        .HasForeignKey("OpenDoors.Models.Korisnik", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OpenDoors.Models.KrajnjiKorisnik", b =>
                {
                    b.HasOne("OpenDoors.Models.Korisnik", null)
                        .WithOne()
                        .HasForeignKey("OpenDoors.Models.KrajnjiKorisnik", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OpenDoors.Models.Vlasnik", b =>
                {
                    b.HasOne("OpenDoors.Models.Korisnik", null)
                        .WithOne()
                        .HasForeignKey("OpenDoors.Models.Vlasnik", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
