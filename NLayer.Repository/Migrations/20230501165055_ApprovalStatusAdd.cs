using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class ApprovalStatusAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ApprovalStatus_ApprovalStatusId",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApprovalStatus",
                table: "ApprovalStatus");

            migrationBuilder.RenameTable(
                name: "ApprovalStatus",
                newName: "ApprovalStatuses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApprovalStatuses",
                table: "ApprovalStatuses",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3432), new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("11181a4e-ab99-42c5-805a-346e4c5f02bd"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3465), new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("2f09bf40-1528-4980-900f-716914abfbf2"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3454), new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("81e922c4-4e7f-4925-a9fd-7e9ff3266382"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3459), new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("9fb768ef-4f17-471d-b2e8-626b1bc48e02"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3469), new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("a2e31a5d-6069-4ec8-8ce2-c65cc96d43fc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3479), new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("f7f14713-d762-4714-bbc9-5111e5294494"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3474), new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("4c547e3f-1893-45ea-abe1-329379ebdaa5"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3684), new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("841eccf0-b978-442c-a5cb-d0808bc7439b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3770), new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("e9567f76-4ed8-48b7-b30d-ebafaa8b909e"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3762), new DateTime(2023, 5, 1, 19, 50, 54, 954, DateTimeKind.Local).AddTicks(3765) });

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ApprovalStatuses_ApprovalStatusId",
                table: "Projects",
                column: "ApprovalStatusId",
                principalTable: "ApprovalStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ApprovalStatuses_ApprovalStatusId",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApprovalStatuses",
                table: "ApprovalStatuses");

            migrationBuilder.RenameTable(
                name: "ApprovalStatuses",
                newName: "ApprovalStatus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApprovalStatus",
                table: "ApprovalStatus",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1847), new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("11181a4e-ab99-42c5-805a-346e4c5f02bd"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1894), new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("2f09bf40-1528-4980-900f-716914abfbf2"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1877), new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("81e922c4-4e7f-4925-a9fd-7e9ff3266382"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1885), new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("9fb768ef-4f17-471d-b2e8-626b1bc48e02"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1900), new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("a2e31a5d-6069-4ec8-8ce2-c65cc96d43fc"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1913), new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Personals",
                keyColumn: "Id",
                keyValue: new Guid("f7f14713-d762-4714-bbc9-5111e5294494"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1906), new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("4c547e3f-1893-45ea-abe1-329379ebdaa5"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(2248), new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("841eccf0-b978-442c-a5cb-d0808bc7439b"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(2272), new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("e9567f76-4ed8-48b7-b30d-ebafaa8b909e"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(2262), new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(2265) });

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ApprovalStatus_ApprovalStatusId",
                table: "Projects",
                column: "ApprovalStatusId",
                principalTable: "ApprovalStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
