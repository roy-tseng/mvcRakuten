using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mvcRakuten.Migrations
{
    public partial class mi_2nd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "property",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: false),
                    enabled = table.Column<bool>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    eid = table.Column<string>(nullable: false),
                    detail = table.Column<string>(nullable: true),
                    owner = table.Column<string>(nullable: false),
                    barcode = table.Column<string>(nullable: true),
                    price = table.Column<double>(nullable: false),
                    location = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_property", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "property");
        }
    }
}
