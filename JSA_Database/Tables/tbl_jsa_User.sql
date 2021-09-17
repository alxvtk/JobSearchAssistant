/****** Object: Table [dbo].[jsa_User]   Script Date: 2021-09-13 8:35:20 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_User]') AND type in (N'U'))
 BEGIN
  DROP TABLE [dbo].[jsa_User];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_User] 
(
 [usr_Id] int NOT NULL,
 [usr_PersonId] int NOT NULL,
 CONSTRAINT [PK__usr_Id] PRIMARY KEY CLUSTERED ([usr_Id] ASC) ON [PRIMARY],
 CONSTRAINT [FK__usr_PersonId_2_p_Id] FOREIGN KEY ([usr_PersonId]) REFERENCES [jsa_Person] ( [p_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_User] SET (LOCK_ESCALATION = TABLE);
GO

