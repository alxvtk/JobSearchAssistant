/****** Object: Table [dbo].[jsa_JobDescription]   Script Date: 2021-09-13 7:53:45 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_JobDescription]') AND type in (N'U'))
 BEGIN
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[FK__o_JobDescriptionId_2_jd_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Opportunity] DROP CONSTRAINT [FK__o_JobDescriptionId_2_jd_Id];
  DROP TABLE [dbo].[jsa_JobDescription];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_JobDescription] 
(
 [jd_Id] int NOT NULL,
 [jd_SourceId] int NOT NULL,
 [jd_DocumentId] int NOT NULL,
 CONSTRAINT [FK__jd_SourceId_2_s_Id] FOREIGN KEY ([jd_SourceId]) REFERENCES [jsa_Source] ( [s_Id] ),
 CONSTRAINT [PK__jd_Id] PRIMARY KEY CLUSTERED ([jd_Id] ASC) ON [PRIMARY],
 CONSTRAINT [FK__jd_DocumentId_2_d_Id] FOREIGN KEY ([jd_DocumentId]) REFERENCES [jsa_Document] ( [d_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_JobDescription] SET (LOCK_ESCALATION = TABLE);
GO

