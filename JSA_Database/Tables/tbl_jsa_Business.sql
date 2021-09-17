/****** Object: Table [dbo].[jsa_Business]   Script Date: 2021-09-13 7:09:13 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Business]') AND type in (N'U'))
 BEGIN
  DECLARE @TRAN NVARCHAR(MAX);
  SET @TRAN = 'Drop_Of_Table_dbo.jsa_Business';
  BEGIN TRANSACTION @TRAN WITH MARK N'Dropping Table dbo.jsa_Business';
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[FK_e2b_BusinessId_2_b_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Email2Business] DROP CONSTRAINT [FK_e2b_BusinessId_2_b_Id];
  IF (OBJECT_ID('[dbo].[PK_l2b_BusinessId_2_b_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Location2Business] DROP CONSTRAINT [PK_l2b_BusinessId_2_b_Id];
  IF (OBJECT_ID('[dbo].[PK__p2b_BusinessId_2_b_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Person2Business] DROP CONSTRAINT [PK__p2b_BusinessId_2_b_Id];
  IF (OBJECT_ID('[dbo].[PK__ph2b_BusinessId_2_b_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Phone2Business] DROP CONSTRAINT [PK__ph2b_BusinessId_2_b_Id];
  IF (OBJECT_ID('[dbo].[PK_u2b_BusinessId_2_b_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Url2Business] DROP CONSTRAINT [PK_u2b_BusinessId_2_b_Id];

  /* Dropping the table */
  DROP TABLE [dbo].[jsa_Business];

  IF (@@ERROR <> 0) ROLLBACK TRAN @TRAN;
  ELSE COMMIT TRANSACTION @TRAN;

END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Business] 
(
 [b_Id] int NOT NULL,
 [b_Name] varchar(1024) NOT NULL,
 CONSTRAINT [PK__b_Id] PRIMARY KEY CLUSTERED ([b_Id] ASC) ON [PRIMARY]
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Business] SET (LOCK_ESCALATION = TABLE);
GO
