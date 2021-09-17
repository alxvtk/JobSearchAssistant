/****** Object: Table [dbo].[jsa_Person]   Script Date: 2021-09-13 8:11:54 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Person]') AND type in (N'U'))
 BEGIN
  DECLARE @TRAN NVARCHAR(MAX);
  SET @TRAN = 'Drop_Of_Table_dbo.jsa_Person';
  BEGIN TRANSACTION @TRAN WITH MARK N'Dropping Table dbo.jsa_Person';
  /* Drop constraints script is generated to allow dropping of the table */
  IF (OBJECT_ID('[dbo].[PK__e2p_PersonId_2_p_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Email2Person] DROP CONSTRAINT [PK__e2p_PersonId_2_p_Id];
  IF (OBJECT_ID('[dbo].[FK_l2p_PersonId_2_p_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Location2Person] DROP CONSTRAINT [FK_l2p_PersonId_2_p_Id];
  IF (OBJECT_ID('[dbo].[FK__oap_PersonId_2_p_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_OpportunityActionPeople] DROP CONSTRAINT [FK__oap_PersonId_2_p_Id];
  IF (OBJECT_ID('[dbo].[PK__p2b_PersonId_2_p_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Person2Business] DROP CONSTRAINT [PK__p2b_PersonId_2_p_Id];
  IF (OBJECT_ID('[dbo].[PK__ph2p_PersonId_2_p_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Phone2Person] DROP CONSTRAINT [PK__ph2p_PersonId_2_p_Id];
  IF (OBJECT_ID('[dbo].[FK__s_PersonId_2_p_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_Source] DROP CONSTRAINT [FK__s_PersonId_2_p_Id];
  IF (OBJECT_ID('[dbo].[FK__usr_PersonId_2_p_Id]') IS NOT NULL) ALTER TABLE [dbo].[jsa_User] DROP CONSTRAINT [FK__usr_PersonId_2_p_Id];

  /* Dropping the table */
  DROP TABLE [dbo].[jsa_Person];

  IF (@@ERROR <> 0) ROLLBACK TRAN @TRAN;
  ELSE COMMIT TRANSACTION @TRAN;

 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Person] 
(
 [p_Id] int NOT NULL,
 [p_Title] varchar(512) NULL,
 [p_FirstName] varchar(32) NOT NULL,
 [p_LastName] varchar(64) NULL,
 [p_NickName] varchar(64) NULL,
 [p_Position] varchar(128) NULL,
 [p_Comments] varchar(1028) NULL,
 CONSTRAINT [PK__p_Id] PRIMARY KEY CLUSTERED ([p_Id] ASC) ON [PRIMARY]
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Person] SET (LOCK_ESCALATION = TABLE);
GO

