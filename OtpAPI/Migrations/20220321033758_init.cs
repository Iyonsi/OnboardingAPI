﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace OtpAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OtpUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtpUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Otps",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    OtpCode = table.Column<string>(type: "TEXT", nullable: true),
                    OtpUserId = table.Column<string>(type: "TEXT", nullable: true),
                    OtpCounter = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Otps_OtpUsers_OtpUserId",
                        column: x => x.OtpUserId,
                        principalTable: "OtpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Otps_OtpUserId",
                table: "Otps",
                column: "OtpUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Otps");

            migrationBuilder.DropTable(
                name: "OtpUsers");
        }
    }
}
