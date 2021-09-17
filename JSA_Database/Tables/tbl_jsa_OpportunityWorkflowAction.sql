/****** Object: Table [dbo].[jsa_OpportunityWorkflowAction]   Script Date: 2021-09-13 8:10:53 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_OpportunityWorkflowAction]') AND type in (N'U'))
 BEGIN
  DROP TABLE [dbo].[jsa_OpportunityWorkflowAction];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_OpportunityWorkflowAction] 
(
 [owa_Id] int NOT NULL,
 [owa_OpportunityWorkflowId] int NOT NULL,
 [owa_OpportunityActionId] int NOT NULL,
 CONSTRAINT [FK__owa_OpportunityActionId_2_oa_Id] FOREIGN KEY ([owa_OpportunityActionId]) REFERENCES [jsa_OpportunityAction] ( [oa_Id] ),
 CONSTRAINT [PK__owa_Id] PRIMARY KEY CLUSTERED ([owa_Id] ASC) ON [PRIMARY],
 CONSTRAINT [FK__owa_OpportunityWorkflowId_2_ow_Id] FOREIGN KEY ([owa_OpportunityWorkflowId]) REFERENCES [jsa_OpportunityWorkflow] ( [ow_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_OpportunityWorkflowAction] SET (LOCK_ESCALATION = TABLE);
GO