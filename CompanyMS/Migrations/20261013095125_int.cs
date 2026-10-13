using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyMS.Migrations
{
    /// <inheritdoc />
    public partial class @int : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmetId",
                        column: x => x.DepartmetId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Budget = table.Column<double>(type: "float", nullable: false),
                    DepartmetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Departments_DepartmetId",
                        column: x => x.DepartmetId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    AssignedRole = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AssignedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "New York", "Human Resources" },
                    { 2, "San Francisco", "IT" },
                    { 3, "Chicago", "Finance" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmetId", "Email", "HireDate", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, 1, "JO3H_K@gmail.com", new DateTime(2026, 10, 13, 12, 51, 24, 34, DateTimeKind.Local).AddTicks(767), "John Doe", 5000.0 },
                    { 2, 2, "J223@mail.com", new DateTime(2026, 10, 13, 12, 51, 24, 34, DateTimeKind.Local).AddTicks(853), "Jane Smith", 6000.0 },
                    { 3, 3, "btroi@gmail.com", new DateTime(2026, 10, 13, 12, 51, 24, 34, DateTimeKind.Local).AddTicks(859), "Bob Johnson", 7000.0 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Budget", "DepartmetId", "Description", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, 10000.0, 1, "Description for Project A", "Project A", new DateTime(2026, 10, 13, 12, 51, 24, 34, DateTimeKind.Local).AddTicks(930) },
                    { 2, 20000.0, 2, "Description for Project B", "Project B", new DateTime(2026, 10, 13, 12, 51, 24, 34, DateTimeKind.Local).AddTicks(940) },
                    { 3, 30000.0, 3, "Description for Project C", "Project C", new DateTime(2026, 10, 13, 12, 51, 24, 34, DateTimeKind.Local).AddTicks(946) }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProjects",
                columns: new[] { "Id", "AssignedDate", "AssignedRole", "EmployeeId", "ProjectId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 10, 13, 12, 51, 24, 34, DateTimeKind.Local).AddTicks(995), "Developer", 1, 1 },
                    { 2, new DateTime(2026, 10, 13, 12, 51, 24, 34, DateTimeKind.Local).AddTicks(1003), "Tester", 2, 2 },
                    { 3, new DateTime(2026, 10, 13, 12, 51, 24, 34, DateTimeKind.Local).AddTicks(1009), "Manager", 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_EmployeeId",
                table: "EmployeeProjects",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_ProjectId",
                table: "EmployeeProjects",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmetId",
                table: "Employees",
                column: "DepartmetId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DepartmetId",
                table: "Projects",
                column: "DepartmetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProjects");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
