using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VacancyManagementSystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_2_Add_Changes_On_Tabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 9, 53, 163, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 9, 53, 163, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "c0621ae2-d64f-4b25-a034-db9d65754d7a", new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "10913ae4-a135-4e47-9e43-314311007d4e", new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8108), new DateTime(2025, 1, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8117), new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8149), new DateTime(2025, 1, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8153), new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 21, 9, 53, 164, DateTimeKind.Local).AddTicks(8549));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "AnswerOptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "1ef9c9c2-093e-4eac-be75-a59b58bcab4e", new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "bc74af40-e1d2-426b-9527-a29482ead473", new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "QuestionBanks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "TestAnswers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2342), new DateTime(2025, 1, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2347), new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2358), new DateTime(2025, 1, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2361), new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "VacancyQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 6, 12, 14, 35, 510, DateTimeKind.Local).AddTicks(2514));
        }
    }
}
