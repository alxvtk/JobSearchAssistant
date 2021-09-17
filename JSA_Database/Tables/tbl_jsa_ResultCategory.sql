/****** Object: Table [dbo].[jsa_ResultCategory]   Script Date: 2021-09-13 8:22:45 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_ResultCategory]') AND type in (N'U'))
 BEGIN
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[FK__rs_CategoryId_2_rc_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_ResultStatus] DROP CONSTRAINT [FK__rs_CategoryId_2_rc_Id];
  DROP TABLE [dbo].[jsa_ResultCategory];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_ResultCategory] 
(
 [rc_Id] int NOT NULL,
 [rc_Name] varchar(64) NOT NULL,
 [rc_Code] varchar(3) NOT NULL,
 CONSTRAINT [PK__rc_Id] PRIMARY KEY CLUSTERED ([rc_Id] ASC) ON [PRIMARY]
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_ResultCategory] SET (LOCK_ESCALATION = TABLE);
GO
