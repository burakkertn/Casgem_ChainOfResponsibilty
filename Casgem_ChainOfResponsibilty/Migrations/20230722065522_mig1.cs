using Microsoft.EntityFrameworkCore.Migrations;

namespace Casgem_ChainOfResponsibilty.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerProcesses",
                columns: table => new
                {
                    CustomerProcessID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: true),
                    Amount = table.Column<string>(nullable: true),
                    EmployeeName = table.Column<string>(nullable: true),
                    Des = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProcesses", x => x.CustomerProcessID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerProcesses");
        }
    }
}
