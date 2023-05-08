using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class AddProjectStagesCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PRM_ProjectTypeId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlanState",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProjectDuration",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "StrategicPlanCode",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PRM_Document",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRM_Document", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PRM_Liable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRM_Liable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PRM_Output",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRM_Output", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PRM_ProjectType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRM_ProjectType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PRM_Stakeholder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRM_Stakeholder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectIncomeExpenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Outsource = table.Column<bool>(type: "bit", nullable: false),
                    Time = table.Column<int>(type: "int", nullable: false),
                    Abroad = table.Column<bool>(type: "bit", nullable: false),
                    ProspectiveCustomer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedPersonalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedPersonalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectIncomeExpenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectIncomeExpenses_Personals_CreatedPersonalId",
                        column: x => x.CreatedPersonalId,
                        principalTable: "Personals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectIncomeExpenses_Personals_UpdatedPersonalId",
                        column: x => x.UpdatedPersonalId,
                        principalTable: "Personals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectIncomeExpenses_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectOutputs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PRM_OutputId = table.Column<int>(type: "int", nullable: false),
                    PRM_DocumentId = table.Column<int>(type: "int", nullable: false),
                    PRM_LiableId = table.Column<int>(type: "int", nullable: false),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedPersonalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedPersonalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectOutputs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectOutputs_Personals_CreatedPersonalId",
                        column: x => x.CreatedPersonalId,
                        principalTable: "Personals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectOutputs_Personals_UpdatedPersonalId",
                        column: x => x.UpdatedPersonalId,
                        principalTable: "Personals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectOutputs_PRM_Document_PRM_DocumentId",
                        column: x => x.PRM_DocumentId,
                        principalTable: "PRM_Document",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectOutputs_PRM_Liable_PRM_LiableId",
                        column: x => x.PRM_LiableId,
                        principalTable: "PRM_Liable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectOutputs_PRM_Output_PRM_OutputId",
                        column: x => x.PRM_OutputId,
                        principalTable: "PRM_Output",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectOutputs_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectStages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Percentage = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectDuration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRM_LiableId = table.Column<int>(type: "int", nullable: false),
                    PRM_StakeholderId = table.Column<int>(type: "int", nullable: false),
                    CreatedPersonalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedPersonalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectStages_Personals_CreatedPersonalId",
                        column: x => x.CreatedPersonalId,
                        principalTable: "Personals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectStages_Personals_UpdatedPersonalId",
                        column: x => x.UpdatedPersonalId,
                        principalTable: "Personals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectStages_PRM_Liable_PRM_LiableId",
                        column: x => x.PRM_LiableId,
                        principalTable: "PRM_Liable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectStages_PRM_Stakeholder_PRM_StakeholderId",
                        column: x => x.PRM_StakeholderId,
                        principalTable: "PRM_Stakeholder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectStages_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PRM_Document",
                columns: new[] { "Id", "Description", "Name", "State" },
                values: new object[,]
                {
                    { 1, "Projet Document Description", "Projet Document 1", true },
                    { 2, "Projet Document Description", "Projet Document 2", true },
                    { 3, "Projet Document Description", "Projet Document 3", true },
                    { 4, "Projet Document Description", "Projet Document 4", true },
                    { 5, "Projet Document Description", "Projet Document 5", true }
                });

            migrationBuilder.InsertData(
                table: "PRM_Liable",
                columns: new[] { "Id", "Description", "Name", "State" },
                values: new object[,]
                {
                    { 1, "Projet Liable Description", "Projet Liable 1", true },
                    { 2, "Projet Liable Description", "Projet Liable 2", true },
                    { 3, "Projet Liable Description", "Projet Liable 3", true },
                    { 4, "Projet Liable Description", "Projet Liable 4", true },
                    { 5, "Projet Liable Description", "Projet Liable 5", true }
                });

            migrationBuilder.InsertData(
                table: "PRM_Output",
                columns: new[] { "Id", "Description", "Name", "State" },
                values: new object[,]
                {
                    { 1, "Projet Output Description", "Projet Output 1", true },
                    { 2, "Projet Output Description", "Projet Output 2", true },
                    { 3, "Projet Output Description", "Projet Output 3", true },
                    { 4, "Projet Output Description", "Projet Output 4", true },
                    { 5, "Projet Output Description", "Projet Output 5", true }
                });

            migrationBuilder.InsertData(
                table: "PRM_ProjectType",
                columns: new[] { "Id", "Description", "Name", "State" },
                values: new object[,]
                {
                    { 1, "Projet ProjectType Description", "Projet ProjectType 1", true },
                    { 2, "Projet ProjectType Description", "Projet ProjectType 2", true },
                    { 3, "Projet ProjectType Description", "Projet ProjectType 3", true },
                    { 4, "Projet ProjectType Description", "Projet ProjectType 4", true },
                    { 5, "Projet ProjectType Description", "Projet ProjectType 5", true }
                });

            migrationBuilder.InsertData(
                table: "PRM_Stakeholder",
                columns: new[] { "Id", "Description", "Name", "State" },
                values: new object[,]
                {
                    { 1, "Projet Stakeholder Description", "Projet Stakeholder 1", true },
                    { 2, "Projet Stakeholder Description", "Projet Stakeholder 2", true },
                    { 3, "Projet Stakeholder Description", "Projet Stakeholder 3", true },
                    { 4, "Projet Stakeholder Description", "Projet Stakeholder 4", true },
                    { 5, "Projet Stakeholder Description", "Projet Stakeholder 5", true }
                });

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
                columns: new[] { "CreatedDate", "EndDate", "PRM_ProjectTypeId", "StartDate", "StrategicPlanCode", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3578), new DateTime(2024, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3572), 1, new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3568), 12345, new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("841eccf0-b978-442c-a5cb-d0808bc7439b"),
                columns: new[] { "CreatedDate", "EndDate", "PRM_ProjectTypeId", "StartDate", "StrategicPlanCode", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3595), new DateTime(2024, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3595), 1, new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3594), 12345, new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("e9567f76-4ed8-48b7-b30d-ebafaa8b909e"),
                columns: new[] { "CreatedDate", "EndDate", "PRM_ProjectTypeId", "StartDate", "StrategicPlanCode", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3590), new DateTime(2024, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3588), 1, new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3587), 12345, new DateTime(2023, 5, 6, 17, 8, 13, 989, DateTimeKind.Local).AddTicks(3591) });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_PRM_ProjectTypeId",
                table: "Projects",
                column: "PRM_ProjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectIncomeExpenses_CreatedPersonalId",
                table: "ProjectIncomeExpenses",
                column: "CreatedPersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectIncomeExpenses_ProjectId",
                table: "ProjectIncomeExpenses",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectIncomeExpenses_UpdatedPersonalId",
                table: "ProjectIncomeExpenses",
                column: "UpdatedPersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectOutputs_CreatedPersonalId",
                table: "ProjectOutputs",
                column: "CreatedPersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectOutputs_PRM_DocumentId",
                table: "ProjectOutputs",
                column: "PRM_DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectOutputs_PRM_LiableId",
                table: "ProjectOutputs",
                column: "PRM_LiableId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectOutputs_PRM_OutputId",
                table: "ProjectOutputs",
                column: "PRM_OutputId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectOutputs_ProjectId",
                table: "ProjectOutputs",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectOutputs_UpdatedPersonalId",
                table: "ProjectOutputs",
                column: "UpdatedPersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectStages_CreatedPersonalId",
                table: "ProjectStages",
                column: "CreatedPersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectStages_PRM_LiableId",
                table: "ProjectStages",
                column: "PRM_LiableId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectStages_PRM_StakeholderId",
                table: "ProjectStages",
                column: "PRM_StakeholderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectStages_ProjectId",
                table: "ProjectStages",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectStages_UpdatedPersonalId",
                table: "ProjectStages",
                column: "UpdatedPersonalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_PRM_ProjectType_PRM_ProjectTypeId",
                table: "Projects",
                column: "PRM_ProjectTypeId",
                principalTable: "PRM_ProjectType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_PRM_ProjectType_PRM_ProjectTypeId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "PRM_ProjectType");

            migrationBuilder.DropTable(
                name: "ProjectIncomeExpenses");

            migrationBuilder.DropTable(
                name: "ProjectOutputs");

            migrationBuilder.DropTable(
                name: "ProjectStages");

            migrationBuilder.DropTable(
                name: "PRM_Document");

            migrationBuilder.DropTable(
                name: "PRM_Output");

            migrationBuilder.DropTable(
                name: "PRM_Liable");

            migrationBuilder.DropTable(
                name: "PRM_Stakeholder");

            migrationBuilder.DropIndex(
                name: "IX_Projects_PRM_ProjectTypeId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PRM_ProjectTypeId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "PlanState",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectDuration",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "StrategicPlanCode",
                table: "Projects");

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
        }
    }
}
