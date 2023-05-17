using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortal_API.Migrations
{
    public partial class newinitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_JobListings_JobListingJobID",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Users_UserID",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobListings_Users_UserID",
                table: "JobListings");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRoles_UserRoleID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserRoleID",
                table: "Users",
                newName: "UserRoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserRoleID",
                table: "Users",
                newName: "IX_Users_UserRoleId");

            migrationBuilder.RenameColumn(
                name: "UserRoleID",
                table: "UserRoles",
                newName: "UserRoleId");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "JobListings",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "JobID",
                table: "JobListings",
                newName: "JobId");

            migrationBuilder.RenameIndex(
                name: "IX_JobListings_UserID",
                table: "JobListings",
                newName: "IX_JobListings_UserId");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Applications",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "JobListingJobID",
                table: "Applications",
                newName: "JobListingJobId");

            migrationBuilder.RenameColumn(
                name: "JobID",
                table: "Applications",
                newName: "JobId");

            migrationBuilder.RenameColumn(
                name: "ApplicationID",
                table: "Applications",
                newName: "ApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Applications_UserID",
                table: "Applications",
                newName: "IX_Applications_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Applications_JobListingJobID",
                table: "Applications",
                newName: "IX_Applications_JobListingJobId");

            migrationBuilder.AlterColumn<int>(
                name: "UserRoleId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_JobListings_JobListingJobId",
                table: "Applications",
                column: "JobListingJobId",
                principalTable: "JobListings",
                principalColumn: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Users_UserId",
                table: "Applications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobListings_Users_UserId",
                table: "JobListings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserRoles_UserRoleId",
                table: "Users",
                column: "UserRoleId",
                principalTable: "UserRoles",
                principalColumn: "UserRoleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_JobListings_JobListingJobId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Users_UserId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobListings_Users_UserId",
                table: "JobListings");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRoles_UserRoleId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserRoleId",
                table: "Users",
                newName: "UserRoleID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserRoleId",
                table: "Users",
                newName: "IX_Users_UserRoleID");

            migrationBuilder.RenameColumn(
                name: "UserRoleId",
                table: "UserRoles",
                newName: "UserRoleID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "JobListings",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "JobListings",
                newName: "JobID");

            migrationBuilder.RenameIndex(
                name: "IX_JobListings_UserId",
                table: "JobListings",
                newName: "IX_JobListings_UserID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Applications",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "JobListingJobId",
                table: "Applications",
                newName: "JobListingJobID");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "Applications",
                newName: "JobID");

            migrationBuilder.RenameColumn(
                name: "ApplicationId",
                table: "Applications",
                newName: "ApplicationID");

            migrationBuilder.RenameIndex(
                name: "IX_Applications_UserId",
                table: "Applications",
                newName: "IX_Applications_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Applications_JobListingJobId",
                table: "Applications",
                newName: "IX_Applications_JobListingJobID");

            migrationBuilder.AlterColumn<int>(
                name: "UserRoleID",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_JobListings_JobListingJobID",
                table: "Applications",
                column: "JobListingJobID",
                principalTable: "JobListings",
                principalColumn: "JobID");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Users_UserID",
                table: "Applications",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobListings_Users_UserID",
                table: "JobListings",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserRoles_UserRoleID",
                table: "Users",
                column: "UserRoleID",
                principalTable: "UserRoles",
                principalColumn: "UserRoleID");
        }
    }
}
