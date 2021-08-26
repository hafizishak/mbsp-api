IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200221011658_InitialCreate')
BEGIN
    CREATE TABLE [Department] (
        [Id] int NOT NULL IDENTITY,
        [DepartmentCode] nvarchar(max) NULL,
        [DepartmentDesc] nvarchar(max) NULL,
        [Deleted] bit NOT NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        CONSTRAINT [PK_Department] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200221011658_InitialCreate')
BEGIN
    CREATE TABLE [Ticket] (
        [Id] int NOT NULL IDENTITY,
        [SerialNo] nvarchar(max) NULL,
        [IafType] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [Status] nvarchar(max) NULL,
        [Deleted] bit NOT NULL,
        [Sequence] int NOT NULL,
        [RoutingType] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        CONSTRAINT [PK_Ticket] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200221011658_InitialCreate')
BEGIN
    CREATE TABLE [TicketApprover] (
        [Id] int NOT NULL IDENTITY,
        [DivisionCode] nvarchar(max) NULL,
        [DivisionRole] nvarchar(max) NULL,
        [Type] nvarchar(max) NULL,
        [Deleted] bit NOT NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        CONSTRAINT [PK_TicketApprover] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200221011658_InitialCreate')
BEGIN
    CREATE TABLE [TicketRouting] (
        [Id] int NOT NULL IDENTITY,
        [RoutingCode] nvarchar(max) NULL,
        [RoutingDesc] nvarchar(max) NULL,
        [RoutingType] nvarchar(max) NULL,
        [RoutingSequence] int NOT NULL,
        [DepartmentCode] nvarchar(max) NULL,
        [RoleCode] nvarchar(max) NULL,
        [Status] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        [LastApprover] bit NOT NULL,
        CONSTRAINT [PK_TicketRouting] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200221011658_InitialCreate')
BEGIN
    CREATE TABLE [Users] (
        [Id] int NOT NULL IDENTITY,
        [Username] nvarchar(max) NULL,
        [PasswordHash] varbinary(max) NULL,
        [PasswordSalt] varbinary(max) NULL,
        [Email] nvarchar(max) NULL,
        [Status] nvarchar(max) NULL,
        [Created] datetime2 NOT NULL,
        [UserCode] nvarchar(max) NULL,
        [UserGroup] nvarchar(max) NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200221011658_InitialCreate')
BEGIN
    CREATE TABLE [values] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_values] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200221011658_InitialCreate')
BEGIN
    CREATE TABLE [Attachment] (
        [Id] int NOT NULL IDENTITY,
        [FileName] nvarchar(max) NULL,
        [FileType] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [Deleted] bit NOT NULL,
        [TicketId] int NOT NULL,
        CONSTRAINT [PK_Attachment] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Attachment_Ticket_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [Ticket] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200221011658_InitialCreate')
BEGIN
    CREATE TABLE [TicketApproval] (
        [Id] int NOT NULL IDENTITY,
        [TicketId] int NOT NULL,
        [Role] nvarchar(max) NULL,
        [DepartmentCode] nvarchar(max) NULL,
        [Approved] bit NOT NULL,
        [Remark] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        CONSTRAINT [PK_TicketApproval] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_TicketApproval_Ticket_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [Ticket] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200221011658_InitialCreate')
BEGIN
    CREATE TABLE [TicketDetail] (
        [Id] int NOT NULL IDENTITY,
        [TicketId] int NOT NULL,
        [SerialNo] nvarchar(max) NULL,
        [PartNo] nvarchar(max) NULL,
        [PartDesc] nvarchar(max) NULL,
        [LotNo] nvarchar(max) NULL,
        [ActualQty] real NOT NULL,
        [AdjustQty] real NOT NULL,
        [LotProcessCode] nvarchar(max) NULL,
        [UnitCost] real NOT NULL,
        [Amount] real NOT NULL,
        [Reason] nvarchar(max) NULL,
        [Delta] real NOT NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [Deleted] bit NOT NULL,
        CONSTRAINT [PK_TicketDetail] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_TicketDetail_Ticket_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [Ticket] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200221011658_InitialCreate')
BEGIN
    CREATE TABLE [Signature] (
        [Id] int NOT NULL IDENTITY,
        [UserId] int NOT NULL,
        [Sign] nvarchar(max) NULL,
        [Type] nvarchar(max) NULL,
        [Deleted] bit NOT NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        CONSTRAINT [PK_Signature] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Signature_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200221011658_InitialCreate')
BEGIN
    CREATE TABLE [UserDepartment] (
        [Id] int NOT NULL IDENTITY,
        [UserId] int NOT NULL,
        [DepartmentCode] nvarchar(max) NULL,
        [Role] nvarchar(max) NULL,
        [Deleted] bit NOT NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        CONSTRAINT [PK_UserDepartment] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_UserDepartment_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200221011658_InitialCreate')
BEGIN
    CREATE INDEX [IX_Attachment_TicketId] ON [Attachment] ([TicketId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200221011658_InitialCreate')
BEGIN
    CREATE INDEX [IX_Signature_UserId] ON [Signature] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200221011658_InitialCreate')
BEGIN
    CREATE INDEX [IX_TicketApproval_TicketId] ON [TicketApproval] ([TicketId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200221011658_InitialCreate')
BEGIN
    CREATE INDEX [IX_TicketDetail_TicketId] ON [TicketDetail] ([TicketId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200221011658_InitialCreate')
BEGIN
    CREATE INDEX [IX_UserDepartment_UserId] ON [UserDepartment] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200221011658_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200221011658_InitialCreate', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200225012832_Activity')
BEGIN
    CREATE TABLE [Activity] (
        [Id] int NOT NULL IDENTITY,
        [Module] nvarchar(max) NULL,
        [Action] nvarchar(max) NULL,
        [Remark] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        CONSTRAINT [PK_Activity] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200225012832_Activity')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200225012832_Activity', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200225013325_ActivitySerialNo')
BEGIN
    ALTER TABLE [Activity] ADD [SerialNo] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200225013325_ActivitySerialNo')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200225013325_ActivitySerialNo', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200225065544_TicketEmailSend')
BEGIN
    ALTER TABLE [Ticket] ADD [EmailSend] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200225065544_TicketEmailSend')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200225065544_TicketEmailSend', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200225065741_TicketEmailStatus')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Ticket]') AND [c].[name] = N'EmailSend');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Ticket] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Ticket] DROP COLUMN [EmailSend];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200225065741_TicketEmailStatus')
BEGIN
    ALTER TABLE [Ticket] ADD [EmailStatus] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200225065741_TicketEmailStatus')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200225065741_TicketEmailStatus', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226064955_VCB')
BEGIN
    CREATE TABLE [VCBAccessCode] (
        [Id] int NOT NULL IDENTITY,
        [AccessCode] nvarchar(max) NULL,
        [AccessCodeDesc] nvarchar(max) NULL,
        [Deleted] bit NOT NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        CONSTRAINT [PK_VCBAccessCode] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226064955_VCB')
BEGIN
    CREATE TABLE [VCBGroup] (
        [Id] int NOT NULL IDENTITY,
        [GroupCode] nvarchar(max) NULL,
        [GroupDesc] nvarchar(max) NULL,
        [Deleted] bit NOT NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        CONSTRAINT [PK_VCBGroup] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226064955_VCB')
BEGIN
    CREATE TABLE [VCBRole] (
        [Id] int NOT NULL IDENTITY,
        [RoleCode] nvarchar(max) NULL,
        [RoleDesc] nvarchar(max) NULL,
        [Deleted] bit NOT NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        CONSTRAINT [PK_VCBRole] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200226064955_VCB')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200226064955_VCB', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    CREATE TABLE [Report] (
        [Id] int NOT NULL IDENTITY,
        [ReportNumber] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [IssuedTo] nvarchar(max) NULL,
        [IssuedOn] nvarchar(max) NULL,
        [Remarks] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        CONSTRAINT [PK_Report] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    CREATE TABLE [Approval] (
        [Id] int NOT NULL IDENTITY,
        [Approver] nvarchar(max) NULL,
        [Status] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        [ReportId] int NOT NULL,
        CONSTRAINT [PK_Approval] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Approval_Report_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Report] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    CREATE TABLE [ContainmentActions] (
        [Id] int NOT NULL IDENTITY,
        [Type] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [Details] nvarchar(max) NULL,
        [PIC] nvarchar(max) NULL,
        [Date] datetime2 NOT NULL,
        [Status] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        [ReportId] int NOT NULL,
        CONSTRAINT [PK_ContainmentActions] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ContainmentActions_Report_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Report] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    CREATE TABLE [General] (
        [Id] int NOT NULL IDENTITY,
        [CustomerPrtNo] int NOT NULL,
        [CustomerName] nvarchar(max) NULL,
        [CMSite] nvarchar(max) NULL,
        [CmName] nvarchar(max) NULL,
        [ProductName] nvarchar(max) NULL,
        [LotNo] nvarchar(max) NULL,
        [Defect] nvarchar(max) NULL,
        [ManufacturingDateCode] nvarchar(max) NULL,
        [RejectInspectedLotQuantity] nvarchar(max) NULL,
        [ProblemDetectedArea] nvarchar(max) NULL,
        [BroadcomNotificationDate] datetime2 NOT NULL,
        [NoOfSampleReturned] int NOT NULL,
        [SampleReceivedDate] datetime2 NOT NULL,
        [PrtResponseDate] datetime2 NOT NULL,
        [ReportId] int NOT NULL,
        CONSTRAINT [PK_General] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_General_Report_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Report] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    CREATE TABLE [PreventiveActions] (
        [Id] int NOT NULL IDENTITY,
        [Type] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [Details] nvarchar(max) NULL,
        [PIC] nvarchar(max) NULL,
        [Date] datetime2 NOT NULL,
        [Status] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        [ReportId] int NOT NULL,
        CONSTRAINT [PK_PreventiveActions] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_PreventiveActions_Report_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Report] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    CREATE TABLE [ProblemDescription] (
        [Id] int NOT NULL IDENTITY,
        [Type] nvarchar(max) NULL,
        [ProblemStatement] nvarchar(max) NULL,
        [FAResults] nvarchar(max) NULL,
        [FailureDetailed] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        [ReportId] int NOT NULL,
        CONSTRAINT [PK_ProblemDescription] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ProblemDescription_Report_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Report] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    CREATE TABLE [ReoccurrencePreventions] (
        [Id] int NOT NULL IDENTITY,
        [Type] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [Details] nvarchar(max) NULL,
        [PIC] nvarchar(max) NULL,
        [Date] datetime2 NOT NULL,
        [Status] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        [ReportId] int NOT NULL,
        CONSTRAINT [PK_ReoccurrencePreventions] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ReoccurrencePreventions_Report_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Report] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    CREATE TABLE [TeamApproach] (
        [Id] int NOT NULL IDENTITY,
        [Type] nvarchar(max) NULL,
        [UserCode] nvarchar(max) NULL,
        [JobTitle] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        [ReportId] int NOT NULL,
        CONSTRAINT [PK_TeamApproach] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_TeamApproach_Report_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Report] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    CREATE TABLE [Verification] (
        [Id] int NOT NULL IDENTITY,
        [Type] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [Details] nvarchar(max) NULL,
        [PIC] nvarchar(max) NULL,
        [Date] datetime2 NOT NULL,
        [Status] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        [ReportId] int NOT NULL,
        CONSTRAINT [PK_Verification] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Verification_Report_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Report] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    CREATE INDEX [IX_Approval_ReportId] ON [Approval] ([ReportId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    CREATE INDEX [IX_ContainmentActions_ReportId] ON [ContainmentActions] ([ReportId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    CREATE INDEX [IX_General_ReportId] ON [General] ([ReportId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    CREATE INDEX [IX_PreventiveActions_ReportId] ON [PreventiveActions] ([ReportId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    CREATE INDEX [IX_ProblemDescription_ReportId] ON [ProblemDescription] ([ReportId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    CREATE INDEX [IX_ReoccurrencePreventions_ReportId] ON [ReoccurrencePreventions] ([ReportId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    CREATE INDEX [IX_TeamApproach_ReportId] ON [TeamApproach] ([ReportId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    CREATE INDEX [IX_Verification_ReportId] ON [Verification] ([ReportId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227061808_Report8D')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200227061808_Report8D', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227072436_EditGeneral')
BEGIN
    DROP TABLE [General];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227072436_EditGeneral')
BEGIN
    CREATE TABLE [GeneralData] (
        [Id] int NOT NULL IDENTITY,
        [CustomerPrtNo] int NOT NULL,
        [CustomerName] nvarchar(max) NULL,
        [CMSite] nvarchar(max) NULL,
        [CmName] nvarchar(max) NULL,
        [ProductName] nvarchar(max) NULL,
        [LotNo] nvarchar(max) NULL,
        [Defect] nvarchar(max) NULL,
        [ManufacturingDateCode] nvarchar(max) NULL,
        [RejectInspectedLotQuantity] nvarchar(max) NULL,
        [ProblemDetectedArea] nvarchar(max) NULL,
        [BroadcomNotificationDate] datetime2 NOT NULL,
        [NoOfSampleReturned] int NOT NULL,
        [SampleReceivedDate] datetime2 NOT NULL,
        [PrtResponseDate] datetime2 NOT NULL,
        [ReportId] int NOT NULL,
        CONSTRAINT [PK_GeneralData] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_GeneralData_Report_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Report] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227072436_EditGeneral')
BEGIN
    CREATE INDEX [IX_GeneralData_ReportId] ON [GeneralData] ([ReportId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227072436_EditGeneral')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200227072436_EditGeneral', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227082209_EditReport')
BEGIN
    ALTER TABLE [Report] ADD [Deleted] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227082209_EditReport')
BEGIN
    ALTER TABLE [Report] ADD [Status] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227082209_EditReport')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200227082209_EditReport', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227082317_EditReportAddTitle')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200227082317_EditReportAddTitle', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227084901_EditReportAddModels')
BEGIN
    ALTER TABLE [Report] ADD [ApprovalBy] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227084901_EditReportAddModels')
BEGIN
    ALTER TABLE [Report] ADD [IssueDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227084901_EditReportAddModels')
BEGIN
    ALTER TABLE [Report] ADD [PRTNo] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227084901_EditReportAddModels')
BEGIN
    ALTER TABLE [Report] ADD [PreparedBy] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227084901_EditReportAddModels')
BEGIN
    ALTER TABLE [Report] ADD [ReviewedBy] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227084901_EditReportAddModels')
BEGIN
    ALTER TABLE [Report] ADD [Revision] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227084901_EditReportAddModels')
BEGIN
    ALTER TABLE [Report] ADD [RevisionDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227084901_EditReportAddModels')
BEGIN
    ALTER TABLE [Report] ADD [Title] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200227084901_EditReportAddModels')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200227084901_EditReportAddModels', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200228020528_EditGeneralData')
BEGIN
    ALTER TABLE [GeneralData] ADD [CreatedBy] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200228020528_EditGeneralData')
BEGIN
    ALTER TABLE [GeneralData] ADD [CreatedOn] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200228020528_EditGeneralData')
BEGIN
    ALTER TABLE [GeneralData] ADD [Status] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200228020528_EditGeneralData')
BEGIN
    ALTER TABLE [GeneralData] ADD [UpdatedBy] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200228020528_EditGeneralData')
BEGIN
    ALTER TABLE [GeneralData] ADD [UpdatedOn] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200228020528_EditGeneralData')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200228020528_EditGeneralData', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200228095016_EditTicketApprovalAddStatus')
BEGIN
    ALTER TABLE [TicketApproval] ADD [Status] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200228095016_EditTicketApprovalAddStatus')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200228095016_EditTicketApprovalAddStatus', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200302095222_GroupAndRole')
BEGIN
    CREATE TABLE [GroupRole] (
        [Id] int NOT NULL IDENTITY,
        [GroupCode] nvarchar(max) NULL,
        [RoleCode] nvarchar(max) NULL,
        [Deleted] bit NOT NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] nvarchar(max) NULL,
        CONSTRAINT [PK_GroupRole] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200302095222_GroupAndRole')
BEGIN
    CREATE TABLE [RoleAccessCode] (
        [Id] int NOT NULL IDENTITY,
        [GroupCode] nvarchar(max) NULL,
        [RoleCode] nvarchar(max) NULL,
        [Deleted] bit NOT NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] nvarchar(max) NULL,
        CONSTRAINT [PK_RoleAccessCode] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200302095222_GroupAndRole')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200302095222_GroupAndRole', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200302095624_EditGroupAndRole')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RoleAccessCode]') AND [c].[name] = N'GroupCode');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [RoleAccessCode] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [RoleAccessCode] DROP COLUMN [GroupCode];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200302095624_EditGroupAndRole')
BEGIN
    ALTER TABLE [RoleAccessCode] ADD [AccessCode] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200302095624_EditGroupAndRole')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200302095624_EditGroupAndRole', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200306111020_EditReportAddArea')
BEGIN
    ALTER TABLE [Report] ADD [Area] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200306111020_EditReportAddArea')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200306111020_EditReportAddArea', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200309055946_ReportReviewer')
BEGIN
    CREATE TABLE [ReportReviewer] (
        [Id] int NOT NULL IDENTITY,
        [Reviewer] nvarchar(max) NULL,
        [Status] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        [ReportId] int NOT NULL,
        CONSTRAINT [PK_ReportReviewer] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ReportReviewer_Report_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Report] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200309055946_ReportReviewer')
BEGIN
    CREATE INDEX [IX_ReportReviewer_ReportId] ON [ReportReviewer] ([ReportId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200309055946_ReportReviewer')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200309055946_ReportReviewer', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200310014930_AttachmentForReport')
BEGIN
    CREATE TABLE [ItemAttachment] (
        [Id] int NOT NULL IDENTITY,
        [ItemId] int NOT NULL,
        [FileName] nvarchar(max) NULL,
        [FileType] nvarchar(max) NULL,
        [ItemType] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [Deleted] bit NOT NULL,
        [ReportId] int NOT NULL,
        CONSTRAINT [PK_ItemAttachment] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ItemAttachment_Report_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Report] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200310014930_AttachmentForReport')
BEGIN
    CREATE TABLE [ReportAttachment] (
        [Id] int NOT NULL IDENTITY,
        [FileName] nvarchar(max) NULL,
        [FileType] nvarchar(max) NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [Deleted] bit NOT NULL,
        [ReportId] int NOT NULL,
        CONSTRAINT [PK_ReportAttachment] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ReportAttachment_Report_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Report] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200310014930_AttachmentForReport')
BEGIN
    CREATE INDEX [IX_ItemAttachment_ReportId] ON [ItemAttachment] ([ReportId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200310014930_AttachmentForReport')
BEGIN
    CREATE INDEX [IX_ReportAttachment_ReportId] ON [ReportAttachment] ([ReportId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200310014930_AttachmentForReport')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200310014930_AttachmentForReport', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200310054343_ReportApprovalReviewerEdit')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ReportReviewer]') AND [c].[name] = N'Status');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [ReportReviewer] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [ReportReviewer] ALTER COLUMN [Status] bit NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200310054343_ReportApprovalReviewerEdit')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Approval]') AND [c].[name] = N'Status');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Approval] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Approval] ALTER COLUMN [Status] bit NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200310054343_ReportApprovalReviewerEdit')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200310054343_ReportApprovalReviewerEdit', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200311081835_ChangeReportItemStatusType')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Verification]') AND [c].[name] = N'Status');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Verification] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Verification] ALTER COLUMN [Status] bit NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200311081835_ChangeReportItemStatusType')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ReoccurrencePreventions]') AND [c].[name] = N'Status');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [ReoccurrencePreventions] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [ReoccurrencePreventions] ALTER COLUMN [Status] bit NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200311081835_ChangeReportItemStatusType')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PreventiveActions]') AND [c].[name] = N'Status');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [PreventiveActions] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [PreventiveActions] ALTER COLUMN [Status] bit NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200311081835_ChangeReportItemStatusType')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ContainmentActions]') AND [c].[name] = N'Status');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [ContainmentActions] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [ContainmentActions] ALTER COLUMN [Status] bit NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200311081835_ChangeReportItemStatusType')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200311081835_ChangeReportItemStatusType', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200311082126_ChangeReportItemStatusTypeAgain')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Verification]') AND [c].[name] = N'Status');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Verification] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [Verification] ALTER COLUMN [Status] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200311082126_ChangeReportItemStatusTypeAgain')
BEGIN
    DECLARE @var9 sysname;
    SELECT @var9 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ReoccurrencePreventions]') AND [c].[name] = N'Status');
    IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [ReoccurrencePreventions] DROP CONSTRAINT [' + @var9 + '];');
    ALTER TABLE [ReoccurrencePreventions] ALTER COLUMN [Status] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200311082126_ChangeReportItemStatusTypeAgain')
BEGIN
    DECLARE @var10 sysname;
    SELECT @var10 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PreventiveActions]') AND [c].[name] = N'Status');
    IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [PreventiveActions] DROP CONSTRAINT [' + @var10 + '];');
    ALTER TABLE [PreventiveActions] ALTER COLUMN [Status] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200311082126_ChangeReportItemStatusTypeAgain')
BEGIN
    DECLARE @var11 sysname;
    SELECT @var11 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ContainmentActions]') AND [c].[name] = N'Status');
    IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [ContainmentActions] DROP CONSTRAINT [' + @var11 + '];');
    ALTER TABLE [ContainmentActions] ALTER COLUMN [Status] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200311082126_ChangeReportItemStatusTypeAgain')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200311082126_ChangeReportItemStatusTypeAgain', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312081224_ReportAttachmentRevision')
BEGIN
    ALTER TABLE [ReportAttachment] ADD [Revision] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312081224_ReportAttachmentRevision')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200312081224_ReportAttachmentRevision', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200316021748_UpdateTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200316021748_UpdateTable', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200326035531_UpdateDateFormat')
BEGIN
    DECLARE @var12 sysname;
    SELECT @var12 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RoleAccessCode]') AND [c].[name] = N'UpdatedOn');
    IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [RoleAccessCode] DROP CONSTRAINT [' + @var12 + '];');
    ALTER TABLE [RoleAccessCode] ALTER COLUMN [UpdatedOn] datetime2 NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200326035531_UpdateDateFormat')
BEGIN
    DECLARE @var13 sysname;
    SELECT @var13 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[GroupRole]') AND [c].[name] = N'UpdatedOn');
    IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [GroupRole] DROP CONSTRAINT [' + @var13 + '];');
    ALTER TABLE [GroupRole] ALTER COLUMN [UpdatedOn] datetime2 NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200326035531_UpdateDateFormat')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200326035531_UpdateDateFormat', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200401020103_EmailReminderColumn')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200401020103_EmailReminderColumn', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200401020727_EmailReminderColumns')
BEGIN
    ALTER TABLE [Verification] ADD [EmailReminder] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200401020727_EmailReminderColumns')
BEGIN
    ALTER TABLE [Report] ADD [EmailReminder] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200401020727_EmailReminderColumns')
BEGIN
    ALTER TABLE [ReoccurrencePreventions] ADD [EmailReminder] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200401020727_EmailReminderColumns')
BEGIN
    ALTER TABLE [PreventiveActions] ADD [EmailReminder] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200401020727_EmailReminderColumns')
BEGIN
    ALTER TABLE [ContainmentActions] ADD [EmailReminder] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200401020727_EmailReminderColumns')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200401020727_EmailReminderColumns', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200409053246_UserDepartmentSection')
BEGIN
    ALTER TABLE [UserDepartment] ADD [Section] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200409053246_UserDepartmentSection')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200409053246_UserDepartmentSection', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200412131119_UserDepartmentSectionUpdate')
BEGIN
    ALTER TABLE [TicketApprover] ADD [DivisionSection] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200412131119_UserDepartmentSectionUpdate')
BEGIN
    ALTER TABLE [TicketApproval] ADD [Section] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200412131119_UserDepartmentSectionUpdate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200412131119_UserDepartmentSectionUpdate', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200413030405_AddSectionToTicketRouting')
BEGIN
    ALTER TABLE [TicketRouting] ADD [Section] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200413030405_AddSectionToTicketRouting')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200413030405_AddSectionToTicketRouting', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200415020734_AddLastEmailTriggerDate')
BEGIN
    ALTER TABLE [Verification] ADD [LastEmailTriggerDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200415020734_AddLastEmailTriggerDate')
BEGIN
    ALTER TABLE [ReportAttachment] ADD [DocumentType] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200415020734_AddLastEmailTriggerDate')
BEGIN
    ALTER TABLE [ReoccurrencePreventions] ADD [LastEmailTriggerDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200415020734_AddLastEmailTriggerDate')
BEGIN
    ALTER TABLE [PreventiveActions] ADD [LastEmailTriggerDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200415020734_AddLastEmailTriggerDate')
BEGIN
    ALTER TABLE [ContainmentActions] ADD [LastEmailTriggerDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200415020734_AddLastEmailTriggerDate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200415020734_AddLastEmailTriggerDate', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200416140749_AddReportLastEmailTriggerDate')
BEGIN
    ALTER TABLE [Report] ADD [LastEmailTriggerDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200416140749_AddReportLastEmailTriggerDate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200416140749_AddReportLastEmailTriggerDate', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200508021012_AddAssignIT')
BEGIN
    ALTER TABLE [Ticket] ADD [AssignIT] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200508021012_AddAssignIT')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200508021012_AddAssignIT', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200528011432_AddEmployeeNameToUser')
BEGIN
    ALTER TABLE [Users] ADD [EmployeeName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200528011432_AddEmployeeNameToUser')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200528011432_AddEmployeeNameToUser', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200609080306_AddActionItemPIC')
BEGIN
    CREATE TABLE [ActionItemPIC] (
        [Id] int NOT NULL IDENTITY,
        [ActionItemId] int NOT NULL,
        [UserCode] nvarchar(max) NULL,
        [Status] bit NOT NULL,
        [CreatedBy] nvarchar(max) NULL,
        [CreatedOn] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(max) NULL,
        [UpdatedOn] datetime2 NOT NULL,
        [ContainmentActionsId] int NULL,
        [PreventiveActionsId] int NULL,
        [ReoccurrencePreventionId] int NULL,
        [VerificationId] int NULL,
        CONSTRAINT [PK_ActionItemPIC] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ActionItemPIC_ContainmentActions_ContainmentActionsId] FOREIGN KEY ([ContainmentActionsId]) REFERENCES [ContainmentActions] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_ActionItemPIC_PreventiveActions_PreventiveActionsId] FOREIGN KEY ([PreventiveActionsId]) REFERENCES [PreventiveActions] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_ActionItemPIC_ReoccurrencePreventions_ReoccurrencePreventionId] FOREIGN KEY ([ReoccurrencePreventionId]) REFERENCES [ReoccurrencePreventions] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_ActionItemPIC_Verification_VerificationId] FOREIGN KEY ([VerificationId]) REFERENCES [Verification] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200609080306_AddActionItemPIC')
BEGIN
    CREATE INDEX [IX_ActionItemPIC_ContainmentActionsId] ON [ActionItemPIC] ([ContainmentActionsId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200609080306_AddActionItemPIC')
BEGIN
    CREATE INDEX [IX_ActionItemPIC_PreventiveActionsId] ON [ActionItemPIC] ([PreventiveActionsId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200609080306_AddActionItemPIC')
BEGIN
    CREATE INDEX [IX_ActionItemPIC_ReoccurrencePreventionId] ON [ActionItemPIC] ([ReoccurrencePreventionId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200609080306_AddActionItemPIC')
BEGIN
    CREATE INDEX [IX_ActionItemPIC_VerificationId] ON [ActionItemPIC] ([VerificationId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200609080306_AddActionItemPIC')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200609080306_AddActionItemPIC', N'3.1.4');
END;

GO

