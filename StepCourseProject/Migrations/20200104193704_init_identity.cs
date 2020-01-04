using Microsoft.EntityFrameworkCore.Migrations;

namespace StepCourseProject.Migrations
{
    public partial class init_identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSkills",
                table: "UserSkills");

            migrationBuilder.DropIndex(
                name: "IX_UserSkills_AppUserId",
                table: "UserSkills");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSkills",
                table: "UserSkills",
                columns: new[] { "AppUserId", "SkillId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_SkillId",
                table: "UserSkills",
                column: "SkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSkills",
                table: "UserSkills");

            migrationBuilder.DropIndex(
                name: "IX_UserSkills_SkillId",
                table: "UserSkills");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSkills",
                table: "UserSkills",
                columns: new[] { "SkillId", "AppUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_AppUserId",
                table: "UserSkills",
                column: "AppUserId");
        }
    }
}
