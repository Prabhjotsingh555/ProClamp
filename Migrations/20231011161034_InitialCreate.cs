using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProClamp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clamp",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    WeightInLB = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    JawOpeningInInches = table.Column<decimal>(nullable: false),
                    Application = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clamp", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clamp");
        }
    }
}
