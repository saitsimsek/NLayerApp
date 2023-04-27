using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApprovalStatus",
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
                    table.PrimaryKey("PK_ApprovalStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Position = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalTitles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedPersonalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedPersonalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalTitles_Personals_CreatedPersonalId",
                        column: x => x.CreatedPersonalId,
                        principalTable: "Personals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PersonalTitles_Personals_UpdatedPersonalId",
                        column: x => x.UpdatedPersonalId,
                        principalTable: "Personals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ApprovalStatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedPersonalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedPersonalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_ApprovalStatus_ApprovalStatusId",
                        column: x => x.ApprovalStatusId,
                        principalTable: "ApprovalStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_Personals_CreatedPersonalId",
                        column: x => x.CreatedPersonalId,
                        principalTable: "Personals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Projects_Personals_UpdatedPersonalId",
                        column: x => x.UpdatedPersonalId,
                        principalTable: "Personals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubTechnologyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailableTRL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoalTRL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailableTRLDocumentation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiskPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImportantConsiderations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedPersonalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedPersonalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectDetails_Personals_CreatedPersonalId",
                        column: x => x.CreatedPersonalId,
                        principalTable: "Personals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDetails_Personals_UpdatedPersonalId",
                        column: x => x.UpdatedPersonalId,
                        principalTable: "Personals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDetails_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectPersonals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonalTitleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedPersonalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedPersonalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectPersonals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectPersonals_Personals_CreatedPersonalId",
                        column: x => x.CreatedPersonalId,
                        principalTable: "Personals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectPersonals_Personals_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectPersonals_Personals_UpdatedPersonalId",
                        column: x => x.UpdatedPersonalId,
                        principalTable: "Personals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectPersonals_PersonalTitles_PersonalTitleId",
                        column: x => x.PersonalTitleId,
                        principalTable: "PersonalTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectPersonals_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ApprovalStatus",
                columns: new[] { "Id", "Description", "Name", "State" },
                values: new object[,]
                {
                    { 1, "Projet Approval Description", "Projet Approval 1", true },
                    { 2, "Projet Approval Description", "Projet Approval 2", true },
                    { 3, "Projet Approval Description", "Projet Approval 3", true },
                    { 4, "Projet Approval Description", "Projet Approval 4", true },
                    { 5, "Projet Approval Description", "Projet Approval 5", true }
                });

            migrationBuilder.InsertData(
                table: "Personals",
                columns: new[] { "Id", "CreatedDate", "Description", "Email", "Name", "PhoneNumber", "Position", "RegistrationNumber", "State", "SurName", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1847), "Admin Description", "admin@gmail.com", "Admin Name 1", "(505)0000000", "Sistem Yöneticisi", "000", true, "Admin SurName 1", new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1864) },
                    { new Guid("11181a4e-ab99-42c5-805a-346e4c5f02bd"), new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1894), "Personal 3 Description", "personal3@gmail.com", "Personel Name 3", "(505)5050003", "Mühendis", "125", true, "Personal SurName 3", new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1895) },
                    { new Guid("2f09bf40-1528-4980-900f-716914abfbf2"), new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1877), "Personal 1 Description", "personal1@gmail.com", "Personel Name 1", "(505)5050001", "Müdür", "123", true, "Personal SurName 1", new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1878) },
                    { new Guid("81e922c4-4e7f-4925-a9fd-7e9ff3266382"), new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1885), "Personal 2 Description", "personal2@gmail.com", "Personel Name 2", "(505)5050002", "Müdür Yardımcısı", "124", true, "Personal SurName 2", new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1886) },
                    { new Guid("9fb768ef-4f17-471d-b2e8-626b1bc48e02"), new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1900), "Personal 4 Description", "personal4@gmail.com", "Personel Name 4", "(505)5050004", "Mühendis", "126", true, "Personal SurName 4", new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1901) },
                    { new Guid("a2e31a5d-6069-4ec8-8ce2-c65cc96d43fc"), new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1913), "Personal 6 Description", "personal6@gmail.com", "Personel Name 6", "(505)5050006", "Mühendis", "128", true, "Personal SurName 6", new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1914) },
                    { new Guid("f7f14713-d762-4714-bbc9-5111e5294494"), new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1906), "Personal 5 Description", "personal5@gmail.com", "Personel Name 5", "(505)5050005", "Mühendis", "127", true, "Personal SurName 5", new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(1907) }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ApprovalStatusId", "CreatedDate", "CreatedPersonalId", "Description", "Name", "Purpose", "State", "Unit", "UpdatedDate", "UpdatedPersonalId" },
                values: new object[] { new Guid("4c547e3f-1893-45ea-abe1-329379ebdaa5"), 1, new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(2248), new Guid("00000000-0000-0000-0000-000000000001"), "Proje A Description", "Proje A", "Proje A Purpose", true, "Proje A Unit", new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(2253), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ApprovalStatusId", "CreatedDate", "CreatedPersonalId", "Description", "Name", "Purpose", "State", "Unit", "UpdatedDate", "UpdatedPersonalId" },
                values: new object[] { new Guid("841eccf0-b978-442c-a5cb-d0808bc7439b"), 1, new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(2272), new Guid("00000000-0000-0000-0000-000000000001"), "Proje C Description", "Proje C", "Proje C Purpose", true, "Proje C Unit", new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(2275), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ApprovalStatusId", "CreatedDate", "CreatedPersonalId", "Description", "Name", "Purpose", "State", "Unit", "UpdatedDate", "UpdatedPersonalId" },
                values: new object[] { new Guid("e9567f76-4ed8-48b7-b30d-ebafaa8b909e"), 1, new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(2262), new Guid("00000000-0000-0000-0000-000000000001"), "Proje B Description", "Proje B", "Proje B Purpose", true, "Proje B Unit", new DateTime(2023, 4, 27, 1, 11, 52, 27, DateTimeKind.Local).AddTicks(2265), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalTitles_CreatedPersonalId",
                table: "PersonalTitles",
                column: "CreatedPersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalTitles_UpdatedPersonalId",
                table: "PersonalTitles",
                column: "UpdatedPersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDetails_CreatedPersonalId",
                table: "ProjectDetails",
                column: "CreatedPersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDetails_ProjectId",
                table: "ProjectDetails",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDetails_UpdatedPersonalId",
                table: "ProjectDetails",
                column: "UpdatedPersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPersonals_CreatedPersonalId",
                table: "ProjectPersonals",
                column: "CreatedPersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPersonals_PersonalId",
                table: "ProjectPersonals",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPersonals_PersonalTitleId",
                table: "ProjectPersonals",
                column: "PersonalTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPersonals_ProjectId",
                table: "ProjectPersonals",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPersonals_UpdatedPersonalId",
                table: "ProjectPersonals",
                column: "UpdatedPersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ApprovalStatusId",
                table: "Projects",
                column: "ApprovalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CreatedPersonalId",
                table: "Projects",
                column: "CreatedPersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UpdatedPersonalId",
                table: "Projects",
                column: "UpdatedPersonalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectDetails");

            migrationBuilder.DropTable(
                name: "ProjectPersonals");

            migrationBuilder.DropTable(
                name: "PersonalTitles");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "ApprovalStatus");

            migrationBuilder.DropTable(
                name: "Personals");
        }
    }
}
