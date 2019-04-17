using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MasterChef.Api.Migrations
{
    public partial class removendorequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Recipes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Recipes",
                nullable: false,
                defaultValue: new byte[] {  });
        }
    }
}
