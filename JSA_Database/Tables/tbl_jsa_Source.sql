/****** Object: Table [dbo].[jsa_Source]   Script Date: 2021-09-13 8:26:39 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Source]') AND type in (N'U'))
 BEGIN
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[FK__jd_SourceId_2_s_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_JobDescription] DROP CONSTRAINT [FK__jd_SourceId_2_s_Id];
  DROP TABLE [dbo].[jsa_Source];
END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Source] 
(
 [s_Id] int NOT NULL,
 [s_SourceTypeId] int NOT NULL,
 [s_PersonId] int NULL,
 [s_UrlId] int NULL,
 [s_EmailId] int NULL,
 [s_Name] varchar(1024) NOT NULL,
 [s_Comment] varchar(2048) NULL,
 CONSTRAINT [PK__s_Id] PRIMARY KEY CLUSTERED ([s_Id] ASC) ON [PRIMARY],
 CONSTRAINT [FK__s_SourceTypeId_2_st_Id] FOREIGN KEY ([s_SourceTypeId]) REFERENCES [jsa_SourceType] ( [st_ID] ),
 CONSTRAINT [FK__s_UrlId_2_u_Id] FOREIGN KEY ([s_UrlId]) REFERENCES [jsa_Url] ( [u_Id] ),
 CONSTRAINT [FK__s_PersonId_2_p_Id] FOREIGN KEY ([s_PersonId]) REFERENCES [jsa_Person] ( [p_Id] ),
 CONSTRAINT [FK_s_EmailId_2_e_Id] FOREIGN KEY ([s_EmailId]) REFERENCES [jsa_Email] ( [e_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Source] SET (LOCK_ESCALATION = TABLE);
GO

