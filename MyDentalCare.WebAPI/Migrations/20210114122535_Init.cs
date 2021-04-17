using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDentalCare.WebAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dijagnoza",
                columns: table => new
                {
                    DijagnozaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dijagnoza", x => x.DijagnozaId);
                });

            migrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    KategorijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.KategorijaId);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: false),
                    Prezime = table.Column<string>(nullable: false),
                    DatumRodjenja = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    BrojTelefona = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikId);
                });

            migrationBuilder.CreateTable(
                name: "Lijek",
                columns: table => new
                {
                    LijekId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: false),
                    Uputstvo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lijek", x => x.LijekId);
                });

            migrationBuilder.CreateTable(
                name: "Pacijent",
                columns: table => new
                {
                    PacijentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumRegistracije = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ime = table.Column<string>(nullable: false),
                    Prezime = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    BrojTelefona = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacijent", x => x.PacijentId);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    UlogaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "Usluga",
                columns: table => new
                {
                    UslugaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usluga", x => x.UslugaId);
                });

            migrationBuilder.CreateTable(
                name: "Clanak",
                columns: table => new
                {
                    ClanakId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(nullable: false),
                    Sadrzaj = table.Column<string>(nullable: false),
                    DatumObjave = table.Column<DateTime>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    KategorijaId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clanak", x => x.ClanakId);
                    table.ForeignKey(
                        name: "FK_Clanak_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorija",
                        principalColumn: "KategorijaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clanak_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicinskiKarton",
                columns: table => new
                {
                    MedicinskiKartonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    DatumVrijeme = table.Column<DateTime>(nullable: false),
                    PacijentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicinskiKarton", x => x.MedicinskiKartonId);
                    table.ForeignKey(
                        name: "FK_MedicinskiKarton_PacijentId",
                        column: x => x.PacijentId,
                        principalTable: "Pacijent",
                        principalColumn: "PacijentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikUloga",
                columns: table => new
                {
                    KorisnikUlogaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime", nullable: true),
                    KorisnikId = table.Column<int>(nullable: false),
                    UlogaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikUloga", x => x.KorisnikUlogaId);
                    table.ForeignKey(
                        name: "FK_KorisnikUloga_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KorisnikUloga_UlogaId",
                        column: x => x.UlogaId,
                        principalTable: "Uloga",
                        principalColumn: "UlogaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    RezervacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumVrijeme = table.Column<DateTime>(nullable: false),
                    Razlog = table.Column<string>(nullable: false),
                    PacijentId = table.Column<int>(nullable: false),
                    UslugaId = table.Column<int>(nullable: false),
                    Aktivna = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.RezervacijaId);
                    table.ForeignKey(
                        name: "FK_Rezervacija_PacijentId",
                        column: x => x.PacijentId,
                        principalTable: "Pacijent",
                        principalColumn: "PacijentId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Rezervacija_UslugaId",
                        column: x => x.UslugaId,
                        principalTable: "Usluga",
                        principalColumn: "UslugaId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Ocjena",
                columns: table => new
                {
                    OcjenaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ocjena = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    PacijentId = table.Column<int>(nullable: false),
                    ClanakId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjena", x => x.OcjenaId);
                    table.ForeignKey(
                        name: "FK_Ocjena_ClanakId",
                        column: x => x.ClanakId,
                        principalTable: "Clanak",
                        principalColumn: "ClanakId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ocjena_PacijentId",
                        column: x => x.PacijentId,
                        principalTable: "Pacijent",
                        principalColumn: "PacijentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pregled",
                columns: table => new
                {
                    PregledId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumVrijeme = table.Column<DateTime>(nullable: false),
                    Naziv = table.Column<string>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    DijagnozaId = table.Column<int>(nullable: false),
                    LijekId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    RezervacijaId = table.Column<int>(nullable: false),
                    MedicinskiKartonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pregled", x => x.PregledId);
                    table.ForeignKey(
                        name: "FK_Pregled_DijagnozaId",
                        column: x => x.DijagnozaId,
                        principalTable: "Dijagnoza",
                        principalColumn: "DijagnozaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pregled_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pregled_LijekId",
                        column: x => x.LijekId,
                        principalTable: "Lijek",
                        principalColumn: "LijekId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pregled_MedicinskiKartonId",
                        column: x => x.MedicinskiKartonId,
                        principalTable: "MedicinskiKarton",
                        principalColumn: "MedicinskiKartonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pregled_RezervacijaId",
                        column: x => x.RezervacijaId,
                        principalTable: "Rezervacija",
                        principalColumn: "RezervacijaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clanak_KategorijaId",
                table: "Clanak",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clanak_KorisnikId",
                table: "Clanak",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloga_KorisnikId",
                table: "KorisnikUloga",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloga_UlogaId",
                table: "KorisnikUloga",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicinskiKarton_PacijentId",
                table: "MedicinskiKarton",
                column: "PacijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjena_ClanakId",
                table: "Ocjena",
                column: "ClanakId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjena_PacijentId",
                table: "Ocjena",
                column: "PacijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Pregled_DijagnozaId",
                table: "Pregled",
                column: "DijagnozaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pregled_KorisnikId",
                table: "Pregled",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Pregled_LijekId",
                table: "Pregled",
                column: "LijekId");

            migrationBuilder.CreateIndex(
                name: "IX_Pregled_MedicinskiKartonId",
                table: "Pregled",
                column: "MedicinskiKartonId");

            migrationBuilder.CreateIndex(
                name: "IX_Pregled_RezervacijaId",
                table: "Pregled",
                column: "RezervacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_PacijentId",
                table: "Rezervacija",
                column: "PacijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_UslugaId",
                table: "Rezervacija",
                column: "UslugaId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisnikUloga");

            migrationBuilder.DropTable(
                name: "Ocjena");

            migrationBuilder.DropTable(
                name: "Pregled");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropTable(
                name: "Clanak");

            migrationBuilder.DropTable(
                name: "Dijagnoza");

            migrationBuilder.DropTable(
                name: "Lijek");

            migrationBuilder.DropTable(
                name: "MedicinskiKarton");

            migrationBuilder.DropTable(
                name: "Rezervacija");

            migrationBuilder.DropTable(
                name: "Kategorija");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Pacijent");

            migrationBuilder.DropTable(
                name: "Usluga");
        }
    }
}
