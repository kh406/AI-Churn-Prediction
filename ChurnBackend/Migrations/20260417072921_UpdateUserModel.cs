using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChurnBackend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SubscriptionStart",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "TotalCharges");

            migrationBuilder.RenameColumn(
                name: "LoginCount",
                table: "Users",
                newName: "Tenure");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "TechSupport");

            migrationBuilder.AddColumn<string>(
                name: "Churn",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Contract",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerID",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Dependents",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeviceProtection",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InternetService",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "MonthlyCharges",
                table: "Users",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "MultipleLines",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OnlineBackup",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OnlineSecurity",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaperlessBilling",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Partner",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneService",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SeniorCitizen",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StreamingMovies",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StreamingTV",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Churn",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Contract",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Dependents",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeviceProtection",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "InternetService",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MonthlyCharges",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MultipleLines",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OnlineBackup",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OnlineSecurity",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PaperlessBilling",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Partner",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneService",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SeniorCitizen",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StreamingMovies",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StreamingTV",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "TotalCharges",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Tenure",
                table: "Users",
                newName: "LoginCount");

            migrationBuilder.RenameColumn(
                name: "TechSupport",
                table: "Users",
                newName: "Email");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "SubscriptionStart",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
