using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevExpressReporting.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdcCoreSummary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GlCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Op_Bal_A = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cl_Bal_B = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Trans_Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    debit_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    credit_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Diff_in_Open_Cls_Bal_A = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sum_of_Db_Cr_Summation_B = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Differnce_A_B = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdcCoreSummary", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdcCoreSummary");
        }
    }
}
