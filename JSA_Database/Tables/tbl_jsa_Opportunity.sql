/****** Object: Table [dbo].[jsa_Opportunity]   Script Date: 2021-09-13 8:02:04 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Opportunity]') AND type in (N'U'))
 BEGIN
  DECLARE @TRAN NVARCHAR(MAX);
  SET @TRAN = 'Drop_Of_Table_dbo.jsa_Opportunity';
  BEGIN TRANSACTION @TRAN WITH MARK N'Dropping Table dbo.jsa_Opportunity';
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[FK__od_OpportunityId_2_o_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_OpportunityDocument] DROP CONSTRAINT [FK__od_OpportunityId_2_o_Id];
  IF (OBJECT_ID('[dbo].[FK__ow_OpportunityId_2_o_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_OpportunityWorkflow] DROP CONSTRAINT [FK__ow_OpportunityId_2_o_Id];

  /* Dropping the table */
  DROP TABLE [dbo].[jsa_Opportunity];

  IF (@@ERROR <> 0) ROLLBACK TRAN @TRAN;
  ELSE COMMIT TRANSACTION @TRAN;
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Opportunity] 
(
 [o_Id] int NOT NULL,
 [o_JobDescriptionId] int NOT NULL,
 [o_ResumeId] int NOT NULL,
 [o_Active] char(1) NOT NULL,
 CONSTRAINT [PK__o_Id] PRIMARY KEY CLUSTERED ([o_Id] ASC) ON [PRIMARY],
 CONSTRAINT [FK__o_JobDescriptionId_2_jd_Id] FOREIGN KEY ([o_JobDescriptionId]) REFERENCES [jsa_JobDescription] ( [jd_Id] ),
 CONSTRAINT [FK__o_ResumeId_2_r_Id] FOREIGN KEY ([o_ResumeId]) REFERENCES [jsa_Resume] ( [r_id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Opportunity] SET (LOCK_ESCALATION = TABLE);
GO

