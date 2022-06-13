using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebContactsRedo.Data.Migrations
{
    public partial class secondstep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Brand",
                table: "ContactForm",
                newName: "brand");

            migrationBuilder.RenameColumn(
                name: "Axis",
                table: "ContactForm",
                newName: "axis");

            migrationBuilder.AddColumn<double>(
                name: "Axis",
                table: "ContactForm",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BC",
                table: "ContactForm",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "ContactForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cyl",
                table: "ContactForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Diameter",
                table: "ContactForm",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Multifocal",
                table: "ContactForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sph",
                table: "ContactForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "SelectListItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectListItem", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SelectListItem");

            migrationBuilder.DropColumn(
                name: "Axis",
                table: "ContactForm");

            migrationBuilder.DropColumn(
                name: "BC",
                table: "ContactForm");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "ContactForm");

            migrationBuilder.DropColumn(
                name: "Cyl",
                table: "ContactForm");

            migrationBuilder.DropColumn(
                name: "Diameter",
                table: "ContactForm");

            migrationBuilder.DropColumn(
                name: "Multifocal",
                table: "ContactForm");

            migrationBuilder.DropColumn(
                name: "Sph",
                table: "ContactForm");

            migrationBuilder.RenameColumn(
                name: "brand",
                table: "ContactForm",
                newName: "Brand");

            migrationBuilder.RenameColumn(
                name: "axis",
                table: "ContactForm",
                newName: "Axis");
        }
    }
}
