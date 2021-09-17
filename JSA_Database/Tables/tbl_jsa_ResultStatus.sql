/****** Object: Table [dbo].[jsa_ResultStatus]   Script Date: 2021-09-13 8:23:50 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_ResultStatus]') AND type in (N'U'))
 BEGIN
  DECLARE @TRAN NVARCHAR(MAX);
  SET @TRAN = 'Drop_Of_Table_dbo.jsa_ResultStatus';
  BEGIN TRANSACTION @TRAN WITH MARK N'Dropping Table dbo.jsa_ResultStatus';
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[FK__oa_ResultStatusId_2_rs_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_OpportunityAction] DROP CONSTRAINT [FK__oa_ResultStatusId_2_rs_Id];
  IF (OBJECT_ID('[dbo].[FK_ow_WorkflowResultStatusId_2_rs_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_OpportunityWorkflow] DROP CONSTRAINT [FK_ow_WorkflowResultStatusId_2_rs_Id];

  /* Dropping the table */
  DROP TABLE [dbo].[jsa_ResultStatus];

  IF (@@ERROR <> 0) ROLLBACK TRAN @TRAN;
  ELSE COMMIT TRANSACTION @TRAN;
END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_ResultStatus] 
(
 [rs_Id] int NOT NULL,
 [rs_Name] varchar(64) NOT NULL,
 [rs_Code] varchar(3) NOT NULL,
 [rs_CategoryId] int NOT NULL,
 CONSTRAINT [PK__rs_Id] PRIMARY KEY CLUSTERED ([rs_Id] ASC) ON [PRIMARY],
 CONSTRAINT [FK__rs_CategoryId_2_rc_Id] FOREIGN KEY ([rs_CategoryId]) REFERENCES [jsa_ResultCategory] ( [rc_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_ResultStatus] SET (LOCK_ESCALATION = TABLE);
GO

