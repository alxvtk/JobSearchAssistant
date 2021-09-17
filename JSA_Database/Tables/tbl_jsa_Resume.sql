/****** Object: Table [dbo].[jsa_Resume]   Script Date: 2021-09-13 8:25:32 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Resume]') AND type in (N'U'))
 BEGIN
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[FK__o_ResumeId_2_r_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Opportunity] DROP CONSTRAINT [FK__o_ResumeId_2_r_Id];
  DROP TABLE [dbo].[jsa_Resume];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Resume] 
(
 [r_id] int NOT NULL,
 [r_DocumentId] int NOT NULL,
 [r_Version] int NOT NULL,
 [r_SubVersion] int NULL,
 [r_VersioningDate] datetime NOT NULL,
 [r_Active] varchar(1) NOT NULL,
 CONSTRAINT [PK__r_Id] PRIMARY KEY CLUSTERED ([r_id] ASC) ON [PRIMARY],
 CONSTRAINT [FK__r_DocumentId_2_d_Id] FOREIGN KEY ([r_DocumentId]) REFERENCES [jsa_Document] ( [d_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Resume] SET (LOCK_ESCALATION = TABLE);
GO

