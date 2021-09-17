/****** Object: Table [dbo].[jsa_Phone]   Script Date: 2021-09-13 8:17:12 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Phone]') AND type in (N'U'))
 BEGIN
  DECLARE @TRAN NVARCHAR(MAX);
  SET @TRAN = 'Drop_Of_Table_dbo.jsa_Phone';
  BEGIN TRANSACTION @TRAN WITH MARK N'Dropping Table dbo.jsa_Phone';
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[PK__ph2b_PhoneId_2_ph_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Phone2Business] DROP CONSTRAINT [PK__ph2b_PhoneId_2_ph_Id];
  IF (OBJECT_ID('[dbo].[PK__ph2p_PhoneId_2_ph_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Phone2Person] DROP CONSTRAINT [PK__ph2p_PhoneId_2_ph_Id];

  /* Dropping the table */
  DROP TABLE [dbo].[jsa_Phone];

  IF (@@ERROR <> 0) ROLLBACK TRAN @TRAN;
  ELSE COMMIT TRANSACTION @TRAN;

 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Phone] 
(
 [ph_Id] int NOT NULL,
 [ph_Number] varchar(320) NOT NULL,
 [ph_Name] varchar(512) NULL,
 [ph_Fax] char(1) NOT NULL,
 [ph_Comment] varchar(1024) NULL,
 CONSTRAINT [PK__ph_Id] PRIMARY KEY CLUSTERED ([ph_Id] ASC) ON [PRIMARY]
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Phone] SET (LOCK_ESCALATION = TABLE);
GO
