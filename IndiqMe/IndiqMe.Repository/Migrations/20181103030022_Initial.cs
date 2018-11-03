using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace IndiqMe.Repository.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    EntityId = table.Column<Guid>(nullable: false),
                    EntityName = table.Column<string>(nullable: true),
                    LogDateTime = table.Column<DateTime>(nullable: false),
                    Operation = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true),
                    ValuesChanges = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogEntries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Linkedin = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PasswordSalt = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Profile = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    City = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Complement = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Country = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    Neighborhood = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Number = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    PostalCode = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    State = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Street = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "LogEntries");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
