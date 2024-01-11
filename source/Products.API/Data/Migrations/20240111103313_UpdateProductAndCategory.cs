using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Products.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductAndCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "BannerUrl",
                value: "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/Mac-Air-M2-2400-600-1920x480.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/Mac-Air-M1-2400-600-1920x480.png");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "BannerUrl", "Description", "Name" },
                values: new object[,]
                {
                    { 3, "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/ipad9-2400-600-1920x480.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2024/01/banner/iPad-Air5-2400-600-1920x480.png", "All kinds of tablets", "Tablet" },
                    { 4, "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/Phu-kien-2400-600-1920x480-2.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2024/01/banner/OLIP-15-2400-600-1920x480.png", "All kinds of accessories", "Accessory" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 11, 17, 33, 12, 395, DateTimeKind.Local).AddTicks(1605), new DateTime(2024, 1, 11, 17, 33, 12, 395, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 11, 17, 33, 12, 395, DateTimeKind.Local).AddTicks(1625), new DateTime(2024, 1, 11, 17, 33, 12, 395, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 11, 17, 33, 12, 395, DateTimeKind.Local).AddTicks(1629), new DateTime(2024, 1, 11, 17, 33, 12, 395, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 11, 17, 33, 12, 395, DateTimeKind.Local).AddTicks(1631), new DateTime(2024, 1, 11, 17, 33, 12, 395, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ProductImage", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 11, 17, 33, 12, 395, DateTimeKind.Local).AddTicks(1634), "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-black-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318236/s16/apple-macbook-pro-16-inch-m3-max-2023-16-core-black-2-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-4-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-5-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-9-650x650.jpg", new DateTime(2024, 1, 11, 17, 33, 12, 395, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 11, 17, 33, 12, 395, DateTimeKind.Local).AddTicks(1637), new DateTime(2024, 1, 11, 17, 33, 12, 395, DateTimeKind.Local).AddTicks(1638) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "BannerUrl",
                value: "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/MacBook-Pro-M3-2400-600-1920x480-1.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100,s_1170x300/https://cdn.tgdd.vn/2023/12/banner/MacBook-Pro-M3-2400-600-1920x480-1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 11, 10, 19, 58, 796, DateTimeKind.Local).AddTicks(2408), new DateTime(2024, 1, 11, 10, 19, 58, 796, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 11, 10, 19, 58, 796, DateTimeKind.Local).AddTicks(2425), new DateTime(2024, 1, 11, 10, 19, 58, 796, DateTimeKind.Local).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 11, 10, 19, 58, 796, DateTimeKind.Local).AddTicks(2429), new DateTime(2024, 1, 11, 10, 19, 58, 796, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 11, 10, 19, 58, 796, DateTimeKind.Local).AddTicks(2431), new DateTime(2024, 1, 11, 10, 19, 58, 796, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ProductImage", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 11, 10, 19, 58, 796, DateTimeKind.Local).AddTicks(2434), "https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/mac16-topzone-black-650x650.png##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-2-650x650.jpghttps://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-3-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-4-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-5-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-6-650x650.jpg##https://img.tgdd.vn/imgt/f_webp,fit_outside,quality_100/https://cdn.tgdd.vn/Products/Images/44/318235/s16/apple-macbook-pro-16-inch-m3-pro-2023-12-core-36gb-black-9-650x650.jpg", new DateTime(2024, 1, 11, 10, 19, 58, 796, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 11, 10, 19, 58, 796, DateTimeKind.Local).AddTicks(2496), new DateTime(2024, 1, 11, 10, 19, 58, 796, DateTimeKind.Local).AddTicks(2497) });
        }
    }
}
