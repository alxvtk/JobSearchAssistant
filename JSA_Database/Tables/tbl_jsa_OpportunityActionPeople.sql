/****** Object: Table [dbo].[jsa_OpportunityActionPeople]   Script Date: 2021-09-13 8:05:47 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_OpportunityActionPeople]') AND type in (N'U'))
 BEGIN
  DROP TABLE [dbo].[jsa_OpportunityActionPeople];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_OpportunityActionPeople] 
(
 [oap_Id] int NOT NULL,
 [oap_OpportunityActionId] int NOT NULL,
 [oap_PersonId] int NOT NULL,
 CONSTRAINT [FK__oap_OpportunityActionId_2_oa_Id] FOREIGN KEY ([oap_OpportunityActionId]) REFERENCES [jsa_OpportunityAction] ( [oa_Id] ),
 CONSTRAINT [PK__oap_Id] PRIMARY KEY CLUSTERED ([oap_Id] ASC) ON [PRIMARY],
 CONSTRAINT [FK__oap_PersonId_2_p_Id] FOREIGN KEY ([oap_PersonId]) REFERENCES [jsa_Person] ( [p_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_OpportunityActionPeople] SET (LOCK_ESCALATION = TABLE);
GO

