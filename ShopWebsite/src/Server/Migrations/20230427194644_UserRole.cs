using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopWebsite.Server.Migrations
{
    public partial class UserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4389));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 21, 37, 23, 50, DateTimeKind.Local).AddTicks(6437));
        }
    }
}
