﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoctorApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[,]
                {
                    { 1, new byte[] { 177, 241, 132, 216, 54, 190, 213, 30, 139, 53, 241, 167, 173, 109, 195, 13, 57, 217, 14, 240, 26, 253, 173, 237, 193, 97, 93, 44, 176, 87, 128, 189, 38, 61, 35, 82, 23, 194, 124, 244, 30, 46, 116, 246, 29, 11, 220, 244, 149, 236, 132, 251, 139, 20, 243, 144, 88, 212, 70, 227, 206, 29, 36, 233 }, new byte[] { 105, 216, 84, 127, 63, 134, 22, 91, 45, 216, 199, 129, 245, 2, 214, 115, 86, 154, 28, 247, 124, 249, 225, 130, 81, 121, 101, 36, 200, 43, 225, 18, 56, 50, 45, 2, 119, 102, 69, 150, 23, 191, 82, 144, 26, 189, 84, 110, 205, 151, 81, 93, 210, 200, 222, 150, 226, 81, 65, 180, 137, 188, 200, 11, 200, 143, 229, 235, 124, 236, 226, 231, 116, 68, 112, 74, 94, 208, 198, 235, 184, 163, 153, 65, 16, 128, 132, 126, 189, 132, 37, 93, 172, 165, 254, 58, 45, 63, 212, 88, 207, 43, 191, 145, 225, 172, 23, 35, 253, 128, 109, 223, 16, 111, 209, 56, 188, 48, 239, 15, 207, 52, 24, 12, 136, 72, 193, 152 }, "Jose" },
                    { 2, new byte[] { 177, 241, 132, 216, 54, 190, 213, 30, 139, 53, 241, 167, 173, 109, 195, 13, 57, 217, 14, 240, 26, 253, 173, 237, 193, 97, 93, 44, 176, 87, 128, 189, 38, 61, 35, 82, 23, 194, 124, 244, 30, 46, 116, 246, 29, 11, 220, 244, 149, 236, 132, 251, 139, 20, 243, 144, 88, 212, 70, 227, 206, 29, 36, 233 }, new byte[] { 105, 216, 84, 127, 63, 134, 22, 91, 45, 216, 199, 129, 245, 2, 214, 115, 86, 154, 28, 247, 124, 249, 225, 130, 81, 121, 101, 36, 200, 43, 225, 18, 56, 50, 45, 2, 119, 102, 69, 150, 23, 191, 82, 144, 26, 189, 84, 110, 205, 151, 81, 93, 210, 200, 222, 150, 226, 81, 65, 180, 137, 188, 200, 11, 200, 143, 229, 235, 124, 236, 226, 231, 116, 68, 112, 74, 94, 208, 198, 235, 184, 163, 153, 65, 16, 128, 132, 126, 189, 132, 37, 93, 172, 165, 254, 58, 45, 63, 212, 88, 207, 43, 191, 145, 225, 172, 23, 35, 253, 128, 109, 223, 16, 111, 209, 56, 188, 48, 239, 15, 207, 52, 24, 12, 136, 72, 193, 152 }, "Celina" },
                    { 3, new byte[] { 177, 241, 132, 216, 54, 190, 213, 30, 139, 53, 241, 167, 173, 109, 195, 13, 57, 217, 14, 240, 26, 253, 173, 237, 193, 97, 93, 44, 176, 87, 128, 189, 38, 61, 35, 82, 23, 194, 124, 244, 30, 46, 116, 246, 29, 11, 220, 244, 149, 236, 132, 251, 139, 20, 243, 144, 88, 212, 70, 227, 206, 29, 36, 233 }, new byte[] { 105, 216, 84, 127, 63, 134, 22, 91, 45, 216, 199, 129, 245, 2, 214, 115, 86, 154, 28, 247, 124, 249, 225, 130, 81, 121, 101, 36, 200, 43, 225, 18, 56, 50, 45, 2, 119, 102, 69, 150, 23, 191, 82, 144, 26, 189, 84, 110, 205, 151, 81, 93, 210, 200, 222, 150, 226, 81, 65, 180, 137, 188, 200, 11, 200, 143, 229, 235, 124, 236, 226, 231, 116, 68, 112, 74, 94, 208, 198, 235, 184, 163, 153, 65, 16, 128, 132, 126, 189, 132, 37, 93, 172, 165, 254, 58, 45, 63, 212, 88, 207, 43, 191, 145, 225, 172, 23, 35, 253, 128, 109, 223, 16, 111, 209, 56, 188, 48, 239, 15, 207, 52, 24, 12, 136, 72, 193, 152 }, "Gloria" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
