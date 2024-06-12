﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Speciality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speciality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    SpecialityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainer_Speciality_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Speciality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Speciality",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Perte de poids" },
                    { 2, "Course" },
                    { 3, "Halthérophilie" },
                    { 4, "Réhabilitation" }
                });

            migrationBuilder.InsertData(
                table: "Trainer",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Photo", "SpecialityId" },
                values: new object[,]
                {
                    { 1, "Chrystal.lapierre@juliepro.ca", "Chrystal", "Lapierre", "Chrystal.png", 1 },
                    { 2, "Felix.trudeau@juliePro.ca", "Félix", "Trudeau", "Felix.png", 2 },
                    { 3, "Frank.StJohn@juliepro.ca", "François", "Saint-John", "Francois.png", 1 },
                    { 4, "JC.Bastien@juliepro.ca", "Jean-Claude", "Bastien", "JeanClaude.png", 4 },
                    { 5, "JinLee.godette@juliepro.ca", "Jin Lee", "Godette", "Jin Lee.png", 3 },
                    { 6, "Karine.Lachance@juliepro.ca", "Karine", "Lachance", "Karine.png", 2 },
                    { 7, "Ramone.Esteban@juliepro.ca", "Ramone", "Esteban", "Ramone.png", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trainer_SpecialityId",
                table: "Trainer",
                column: "SpecialityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trainer");

            migrationBuilder.DropTable(
                name: "Speciality");
        }
    }
}
