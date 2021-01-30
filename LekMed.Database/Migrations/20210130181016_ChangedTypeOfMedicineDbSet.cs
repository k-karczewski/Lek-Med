using Microsoft.EntityFrameworkCore.Migrations;

namespace LekMed.Database.Migrations
{
    public partial class ChangedTypeOfMedicineDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicineEntity_Prescriptions_PrescriptionId",
                table: "MedicineEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_DoctorEntity_DoctorId",
                table: "Prescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicineEntity",
                table: "MedicineEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorEntity",
                table: "DoctorEntity");

            migrationBuilder.RenameTable(
                name: "MedicineEntity",
                newName: "Medicines");

            migrationBuilder.RenameTable(
                name: "DoctorEntity",
                newName: "Doctors");

            migrationBuilder.RenameIndex(
                name: "IX_MedicineEntity_PrescriptionId",
                table: "Medicines",
                newName: "IX_Medicines_PrescriptionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicines",
                table: "Medicines",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Prescriptions_PrescriptionId",
                table: "Medicines",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorId",
                table: "Prescriptions",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Prescriptions_PrescriptionId",
                table: "Medicines");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorId",
                table: "Prescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicines",
                table: "Medicines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors");

            migrationBuilder.RenameTable(
                name: "Medicines",
                newName: "MedicineEntity");

            migrationBuilder.RenameTable(
                name: "Doctors",
                newName: "DoctorEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Medicines_PrescriptionId",
                table: "MedicineEntity",
                newName: "IX_MedicineEntity_PrescriptionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicineEntity",
                table: "MedicineEntity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorEntity",
                table: "DoctorEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineEntity_Prescriptions_PrescriptionId",
                table: "MedicineEntity",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_DoctorEntity_DoctorId",
                table: "Prescriptions",
                column: "DoctorId",
                principalTable: "DoctorEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
