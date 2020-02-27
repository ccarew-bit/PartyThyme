using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PartyThyme.Migrations
{
    public partial class AddedPlantClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "plants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Species = table.Column<string>(nullable: true),
                    PlantDate = table.Column<DateTime>(nullable: false),
                    LocatedPlanted = table.Column<string>(nullable: true),
                    LastWateredDate = table.Column<DateTime>(nullable: false),
                    LightNeeded = table.Column<string>(nullable: true),
                    WaterNeeded = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plants", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "plants");
        }
    }
}
