/****** Object: Table [dbo].[jsa_Url]   Script Date: 2021-09-13 8:29:10 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Url]') AND type in (N'U'))
 BEGIN
  DECLARE @TRAN NVARCHAR(MAX);
  SET @TRAN = 'Drop_Of_Table_dbo.jsa_Url';
  BEGIN TRANSACTION @TRAN WITH MARK N'Dropping Table dbo.jsa_Url';
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[FK__d_UrlId_2_u_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Document] DROP CONSTRAINT [FK__d_UrlId_2_u_Id];
  IF (OBJECT_ID('[dbo].[FK__s_UrlId_2_u_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Source] DROP CONSTRAINT [FK__s_UrlId_2_u_Id];
  IF (OBJECT_ID('[dbo].[PK_u2b_UrlId_2_u_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Url2Business] DROP CONSTRAINT [PK_u2b_UrlId_2_u_Id];

  /* Dropping the table */
  DROP TABLE [dbo].[jsa_Url];

  IF (@@ERROR <> 0) ROLLBACK TRAN @TRAN;
  ELSE COMMIT TRANSACTION @TRAN;

END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Url] 
(
 [u_Id] int NOT NULL,
 [u_Body] varchar(2048) NOT NULL,
 [u_Comment] varchar(1024) NULL, 
 CONSTRAINT [PK__u_Id] PRIMARY KEY CLUSTERED ([u_Id] ASC) ON [PRIMARY]
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Url] SET (LOCK_ESCALATION = TABLE);
GO

