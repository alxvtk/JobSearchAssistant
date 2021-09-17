/****** Object: Table [dbo].[jsa_DocFormat]   Script Date: 2021-09-13 7:41:15 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_DocFormat]') AND type in (N'U'))
 BEGIN
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[FK__d_DocFormatId_2_df_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Document] DROP CONSTRAINT [FK__d_DocFormatId_2_df_Id];
  DROP TABLE [dbo].[jsa_DocFormat];
 END
 GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_DocFormat] 
(
 [df_Id] int NOT NULL,
 [df_Type] varchar(4) NOT NULL,
 CONSTRAINT [PK__df_Id] PRIMARY KEY CLUSTERED ([df_Id] ASC) ON [PRIMARY]
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_DocFormat] SET (LOCK_ESCALATION = TABLE);
GO
