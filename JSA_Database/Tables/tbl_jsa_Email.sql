/****** Object: Table [dbo].[jsa_Email]   Script Date: 2021-09-13 7:45:20 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Email]') AND type in (N'U'))
 BEGIN
  DECLARE @TRAN NVARCHAR(MAX);
  SET @TRAN = 'Drop_Of_Table_dbo.jsa_Email';
  BEGIN TRANSACTION @TRAN WITH MARK N'Dropping Table dbo.jsa_Email';
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[FK_e2b_EmailId_2_e_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Email2Business] DROP CONSTRAINT [FK_e2b_EmailId_2_e_Id];
  IF (OBJECT_ID('[dbo].[PK__e2p_EmailId_2_e_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Email2Person] DROP CONSTRAINT [PK__e2p_EmailId_2_e_Id];
  IF (OBJECT_ID('[dbo].[FK_s_EmailId_2_e_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Source] DROP CONSTRAINT [FK_s_EmailId_2_e_Id];
  /* Dropping the table */
  DROP TABLE [dbo].[jsa_Email];

  IF (@@ERROR <> 0) ROLLBACK TRAN @TRAN;
  ELSE COMMIT TRANSACTION @TRAN;
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Email] 
(
 [e_Id] int NOT NULL,
 [e_Body] varchar(320) NOT NULL,
 [e_Comment] varchar(1024) NULL,
 CONSTRAINT [PK__e_Id] PRIMARY KEY CLUSTERED ([e_Id] ASC) ON [PRIMARY]
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Email] SET (LOCK_ESCALATION = TABLE);
GO
