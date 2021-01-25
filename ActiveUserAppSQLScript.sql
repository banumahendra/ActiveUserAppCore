/* Check for database exist */

IF EXISTS 
(
     SELECT name FROM master.dbo.sysdatabases 
    WHERE name = 'UserDB'
)
BEGIN
    SELECT 'UserDB Database Name already Exist' AS Message
END
ELSE
BEGIN
    CREATE DATABASE [UserDB]
    SELECT 'UserDB Database is Created'
END

GO

USE [UserDB]

GO
/* Check for table exist */

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type in (N'U'))

BEGIN
CREATE TABLE [dbo].[User] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (100) NOT NULL,
    [Email]    VARCHAR (100) NOT NULL,
    [Phone]    VARCHAR (100) NOT NULL,
    [IsActive] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
END

GO

/* Sample User Table Data */

--Insert into [User] values('mory', 'mory@abc.com','8234293847','True')
--Insert into [User] values('Jhon', 'jhon@abc.com','3234934343','False')
--Insert into [User] values('lisy', 'lisy@abc.com','3242342342','True')
