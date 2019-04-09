using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnetcore_learning.Migrations
{
    public partial class bittu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_paymentDetails",
                table: "paymentDetails");

            migrationBuilder.RenameTable(
                name: "paymentDetails",
                newName: "PaymentDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentDetails",
                table: "PaymentDetails",
                column: "paymentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentDetails",
                table: "PaymentDetails");

            migrationBuilder.RenameTable(
                name: "PaymentDetails",
                newName: "paymentDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_paymentDetails",
                table: "paymentDetails",
                column: "paymentId");
        }
    }
}
