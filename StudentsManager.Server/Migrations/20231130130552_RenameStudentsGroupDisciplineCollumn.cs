using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsManager.Server.Migrations
{
    /// <inheritdoc />
    public partial class RenameStudentsGroupDisciplineCollumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "StudentsGroupDisciplines");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GroupId",
                table: "StudentsGroupDisciplines",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
