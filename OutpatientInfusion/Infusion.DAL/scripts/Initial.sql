IF OBJECT_ID(N'[_InfusionMigrationHistory]') IS NULL
BEGIN
    CREATE TABLE [_InfusionMigrationHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK__InfusionMigrationHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Dept] (
    [UpdateUser] varchar(32) NOT NULL,
    [UpdateTime] datetime NOT NULL DEFAULT (GETDATE()),
    [Memo] varchar(max) NULL,
    [DeptId] int NOT NULL IDENTITY,
    [DeptNo] varchar(64) NULL,
    [DeptName] nvarchar(max) NULL,
    [SpellCode] varchar(32) NULL,
    [WbCode] varchar(32) NULL,
    [IsDel] bit NOT NULL DEFAULT 0,
    CONSTRAINT [PK_Dept] PRIMARY KEY ([DeptId])
);

GO

CREATE TABLE [Employee] (
    [UpdateUser] varchar(32) NOT NULL,
    [UpdateTime] datetime NOT NULL DEFAULT (GETDATE()),
    [Memo] varchar(max) NULL,
    [EmpId] int NOT NULL IDENTITY,
    [EmpNo] varchar(16) NULL,
    [EmpName] varchar(32) NULL,
    [Sex] char(1) NULL,
    [IdNo] varchar(20) NULL,
    [Birthday] datetime NULL,
    [EmpType] char(1) NULL,
    [SpellCode] varchar(16) NULL,
    [WbCode] varchar(16) NULL,
    [IsDel] bit NOT NULL DEFAULT 0,
    CONSTRAINT [PK_Employee] PRIMARY KEY ([EmpId])
);

GO

CREATE TABLE [InfusionBadnessEvent] (
    [UpdateUser] VARCHAR(32) NOT NULL,
    [UpdateTime] DATETIME NOT NULL DEFAULT (GETDATE()),
    [Memo] VARCHAR(MAX) NULL,
    [BnId] int NOT NULL IDENTITY,
    [InfusionId] int NOT NULL,
    [RecorderId] varchar(32) NULL,
    [RecorderName] varchar(32) NULL,
    CONSTRAINT [PK_InfusionBadnessEvent] PRIMARY KEY ([BnId])
);

GO

CREATE TABLE [InfusionPatient] (
    [UpdateUser] nvarchar(max) NULL,
    [UpdateTime] datetime2 NOT NULL,
    [Memo] varchar(64) NULL,
    [InfusionId] int NOT NULL IDENTITY,
    [RoomId] int NOT NULL,
    [SeatId] int NOT NULL,
    [QueueNo] varchar(64) NULL,
    [ChartNo] varchar(16) NULL,
    [VisitNo] varchar(16) NULL,
    [PtName] varchar(32) NULL,
    [Sex] char(1) NULL,
    [Age] int NOT NULL,
    [BirthDay] datetime NULL,
    [CardNo] varchar(64) NULL,
    [CheckInTime] datetime NULL,
    [Checkiner] varchar(64) NULL,
    [Auditor] varchar(64) NULL,
    [AuditTime] datetime NULL,
    [ConfigTime] datetime NULL,
    [Configer] varchar(64) NULL,
    [StartTime] datetime NULL,
    [Starter] varchar(64) NULL,
    [EndTime] datetime NULL,
    [Ender] varchar(64) NULL,
    [Status] bit NOT NULL,
    [CancelTime] datetime NULL,
    [Canceler] varchar(64) NULL,
    [DeptNo] varchar(16) NULL,
    [Child] bit NOT NULL,
    [Emg] bit NOT NULL,
    [PrescriptionNo] varchar(16) NULL,
    [SpecialDrug] bit NOT NULL,
    [DischargeMedication] bit NOT NULL,
    [MedUsageNo] varchar(64) NULL,
    [Receipt] varchar(64) NULL,
    CONSTRAINT [PK_InfusionPatient] PRIMARY KEY ([InfusionId])
);

GO

CREATE TABLE [InfusionPnDetail] (
    [UpdateUser] nvarchar(max) NULL,
    [UpdateTime] datetime2 NOT NULL,
    [Memo] varchar(max) NULL,
    [IpdId] int NOT NULL IDENTITY,
    [InfusionId] int NULL,
    [PrescriptionNo] varchar(32) NOT NULL,
    [SeqNo] varchar(32) NOT NULL,
    [DrugCode] varchar(32) NOT NULL,
    [DrugName] varchar(32) NOT NULL,
    [DrugStandard] varchar(32) NOT NULL,
    [DrugDepartmentName] varchar(32) NOT NULL,
    [DrugNum] int NOT NULL,
    [DrugDose] int NOT NULL,
    [DrugDoseUnit] varchar(32) NULL,
    [GroupId] int NOT NULL,
    [RecordStatus] int NOT NULL,
    [DoctorNo] varchar(32) NULL,
    [PrescriptionDate] datetime NULL,
    [FrequencyNo] varchar(32) NULL,
    [UsageNo] varchar(32) NULL,
    [KeepTime] datetime NULL,
    [TotQty] int NULL,
    [ExecQty] int NULL,
    [TotComposeQty] int NULL,
    [Advise] varchar(32) NULL,
    [IsCharge] bit NULL,
    [ChargeNo] int NULL,
    [IsSkinTest] bit NULL,
    [SkinTestResult] varchar(128) NULL,
    CONSTRAINT [PK_InfusionPnDetail] PRIMARY KEY ([IpdId])
);

GO

CREATE TABLE [InfusionPrintSet] (
    [UpdateUser] varchar(32) NOT NULL,
    [UpdateTime] datetime NOT NULL DEFAULT (GETDATE()),
    [Memo] varchar(max) NULL,
    [Id] int NOT NULL IDENTITY,
    [PrintSetCode] varchar(128) NOT NULL,
    [PrintSetName] varchar(128) NOT NULL,
    [IsDel] bit NOT NULL DEFAULT 0,
    CONSTRAINT [PK_InfusionPrintSet] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [InfusionRoom] (
    [UpdateUser] varchar(32) NOT NULL,
    [UpdateTime] datetime NOT NULL DEFAULT (GETDATE()),
    [Memo] varchar(max) NULL,
    [RoomId] int NOT NULL IDENTITY,
    [RoomCode] varchar(64) NULL,
    [RoomName] varchar(64) NULL,
    [PrescriptionDays] decimal(10,2) NULL,
    [Mode] bit NULL,
    [IsDel] bit NOT NULL DEFAULT 0,
    CONSTRAINT [PK_InfusionRoom] PRIMARY KEY ([RoomId])
);

GO

CREATE TABLE [InfusionSeat] (
    [UpdateUser] VARCHAR(32) NOT NULL,
    [UpdateTime] datetime NOT NULL DEFAULT (GETDATE()),
    [Memo] VARCHAR(MAX) NULL,
    [SeatId] int NOT NULL IDENTITY,
    [InfusionId] int NULL,
    [RoomId] int NULL,
    [Plus] smallint NULL,
    [Used] smallint NULL,
    [Valid] smallint NULL,
    [Child] smallint NULL,
    [Special] smallint NULL,
    [IsDel] bit NOT NULL,
    CONSTRAINT [PK_InfusionSeat] PRIMARY KEY ([SeatId])
);

GO

CREATE TABLE [InfusionSpecialDrug] (
    [UpdateUser] varchar(32) NOT NULL,
    [UpdateTime] datetime NOT NULL DEFAULT (GETDATE()),
    [Memo] varchar(max) NULL,
    [IsdId] int NOT NULL IDENTITY,
    [OriginPlace] varchar(64) NULL,
    [DrugCode] varchar(16) NULL,
    [DrugName] varchar(64) NULL,
    [DrugSpec] varchar(64) NULL,
    [Color] varchar(64) NULL,
    [IsDel] bit NOT NULL DEFAULT 0,
    CONSTRAINT [PK_InfusionSpecialDrug] PRIMARY KEY ([IsdId])
);

GO

CREATE TABLE [InfusionDept] (
    [UpdateUser] varchar(32) NOT NULL,
    [UpdateTime] datetime NOT NULL DEFAULT (GETDATE()),
    [Memo] varchar(max) NULL,
    [RdId] int NOT NULL IDENTITY,
    [RoomId] int NOT NULL,
    [DeptNo] varchar(32) NULL,
    [DeptName] varchar(64) NULL,
    [IsDel] bit NOT NULL DEFAULT 0,
    CONSTRAINT [PK_InfusionDept] PRIMARY KEY ([RdId]),
    CONSTRAINT [FK_InfusionDept_InfusionRoom_RoomId] FOREIGN KEY ([RoomId]) REFERENCES [InfusionRoom] ([RoomId]) ON DELETE CASCADE
);

GO

CREATE TABLE [InfusionUsage] (
    [UpdateUser] varchar(32) NOT NULL,
    [UpdateTime] datetime NOT NULL DEFAULT (GETDATE()),
    [Memo] varchar(max) NULL,
    [ItemId] int NOT NULL IDENTITY,
    [RoomId] int NOT NULL,
    [UsageNo] varchar(16) NULL,
    [UsageName] varchar(32) NULL,
    [IsDel] bit NOT NULL DEFAULT 0,
    CONSTRAINT [PK_InfusionUsage] PRIMARY KEY ([ItemId]),
    CONSTRAINT [FK_InfusionUsage_InfusionRoom_RoomId] FOREIGN KEY ([RoomId]) REFERENCES [InfusionRoom] ([RoomId]) ON DELETE CASCADE
);

GO

CREATE TABLE [Pharmacy] (
    [UpdateUser] varchar(32) NOT NULL,
    [UpdateTime] datetime NOT NULL DEFAULT (GETDATE()),
    [Memo] varchar(max) NULL,
    [Id] int NOT NULL IDENTITY,
    [RoomId] int NOT NULL,
    [PharmacyCode] varchar(16) NOT NULL,
    [PharmacyName] varchar(64) NOT NULL,
    [Isdel] bit NOT NULL DEFAULT 0,
    CONSTRAINT [PK_Pharmacy] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Pharmacy_InfusionRoom_RoomId] FOREIGN KEY ([RoomId]) REFERENCES [InfusionRoom] ([RoomId]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_InfusionDept_RoomId] ON [InfusionDept] ([RoomId]);

GO

CREATE INDEX [IX_InfusionUsage_RoomId] ON [InfusionUsage] ([RoomId]);

GO

CREATE INDEX [IX_Pharmacy_RoomId] ON [Pharmacy] ([RoomId]);

GO

INSERT INTO [_InfusionMigrationHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180702135732_InitialDb', N'2.1.1-rtm-30846');

GO

