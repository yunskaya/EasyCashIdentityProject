using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityProject.DataAccessLayer.Migrations
{
    public partial class add_mig_relation_customerAccount_appUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "CostumerAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CostumerAccounts_AppUserID",
                table: "CostumerAccounts",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_CostumerAccounts_AspNetUsers_AppUserID",
                table: "CostumerAccounts",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CostumerAccounts_AspNetUsers_AppUserID",
                table: "CostumerAccounts");

            migrationBuilder.DropIndex(
                name: "IX_CostumerAccounts_AppUserID",
                table: "CostumerAccounts");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "CostumerAccounts");
        }
    }
}
