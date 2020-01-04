using Microsoft.EntityFrameworkCore.Migrations;

namespace StepCourseProject.Migrations
{
    public partial class init_fill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostSkills");

            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_SkillId",
                table: "Posts",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Skills_SkillId",
                table: "Posts",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Skills_SkillId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_SkillId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "Posts");

            migrationBuilder.CreateTable(
                name: "PostSkills",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostSkills", x => new { x.PostId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_PostSkills_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostSkills_SkillId",
                table: "PostSkills",
                column: "SkillId");
        }
    }
}
