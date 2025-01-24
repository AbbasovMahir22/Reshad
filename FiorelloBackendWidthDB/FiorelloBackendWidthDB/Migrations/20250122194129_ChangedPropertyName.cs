using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiorelloBackendWidthDB.Migrations
{
    /// <inheritdoc />
    public partial class ChangedPropertyName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatDate",
                table: "Blogs",
                newName: "CreateDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Blogs",
                newName: "CreatDate");
        }
    }
}
