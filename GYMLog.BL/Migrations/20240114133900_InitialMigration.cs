using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYMLog.BL.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Eatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Eatings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkoutPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutPlans_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeightedFoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    EatingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightedFoods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeightedFoods_Eatings_EatingId",
                        column: x => x.EatingId,
                        principalTable: "Eatings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WeightedFoods_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: true),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: true),
                    Sets = table.Column<int>(type: "int", nullable: true),
                    WorkoutPlanId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercises_WorkoutPlans_WorkoutPlanId",
                        column: x => x.WorkoutPlanId,
                        principalTable: "WorkoutPlans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExerciseParams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iterations = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    WorkoutExerciseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseParams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseParams_Exercises_WorkoutExerciseId",
                        column: x => x.WorkoutExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Eatings_UserId",
                table: "Eatings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseParams_WorkoutExerciseId",
                table: "ExerciseParams",
                column: "WorkoutExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_WorkoutPlanId",
                table: "Exercises",
                column: "WorkoutPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GenderId",
                table: "Users",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_WeightedFoods_EatingId",
                table: "WeightedFoods",
                column: "EatingId");

            migrationBuilder.CreateIndex(
                name: "IX_WeightedFoods_FoodId",
                table: "WeightedFoods",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutPlans_UserId",
                table: "WorkoutPlans",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseParams");

            migrationBuilder.DropTable(
                name: "WeightedFoods");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Eatings");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "WorkoutPlans");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
