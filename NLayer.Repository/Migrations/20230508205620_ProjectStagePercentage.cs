using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class ProjectStagePercentage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Percentage",
                table: "ProjectStages",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(5827), new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("11181a4e-ab99-42c5-805a-346e4c5f02bd"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(5857), new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("2f09bf40-1528-4980-900f-716914abfbf2"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(5847), new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("81e922c4-4e7f-4925-a9fd-7e9ff3266382"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(5854), new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("9fb768ef-4f17-471d-b2e8-626b1bc48e02"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(5861), new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("a2e31a5d-6069-4ec8-8ce2-c65cc96d43fc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(5868), new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("f7f14713-d762-4714-bbc9-5111e5294494"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(5865), new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("4c547e3f-1893-45ea-abe1-329379ebdaa5"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(7421), new DateTime(2024, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(7415), new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(7412), new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("841eccf0-b978-442c-a5cb-d0808bc7439b"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(7433), new DateTime(2024, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(7432), new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(7432), new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("e9567f76-4ed8-48b7-b30d-ebafaa8b909e"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(7428), new DateTime(2024, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(7427), new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(7426), new DateTime(2023, 5, 8, 23, 56, 19, 907, DateTimeKind.Local).AddTicks(7429) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Percentage",
                table: "ProjectStages",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(1435), new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("11181a4e-ab99-42c5-805a-346e4c5f02bd"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(1472), new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("2f09bf40-1528-4980-900f-716914abfbf2"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(1463), new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("81e922c4-4e7f-4925-a9fd-7e9ff3266382"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(1468), new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("9fb768ef-4f17-471d-b2e8-626b1bc48e02"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(1477), new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("a2e31a5d-6069-4ec8-8ce2-c65cc96d43fc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(1484), new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("f7f14713-d762-4714-bbc9-5111e5294494"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(1480), new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("4c547e3f-1893-45ea-abe1-329379ebdaa5"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3578), new DateTime(2024, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3572), new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3568), new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("841eccf0-b978-442c-a5cb-d0808bc7439b"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3595), new DateTime(2024, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3595), new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3594), new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("e9567f76-4ed8-48b7-b30d-ebafaa8b909e"),
                columns: new[] { "CreatedDate", "EndDate", "StartDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3590), new DateTime(2024, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3588), new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3587), new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3591) });
        }
    }
}
