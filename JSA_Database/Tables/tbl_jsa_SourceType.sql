/****** Object: Table [dbo].[jsa_SourceType]   Script Date: 2021-09-13 8:28:10 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_SourceType]') AND type in (N'U'))
 BEGIN
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[FK__s_SourceTypeId_2_st_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Source] DROP CONSTRAINT [FK__s_SourceTypeId_2_st_Id];
  DROP TABLE [dbo].[jsa_SourceType];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_SourceType] 
(
 [st_ID] int NOT NULL,
 [st_Type] varchar(1) NOT NULL,
 [st_TypeName] varchar(10) NOT NULL,
 CONSTRAINT [PK__st_Id] PRIMARY KEY CLUSTERED ([st_ID] ASC) ON [PRIMARY]
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_SourceType] SET (LOCK_ESCALATION = TABLE);
GO

