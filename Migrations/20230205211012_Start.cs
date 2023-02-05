using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LotteryAPI.Migrations
{
    /// <inheritdoc />
    public partial class Start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Route = table.Column<string>(type: "TEXT", nullable: false),
                    StartNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    EndNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    AmountOfDrawnNumbers = table.Column<int>(type: "INTEGER", nullable: false),
                    AmountOfNumbersToBet = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BetConfigs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    GameRouteId = table.Column<Guid>(type: "TEXT", nullable: false),
                    AmountOfNumbers = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BetConfigs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BetConfigs_Routes_GameRouteId",
                        column: x => x.GameRouteId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    GameNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    ResultDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SpecialGame = table.Column<int>(type: "INTEGER", nullable: false),
                    GameRouteId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Amount = table.Column<float>(type: "REAL", nullable: false),
                    HasWinner = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Routes_GameRouteId",
                        column: x => x.GameRouteId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConfigId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bets_BetConfigs_ConfigId",
                        column: x => x.ConfigId,
                        principalTable: "BetConfigs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrawNumbers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    DrawnOrder = table.Column<int>(type: "INTEGER", nullable: false),
                    GameId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrawNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrawNumbers_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BetNumbers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    BetId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BetNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BetNumbers_Bets_BetId",
                        column: x => x.BetId,
                        principalTable: "Bets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BetConfigs_GameRouteId",
                table: "BetConfigs",
                column: "GameRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_BetNumbers_BetId",
                table: "BetNumbers",
                column: "BetId");

            migrationBuilder.CreateIndex(
                name: "IX_Bets_ConfigId",
                table: "Bets",
                column: "ConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_DrawNumbers_GameId",
                table: "DrawNumbers",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameRouteId",
                table: "Games",
                column: "GameRouteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BetNumbers");

            migrationBuilder.DropTable(
                name: "DrawNumbers");

            migrationBuilder.DropTable(
                name: "Bets");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "BetConfigs");

            migrationBuilder.DropTable(
                name: "Routes");
        }
    }
}
