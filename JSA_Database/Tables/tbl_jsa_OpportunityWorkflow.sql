/****** Object: Table [dbo].[jsa_OpportunityWorkflow]   Script Date: 2021-09-13 8:09:29 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_OpportunityWorkflow]') AND type in (N'U'))
 BEGIN
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[FK__owa_OpportunityWorkflowId_2_ow_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_OpportunityWorkflowAction] DROP CONSTRAINT [FK__owa_OpportunityWorkflowId_2_ow_Id];
  DROP TABLE [dbo].[jsa_OpportunityWorkflow];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_OpportunityWorkflow] 
(
 [ow_Id] int NOT NULL,
 [ow_OpportunityId] int NOT NULL,
 [ow_WorkFlowResultStatusId] int NULL,
 [ow_DateTime] datetime NULL,
 [ow_Description] varchar(1024) NULL,
 CONSTRAINT [PK__ow_Id] PRIMARY KEY CLUSTERED ([ow_Id] ASC) ON [PRIMARY],
 CONSTRAINT [FK__ow_OpportunityId_2_o_Id] FOREIGN KEY ([ow_OpportunityId]) REFERENCES [jsa_Opportunity] ( [o_Id] ),
 CONSTRAINT [FK_ow_WorkflowResultStatusId_2_rs_Id] FOREIGN KEY ([ow_WorkFlowResultStatusId]) REFERENCES [jsa_ResultStatus] ( [rs_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_OpportunityWorkflow] SET (LOCK_ESCALATION = TABLE);
GO

