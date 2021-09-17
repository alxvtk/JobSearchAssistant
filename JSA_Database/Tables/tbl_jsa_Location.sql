/****** Object: Table [dbo].[jsa_Location]   Script Date: 2021-09-13 7:55:22 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Location]') AND type in (N'U'))
 BEGIN
  DECLARE @TRAN NVARCHAR(MAX);
  SET @TRAN = 'Drop_Of_Table_dbo.jsa_Location';
  BEGIN TRANSACTION @TRAN WITH MARK N'Dropping Table dbo.jsa_Location';
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[PK_l2b_LocationId_2_l_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Location2Business] DROP CONSTRAINT [PK_l2b_LocationId_2_l_Id];
  IF (OBJECT_ID('[dbo].[FK_l2p_LocationId_2_l_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Location2Person] DROP CONSTRAINT [FK_l2p_LocationId_2_l_Id];

  /* Dropping the table */
  DROP TABLE [dbo].[jsa_Location];

  IF (@@ERROR <> 0) ROLLBACK TRAN @TRAN;
  ELSE COMMIT TRANSACTION @TRAN;

 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Location] 
(
 [l_Id] int NOT NULL,
 [l_StreetNumber] varchar(10) NULL,
 [l_StreetNumberSuffix] varchar(10) NULL,
 [l_StreetName] varchar(64) NULL,
 [l_StreetType] varchar(10) NULL,
 [l_StreetDirection] varchar(10) NULL,
 [l_Unit] varchar(10) NULL,
 [l_Municipality] varchar(64) NOT NULL,
 [l_Province] varchar(20) NULL,
 [l_CountryId] int NOT NULL,
 [l_PostalCode] varchar(7) NULL,
 [l_StreetLine1] varchar(512) NULL,
 [l_StreetLine2] varchar(512) NULL,
 [l_Comments] varchar(1024) NULL,
 CONSTRAINT [PK__l_Id] PRIMARY KEY CLUSTERED ([l_Id] ASC) ON [PRIMARY]
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Location] SET (LOCK_ESCALATION = TABLE);
GO

