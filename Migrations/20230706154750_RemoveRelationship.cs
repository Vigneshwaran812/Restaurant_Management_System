﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Reservation_Management_System_Api.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodItems_AddToCart_AddToCartId",
                table: "FoodItems");

            migrationBuilder.DropIndex(
                name: "IX_FoodItems_AddToCartId",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "AddToCartId",
                table: "FoodItems");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddToCartId",
                table: "FoodItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FoodItems_AddToCartId",
                table: "FoodItems",
                column: "AddToCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItems_AddToCart_AddToCartId",
                table: "FoodItems",
                column: "AddToCartId",
                principalTable: "AddToCart",
                principalColumn: "AddToCartId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
