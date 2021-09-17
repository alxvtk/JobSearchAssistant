/****** Object: Table [dbo].[jsa_OpportunityActionType]   Script Date: 2021-09-13 8:06:56 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_OpportunityActionType]') AND type in (N'U'))
 BEGIN
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[FK__oa_OpportunityActionTypeId_2_oat_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_OpportunityAction] DROP CONSTRAINT [FK__oa_OpportunityActionTypeId_2_oat_Id];
  DROP TABLE [dbo].[jsa_OpportunityActionType];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_OpportunityActionType] 
(
 [oat_Id] int NOT NULL,
 [oat_SequenceNumber] int NOT NULL,
 [oat_Title] varchar(512) NOT NULL,
 [oat_Description] varchar(1024) NULL,
 [oat_Note] varchar(1024) NULL,
 CONSTRAINT [PK__oat_Id] PRIMARY KEY CLUSTERED ([oat_Id] ASC) ON [PRIMARY]
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_OpportunityActionType] SET (LOCK_ESCALATION = TABLE);
GO

