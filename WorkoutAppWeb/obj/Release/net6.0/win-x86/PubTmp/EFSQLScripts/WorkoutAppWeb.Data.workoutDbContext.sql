IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220208180105_AddWorkoutToDb')
BEGIN
    CREATE TABLE [homeWorkoutDB] (
        [id] int NOT NULL IDENTITY,
        [name] nvarchar(max) NOT NULL,
        [repCount] int NOT NULL,
        CONSTRAINT [PK_homeWorkoutDB] PRIMARY KEY ([id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220208180105_AddWorkoutToDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220208180105_AddWorkoutToDb', N'6.0.1');
END;
GO

COMMIT;
GO

