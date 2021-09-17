/****** Object: Table [dbo].[jsa_OpportunityAction]   Script Date: 2021-09-13 8:03:49 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_OpportunityAction]') AND type in (N'U'))
 BEGIN
  DECLARE @TRAN NVARCHAR(MAX);
  SET @TRAN = 'Drop_Of_Table_dbo.jsa_OpportunityAction';
  BEGIN TRANSACTION @TRAN WITH MARK N'Dropping Table dbo.jsa_OpportunityAction';
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[FK__oap_OpportunityActionId_2_oa_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_OpportunityActionPeople] DROP CONSTRAINT [FK__oap_OpportunityActionId_2_oa_Id];
  IF (OBJECT_ID('[dbo].[FK__owa_OpportunityActionId_2_oa_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_OpportunityWorkflowAction] DROP CONSTRAINT [FK__owa_OpportunityActionId_2_oa_Id];

  /* Dropping the table */
  DROP TABLE [dbo].[jsa_OpportunityAction];

  IF (@@ERROR <> 0) ROLLBACK TRAN @TRAN;
  ELSE COMMIT TRANSACTION @TRAN;
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_OpportunityAction] 
(
 [oa_Id] int NOT NULL,
 [oa_OpportunityActionTypeId] int NOT NULL,
 [oa_ActionResultStatusId] int NOT NULL,
 [oa_OpportunityDocumentId] int NULL,
 [oa_DateTime] datetime NULL,
 [oa_Description] varchar(1024) NULL,
 CONSTRAINT [PK__oa_Id] PRIMARY KEY CLUSTERED ([oa_Id] ASC) ON [PRIMARY],
 CONSTRAINT [FK__oa_OpportunityActionTypeId_2_oat_Id] FOREIGN KEY ([oa_OpportunityActionTypeId]) REFERENCES [jsa_OpportunityActionType] ( [oat_Id] ),
 CONSTRAINT [FK__oa_ResultStatusId_2_rs_Id] FOREIGN KEY ([oa_ActionResultStatusId]) REFERENCES [jsa_ResultStatus] ( [rs_Id] ),
 CONSTRAINT [FK__oa_OpportunityDocumentId_2_od_Id] FOREIGN KEY ([oa_OpportunityDocumentId]) REFERENCES [jsa_OpportunityDocument] ( [od_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_OpportunityAction] SET (LOCK_ESCALATION = TABLE);
GO

