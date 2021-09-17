/****** Object: Table [dbo].[jsa_OpportunityDocument]   Script Date: 2021-09-13 8:08:06 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_OpportunityDocument]') AND type in (N'U'))
 BEGIN
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[FK__oa_OpportunityDocumentId_2_od_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_OpportunityAction] DROP CONSTRAINT [FK__oa_OpportunityDocumentId_2_od_Id];
  DROP TABLE [dbo].[jsa_OpportunityDocument];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_OpportunityDocument] 
(
 [od_Id] int NOT NULL,
 [od_OpportunityId] int NULL,
 [od_Document] int NULL,
 CONSTRAINT [PK__od_Id] PRIMARY KEY CLUSTERED ([od_Id] ASC) ON [PRIMARY],
 CONSTRAINT [FK__od_OpportunityId_2_o_Id] FOREIGN KEY ([od_OpportunityId]) REFERENCES [jsa_Opportunity] ( [o_Id] ),
 CONSTRAINT [FK__od_Document_2_d_Id] FOREIGN KEY ([od_Document]) REFERENCES [jsa_Document] ( [d_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_OpportunityDocument] SET (LOCK_ESCALATION = TABLE);
GO
