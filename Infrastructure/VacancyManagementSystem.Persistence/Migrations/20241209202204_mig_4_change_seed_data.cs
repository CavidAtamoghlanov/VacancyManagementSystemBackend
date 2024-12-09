using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacancyManagementSystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_4_change_seed_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 628, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 628, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 628, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 628, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 628, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 628, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 628, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 628, DateTimeKind.Local).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 628, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 628, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 631, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 631, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 631, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 631, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 631, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 631, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 631, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 631, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 631, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 631, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 633, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 633, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "61677e49-8a3d-4454-aa6c-fd80432e33d8", new DateTime(2024, 12, 10, 0, 22, 3, 634, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "b738d635-da83-4a15-bccc-925edb14e91f", new DateTime(2024, 12, 10, 0, 22, 3, 634, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "ace98982-93e9-40d7-8ad3-ec13d2ab1178", new DateTime(2024, 12, 10, 0, 22, 3, 634, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "7675aca3-aa33-4bf2-b7e5-2554ffea61c4", new DateTime(2024, 12, 10, 0, 22, 3, 634, DateTimeKind.Local).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "67b04e97-2956-49cf-b1f6-4709013b4ba9", new DateTime(2024, 12, 10, 0, 22, 3, 634, DateTimeKind.Local).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "30930d31-fc24-44a2-b7c9-ba454c3c16e5", new DateTime(2024, 12, 10, 0, 22, 3, 634, DateTimeKind.Local).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "a8b295a2-6f0d-40a4-bc78-5a19d33fa531", new DateTime(2024, 12, 10, 0, 22, 3, 634, DateTimeKind.Local).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "e742b0cd-12e6-4611-a933-b45f83e7d932", new DateTime(2024, 12, 10, 0, 22, 3, 634, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "5596c292-9746-43ec-9f92-685369be2d66", new DateTime(2024, 12, 10, 0, 22, 3, 634, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "4c361719-ca90-4207-82a6-cdf017da1aee", new DateTime(2024, 12, 10, 0, 22, 3, 634, DateTimeKind.Local).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 635, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 635, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 635, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 635, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 635, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 635, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 635, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 635, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 635, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 635, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 636, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8225), new DateTime(2025, 1, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8236), new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8247), new DateTime(2025, 1, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8250), new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8255), new DateTime(2025, 1, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8258), new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8261), new DateTime(2025, 1, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8264), new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8266), new DateTime(2025, 1, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8270), new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8273), new DateTime(2025, 1, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8276), new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8278), new DateTime(2025, 1, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8282), new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8284), new DateTime(2025, 1, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8287), new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8290), new DateTime(2025, 1, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8293), new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8296), new DateTime(2025, 1, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8299), new DateTime(2024, 12, 10, 0, 22, 3, 637, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 638, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 638, DateTimeKind.Local).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 638, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 638, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 638, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 638, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 638, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 638, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 638, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 10, 0, 22, 3, 638, DateTimeKind.Local).AddTicks(3255));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
