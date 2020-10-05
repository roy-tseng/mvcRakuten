using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mvcRakuten.Migrations
{
    public partial class mi1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gender",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: false),
                    enabled = table.Column<bool>(nullable: false),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gender", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "member",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    create_time = table.Column<DateTime>(nullable: false),
                    update_time = table.Column<DateTime>(nullable: false),
                    enabled = table.Column<bool>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    pid = table.Column<string>(nullable: false),
                    address = table.Column<string>(nullable: false),
                    mobile = table.Column<string>(nullable: false),
                    home = table.Column<string>(nullable: true),
                    birthday = table.Column<DateTime>(nullable: false),
                    gender = table.Column<int>(nullable: false),
                    id_code = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_member", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gender");

            migrationBuilder.DropTable(
                name: "member");
        }
    }
}
