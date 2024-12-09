using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacancyManagementSystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_3_addSeedDataToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "55c6095f-679a-4cf4-822a-30ea4ea2195a", new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "6df7a402-55a6-45d1-8944-757ce5d8b3f5", new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "9553faa3-e76c-45a2-b16c-599827414041", new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5ff44213-1596-4545-8fba-74ffbe62c161", new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "eafa9c3a-e6a8-40e5-9cdc-40938ec38ab4", new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "be22c74d-43f7-4ccc-9833-e835683ee51e", new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "4a894ef5-5e17-4403-8a0f-3609c76694da", new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "a8e1791a-576f-4dbb-9654-7a09b50647c8", new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "379206f5-5292-4fa9-9c07-ead4f56e7e82", new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "6a70d1e1-cdda-4565-bb39-b1769955fdb9", new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(8777), new DateTime(2025, 1, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(8797), new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9149), new DateTime(2025, 1, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9157), new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9202), new DateTime(2025, 1, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9207), new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9239), new DateTime(2025, 1, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9294), new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9297), new DateTime(2025, 1, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9302), new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9305), new DateTime(2025, 1, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9310), new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9314), new DateTime(2025, 1, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9318), new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9324), new DateTime(2025, 1, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9327), new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9336), new DateTime(2025, 1, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9341), new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9350), new DateTime(2025, 1, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9353), new DateTime(2024, 12, 9, 21, 29, 6, 763, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 29, 6, 764, DateTimeKind.Local).AddTicks(605));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "34b08eab-5460-4ccf-883c-5a69657431f8", new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "82d1c165-b860-4e9f-a65d-50949bae6eab", new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "39814eb3-f084-4c45-9810-4e4a757443e6", new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "69435ead-7f18-41d0-bf85-d125e7f7820b", new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "76b40c5e-4ee1-475b-b135-d7ad3fde6020", new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "722c5d73-1e8c-456d-8679-cee27f1202b7", new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "82c2027a-b31e-4bb5-9780-d2042afa3473", new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "66697e90-872f-41a1-941b-ed9927c36255", new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "53371588-16ce-42df-aa8c-cb273b0ed364", new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "2df2a264-0d50-4c0f-b88e-aa1e7c3e30b5", new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 855, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 855, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 855, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 855, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 855, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 855, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 855, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 855, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 855, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 855, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1240), new DateTime(2025, 1, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1262), new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1313), new DateTime(2025, 1, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1319), new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1323), new DateTime(2025, 1, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1326), new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1396), new DateTime(2025, 1, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1538), new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1541), new DateTime(2025, 1, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1545), new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1554), new DateTime(2025, 1, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1591), new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1594), new DateTime(2025, 1, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1598), new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1600), new DateTime(2025, 1, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1604), new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1607), new DateTime(2025, 1, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1611), new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1617), new DateTime(2025, 1, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1621), new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 25, 44, 856, DateTimeKind.Local).AddTicks(2313));
        }
    }
}
