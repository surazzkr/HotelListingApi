using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListingApi.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f2aeb6bc-fc85-4ee6-8586-238fbdc70d5d", "8040f36b-d4eb-4893-a7da-186b72e6e543", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43c30062-bfc9-4acc-8a8f-d9247cf79320", "9f25d2dd-5fa5-42fd-b2e6-11f7a2be54b3", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43c30062-bfc9-4acc-8a8f-d9247cf79320");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2aeb6bc-fc85-4ee6-8586-238fbdc70d5d");
        }
    }
}
