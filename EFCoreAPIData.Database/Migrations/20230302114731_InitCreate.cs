using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAPIData.Database.Migrations
{
    /// <inheritdoc />
    public partial class InitCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Market",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Market", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Markets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExchangeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseAsset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuoteAsset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceUnconverted = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Change24H = table.Column<double>(type: "float", nullable: false),
                    Spread = table.Column<double>(type: "float", nullable: false),
                    Volume24H = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    MarketViewModelFK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Markets_Market_MarketViewModelFK",
                        column: x => x.MarketViewModelFK,
                        principalTable: "Market",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quote",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarketFK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quote_Markets_MarketFK",
                        column: x => x.MarketFK,
                        principalTable: "Markets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AUD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Volume24H = table.Column<double>(type: "float", nullable: false),
                    QuoteFK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AUD_Quote_QuoteFK",
                        column: x => x.QuoteFK,
                        principalTable: "Quote",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CAD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Volume24H = table.Column<double>(type: "float", nullable: false),
                    QuoteFK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CAD_Quote_QuoteFK",
                        column: x => x.QuoteFK,
                        principalTable: "Quote",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GBP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Volume24H = table.Column<double>(type: "float", nullable: false),
                    QuoteFK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GBP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GBP_Quote_QuoteFK",
                        column: x => x.QuoteFK,
                        principalTable: "Quote",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JPY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Volume24H = table.Column<double>(type: "float", nullable: false),
                    QuoteFK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JPY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JPY_Quote_QuoteFK",
                        column: x => x.QuoteFK,
                        principalTable: "Quote",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NZD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Volume24H = table.Column<double>(type: "float", nullable: false),
                    QuoteFK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NZD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NZD_Quote_QuoteFK",
                        column: x => x.QuoteFK,
                        principalTable: "Quote",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "USD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Volume24H = table.Column<double>(type: "float", nullable: false),
                    QuoteFK = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_USD_Quote_QuoteFK",
                        column: x => x.QuoteFK,
                        principalTable: "Quote",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AUD_QuoteFK",
                table: "AUD",
                column: "QuoteFK",
                unique: true,
                filter: "[QuoteFK] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_QuoteFK",
                table: "CAD",
                column: "QuoteFK",
                unique: true,
                filter: "[QuoteFK] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GBP_QuoteFK",
                table: "GBP",
                column: "QuoteFK",
                unique: true,
                filter: "[QuoteFK] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_JPY_QuoteFK",
                table: "JPY",
                column: "QuoteFK",
                unique: true,
                filter: "[QuoteFK] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Markets_MarketViewModelFK",
                table: "Markets",
                column: "MarketViewModelFK");

            migrationBuilder.CreateIndex(
                name: "IX_NZD_QuoteFK",
                table: "NZD",
                column: "QuoteFK",
                unique: true,
                filter: "[QuoteFK] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Quote_MarketFK",
                table: "Quote",
                column: "MarketFK",
                unique: true,
                filter: "[MarketFK] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_USD_QuoteFK",
                table: "USD",
                column: "QuoteFK",
                unique: true,
                filter: "[QuoteFK] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AUD");

            migrationBuilder.DropTable(
                name: "CAD");

            migrationBuilder.DropTable(
                name: "GBP");

            migrationBuilder.DropTable(
                name: "JPY");

            migrationBuilder.DropTable(
                name: "NZD");

            migrationBuilder.DropTable(
                name: "USD");

            migrationBuilder.DropTable(
                name: "Quote");

            migrationBuilder.DropTable(
                name: "Markets");

            migrationBuilder.DropTable(
                name: "Market");
        }
    }
}
