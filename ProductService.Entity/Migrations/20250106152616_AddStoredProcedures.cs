using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductService.Entity.Migrations
{
    /// <inheritdoc />
    public partial class AddStoredProcedures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //// Path to the procedures folder
            //var proceduresFolder = Path.Combine(AppContext.BaseDirectory, "Procedures");

            //// Loop through each SQL file in the folder
            //foreach (var filePath in Directory.GetFiles(proceduresFolder, "*.sql"))
            //{
            //    var sql = File.ReadAllText(filePath);
            //    migrationBuilder.Sql(sql);
            //}
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //// Optional: Drop the stored procedures if needed
            //// Add SQL commands to drop each procedure if they are no longer required
            //migrationBuilder.Sql("DROP PROCEDURE IF EXISTS ProcedureName;");
        }
    }
}
