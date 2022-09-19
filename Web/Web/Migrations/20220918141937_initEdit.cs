using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Web.Migrations
{
    public partial class initEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Couples_Groups_GroupId",
                table: "Couples");

            migrationBuilder.DropIndex(
                name: "IX_Couples_GroupId",
                table: "Couples");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Couples");

            migrationBuilder.DropColumn(
                name: "WeekDay",
                table: "Couples");

            migrationBuilder.RenameColumn(
                name: "WeekType",
                table: "Couples",
                newName: "WeekDayId");

            migrationBuilder.AddColumn<int>(
                name: "CoupleId",
                table: "Groups",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeekId",
                table: "Couples",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Week",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Week", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeekDay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    WeekId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekDay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeekDay_Week_WeekId",
                        column: x => x.WeekId,
                        principalTable: "Week",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_CoupleId",
                table: "Groups",
                column: "CoupleId");

            migrationBuilder.CreateIndex(
                name: "IX_Couples_WeekDayId",
                table: "Couples",
                column: "WeekDayId");

            migrationBuilder.CreateIndex(
                name: "IX_Couples_WeekId",
                table: "Couples",
                column: "WeekId");

            migrationBuilder.CreateIndex(
                name: "IX_WeekDay_WeekId",
                table: "WeekDay",
                column: "WeekId");

            migrationBuilder.AddForeignKey(
                name: "FK_Couples_Week_WeekId",
                table: "Couples",
                column: "WeekId",
                principalTable: "Week",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Couples_WeekDay_WeekDayId",
                table: "Couples",
                column: "WeekDayId",
                principalTable: "WeekDay",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Couples_CoupleId",
                table: "Groups",
                column: "CoupleId",
                principalTable: "Couples",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Couples_Week_WeekId",
                table: "Couples");

            migrationBuilder.DropForeignKey(
                name: "FK_Couples_WeekDay_WeekDayId",
                table: "Couples");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Couples_CoupleId",
                table: "Groups");

            migrationBuilder.DropTable(
                name: "WeekDay");

            migrationBuilder.DropTable(
                name: "Week");

            migrationBuilder.DropIndex(
                name: "IX_Groups_CoupleId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Couples_WeekDayId",
                table: "Couples");

            migrationBuilder.DropIndex(
                name: "IX_Couples_WeekId",
                table: "Couples");

            migrationBuilder.DropColumn(
                name: "CoupleId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "WeekId",
                table: "Couples");

            migrationBuilder.RenameColumn(
                name: "WeekDayId",
                table: "Couples",
                newName: "WeekType");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Couples",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeekDay",
                table: "Couples",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Couples_GroupId",
                table: "Couples",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Couples_Groups_GroupId",
                table: "Couples",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
