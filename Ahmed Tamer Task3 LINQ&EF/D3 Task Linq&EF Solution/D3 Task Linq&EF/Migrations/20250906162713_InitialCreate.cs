using Microsoft.EntityFrameworkCore.Migrations;

namespace D3_Task_Linq_EF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 10"),
                    ProName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, defaultValue: "OurProject"),
                    Cost = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.CheckConstraint("CK_Project_Cost_Range", "[Cost] >= 500000 AND [Cost] <= 3500000");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
