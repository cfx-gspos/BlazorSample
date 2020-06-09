using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class CustomerAndCustomerHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CustomerHistories",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YearlyManDayCost = table.Column<double>(type: "float", nullable: false),
                    YearlyManDayDiscountedCost = table.Column<double>(type: "float", nullable: false),
                    CustomerID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerHistories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipTo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "CustomerHistories",
                columns: new[] { "ID", "CreatedAt", "CreatedBy", "CustomerID", "EndDate", "IsDeleted", "StartDate", "UpdatedAt", "UpdatedBy", "YearlyManDayCost", "YearlyManDayDiscountedCost" },
                values: new object[] { "50338fa3-d692-4e96-ad6e-59bb96e804a2", new DateTime(2020, 6, 9, 9, 35, 10, 282, DateTimeKind.Local).AddTicks(8585), "Frank", "20ed8b2c-cdea-41e2-a9b4-b96cfe252192", new DateTime(2021, 6, 9, 9, 35, 10, 283, DateTimeKind.Local).AddTicks(8112), false, new DateTime(2020, 6, 9, 9, 35, 10, 283, DateTimeKind.Local).AddTicks(2793), new DateTime(2020, 6, 9, 9, 35, 10, 284, DateTimeKind.Local).AddTicks(865), "", 4565.0, 4560.0 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "ShipTo", "To", "UpdatedAt", "UpdatedBy" },
                values: new object[] { "20ed8b2c-cdea-41e2-a9b4-b96cfe252192", new DateTime(2020, 6, 9, 9, 35, 10, 278, DateTimeKind.Local).AddTicks(303), "", false, "IHP", "Wan Zai", "Ivan Wan Zai", new DateTime(2020, 6, 9, 9, 35, 10, 279, DateTimeKind.Local).AddTicks(9973), "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerHistories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
