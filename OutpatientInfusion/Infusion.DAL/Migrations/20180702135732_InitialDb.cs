using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infusion.DAL.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dept",
                columns: table => new
                {
                    UpdateUser = table.Column<string>(type: "varchar(32)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    Memo = table.Column<string>(type: "varchar(max)", nullable: true),
                    DeptId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeptNo = table.Column<string>(type: "varchar(64)", nullable: true),
                    DeptName = table.Column<string>(nullable: true),
                    SpellCode = table.Column<string>(type: "varchar(32)", nullable: true),
                    WbCode = table.Column<string>(type: "varchar(32)", nullable: true),
                    IsDel = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dept", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    UpdateUser = table.Column<string>(type: "varchar(32)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    Memo = table.Column<string>(type: "varchar(max)", nullable: true),
                    EmpId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmpNo = table.Column<string>(type: "varchar(16)", nullable: true),
                    EmpName = table.Column<string>(type: "varchar(32)", nullable: true),
                    Sex = table.Column<string>(type: "char(1)", nullable: true),
                    IdNo = table.Column<string>(type: "varchar(20)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmpType = table.Column<string>(type: "char(1)", nullable: true),
                    SpellCode = table.Column<string>(type: "varchar(16)", nullable: true),
                    WbCode = table.Column<string>(type: "varchar(16)", nullable: true),
                    IsDel = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "InfusionBadnessEvent",
                columns: table => new
                {
                    UpdateUser = table.Column<string>(type: "VARCHAR(32)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETDATE()"),
                    Memo = table.Column<string>(type: "VARCHAR(MAX)", nullable: true),
                    BnId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InfusionId = table.Column<int>(type: "int", nullable: false),
                    RecorderId = table.Column<string>(type: "varchar(32)", nullable: true),
                    RecorderName = table.Column<string>(type: "varchar(32)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfusionBadnessEvent", x => x.BnId);
                });

            migrationBuilder.CreateTable(
                name: "InfusionPatient",
                columns: table => new
                {
                    UpdateUser = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Memo = table.Column<string>(type: "varchar(64)", nullable: true),
                    InfusionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    SeatId = table.Column<int>(type: "int", nullable: false),
                    QueueNo = table.Column<string>(type: "varchar(64)", nullable: true),
                    ChartNo = table.Column<string>(type: "varchar(16)", nullable: true),
                    VisitNo = table.Column<string>(type: "varchar(16)", nullable: true),
                    PtName = table.Column<string>(type: "varchar(32)", nullable: true),
                    Sex = table.Column<string>(type: "char(1)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime", nullable: true),
                    CardNo = table.Column<string>(type: "varchar(64)", nullable: true),
                    CheckInTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Checkiner = table.Column<string>(type: "varchar(64)", nullable: true),
                    Auditor = table.Column<string>(type: "varchar(64)", nullable: true),
                    AuditTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ConfigTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Configer = table.Column<string>(type: "varchar(64)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Starter = table.Column<string>(type: "varchar(64)", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ender = table.Column<string>(type: "varchar(64)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CancelTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Canceler = table.Column<string>(type: "varchar(64)", nullable: true),
                    DeptNo = table.Column<string>(type: "varchar(16)", nullable: true),
                    Child = table.Column<bool>(type: "bit", nullable: false),
                    Emg = table.Column<bool>(type: "bit", nullable: false),
                    PrescriptionNo = table.Column<string>(type: "varchar(16)", nullable: true),
                    SpecialDrug = table.Column<bool>(type: "bit", nullable: false),
                    DischargeMedication = table.Column<bool>(type: "bit", nullable: false),
                    MedUsageNo = table.Column<string>(type: "varchar(64)", nullable: true),
                    Receipt = table.Column<string>(type: "varchar(64)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfusionPatient", x => x.InfusionId);
                });

            migrationBuilder.CreateTable(
                name: "InfusionPnDetail",
                columns: table => new
                {
                    UpdateUser = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Memo = table.Column<string>(type: "varchar(max)", nullable: true),
                    IpdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InfusionId = table.Column<int>(type: "int", nullable: true),
                    PrescriptionNo = table.Column<string>(type: "varchar(32)", nullable: false),
                    SeqNo = table.Column<string>(type: "varchar(32)", nullable: false),
                    DrugCode = table.Column<string>(type: "varchar(32)", nullable: false),
                    DrugName = table.Column<string>(type: "varchar(32)", nullable: false),
                    DrugStandard = table.Column<string>(type: "varchar(32)", nullable: false),
                    DrugDepartmentName = table.Column<string>(type: "varchar(32)", nullable: false),
                    DrugNum = table.Column<int>(type: "int", nullable: false),
                    DrugDose = table.Column<int>(type: "int", nullable: false),
                    DrugDoseUnit = table.Column<string>(type: "varchar(32)", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    RecordStatus = table.Column<int>(type: "int", nullable: false),
                    DoctorNo = table.Column<string>(type: "varchar(32)", nullable: true),
                    PrescriptionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    FrequencyNo = table.Column<string>(type: "varchar(32)", nullable: true),
                    UsageNo = table.Column<string>(type: "varchar(32)", nullable: true),
                    KeepTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    TotQty = table.Column<int>(type: "int", nullable: true),
                    ExecQty = table.Column<int>(type: "int", nullable: true),
                    TotComposeQty = table.Column<int>(type: "int", nullable: true),
                    Advise = table.Column<string>(type: "varchar(32)", nullable: true),
                    IsCharge = table.Column<bool>(type: "bit", nullable: true),
                    ChargeNo = table.Column<int>(type: "int", nullable: true),
                    IsSkinTest = table.Column<bool>(type: "bit", nullable: true),
                    SkinTestResult = table.Column<string>(type: "varchar(128)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfusionPnDetail", x => x.IpdId);
                });

            migrationBuilder.CreateTable(
                name: "InfusionPrintSet",
                columns: table => new
                {
                    UpdateUser = table.Column<string>(type: "varchar(32)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    Memo = table.Column<string>(type: "varchar(max)", nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrintSetCode = table.Column<string>(type: "varchar(128)", nullable: false),
                    PrintSetName = table.Column<string>(type: "varchar(128)", nullable: false),
                    IsDel = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfusionPrintSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InfusionRoom",
                columns: table => new
                {
                    UpdateUser = table.Column<string>(type: "varchar(32)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    Memo = table.Column<string>(type: "varchar(max)", nullable: true),
                    RoomId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomCode = table.Column<string>(type: "varchar(64)", nullable: true),
                    RoomName = table.Column<string>(type: "varchar(64)", nullable: true),
                    PrescriptionDays = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Mode = table.Column<bool>(type: "bit", nullable: true),
                    IsDel = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfusionRoom", x => x.RoomId);
                });

            migrationBuilder.CreateTable(
                name: "InfusionSeat",
                columns: table => new
                {
                    UpdateUser = table.Column<string>(type: "VARCHAR(32)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    Memo = table.Column<string>(type: "VARCHAR(MAX)", nullable: true),
                    SeatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InfusionId = table.Column<int>(type: "int", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    Plus = table.Column<short>(type: "smallint", nullable: true),
                    Used = table.Column<short>(type: "smallint", nullable: true),
                    Valid = table.Column<short>(type: "smallint", nullable: true),
                    Child = table.Column<short>(type: "smallint", nullable: true),
                    Special = table.Column<short>(type: "smallint", nullable: true),
                    IsDel = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfusionSeat", x => x.SeatId);
                });

            migrationBuilder.CreateTable(
                name: "InfusionSpecialDrug",
                columns: table => new
                {
                    UpdateUser = table.Column<string>(type: "varchar(32)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    Memo = table.Column<string>(type: "varchar(max)", nullable: true),
                    IsdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OriginPlace = table.Column<string>(type: "varchar(64)", nullable: true),
                    DrugCode = table.Column<string>(type: "varchar(16)", nullable: true),
                    DrugName = table.Column<string>(type: "varchar(64)", nullable: true),
                    DrugSpec = table.Column<string>(type: "varchar(64)", nullable: true),
                    Color = table.Column<string>(type: "varchar(64)", nullable: true),
                    IsDel = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfusionSpecialDrug", x => x.IsdId);
                });

            migrationBuilder.CreateTable(
                name: "InfusionDept",
                columns: table => new
                {
                    UpdateUser = table.Column<string>(type: "varchar(32)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    Memo = table.Column<string>(type: "varchar(max)", nullable: true),
                    RdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    DeptNo = table.Column<string>(type: "varchar(32)", nullable: true),
                    DeptName = table.Column<string>(type: "varchar(64)", nullable: true),
                    IsDel = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfusionDept", x => x.RdId);
                    table.ForeignKey(
                        name: "FK_InfusionDept_InfusionRoom_RoomId",
                        column: x => x.RoomId,
                        principalTable: "InfusionRoom",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InfusionUsage",
                columns: table => new
                {
                    UpdateUser = table.Column<string>(type: "varchar(32)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    Memo = table.Column<string>(type: "varchar(max)", nullable: true),
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    UsageNo = table.Column<string>(type: "varchar(16)", nullable: true),
                    UsageName = table.Column<string>(type: "varchar(32)", nullable: true),
                    IsDel = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfusionUsage", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_InfusionUsage_InfusionRoom_RoomId",
                        column: x => x.RoomId,
                        principalTable: "InfusionRoom",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pharmacy",
                columns: table => new
                {
                    UpdateUser = table.Column<string>(type: "varchar(32)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    Memo = table.Column<string>(type: "varchar(max)", nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    PharmacyCode = table.Column<string>(type: "varchar(16)", nullable: false),
                    PharmacyName = table.Column<string>(type: "varchar(64)", nullable: false),
                    Isdel = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pharmacy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pharmacy_InfusionRoom_RoomId",
                        column: x => x.RoomId,
                        principalTable: "InfusionRoom",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InfusionDept_RoomId",
                table: "InfusionDept",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_InfusionUsage_RoomId",
                table: "InfusionUsage",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Pharmacy_RoomId",
                table: "Pharmacy",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dept");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "InfusionBadnessEvent");

            migrationBuilder.DropTable(
                name: "InfusionDept");

            migrationBuilder.DropTable(
                name: "InfusionPatient");

            migrationBuilder.DropTable(
                name: "InfusionPnDetail");

            migrationBuilder.DropTable(
                name: "InfusionPrintSet");

            migrationBuilder.DropTable(
                name: "InfusionSeat");

            migrationBuilder.DropTable(
                name: "InfusionSpecialDrug");

            migrationBuilder.DropTable(
                name: "InfusionUsage");

            migrationBuilder.DropTable(
                name: "Pharmacy");

            migrationBuilder.DropTable(
                name: "InfusionRoom");
        }
    }
}
