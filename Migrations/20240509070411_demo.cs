using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class demo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "customer_order_id",
                table: "order_items",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "order_id1",
                table: "order_items",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_orders_user_id",
                table: "orders",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_order_items_customer_order_id",
                table: "order_items",
                column: "customer_order_id");

            migrationBuilder.CreateIndex(
                name: "ix_order_items_order_id1",
                table: "order_items",
                column: "order_id1");

            migrationBuilder.AddForeignKey(
                name: "fk_order_items_customer_orders_customer_order_id",
                table: "order_items",
                column: "customer_order_id",
                principalTable: "customer_orders",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_order_items_orders_order_id1",
                table: "order_items",
                column: "order_id1",
                principalTable: "orders",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_orders_users_user_id",
                table: "orders",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_order_items_customer_orders_customer_order_id",
                table: "order_items");

            migrationBuilder.DropForeignKey(
                name: "fk_order_items_orders_order_id1",
                table: "order_items");

            migrationBuilder.DropForeignKey(
                name: "fk_orders_users_user_id",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "ix_orders_user_id",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "ix_order_items_customer_order_id",
                table: "order_items");

            migrationBuilder.DropIndex(
                name: "ix_order_items_order_id1",
                table: "order_items");

            migrationBuilder.DropColumn(
                name: "customer_order_id",
                table: "order_items");

            migrationBuilder.DropColumn(
                name: "order_id1",
                table: "order_items");
        }
    }
}
