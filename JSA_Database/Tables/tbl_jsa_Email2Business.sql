/****** Object: Table [dbo].[jsa_Email2Business]   Script Date: 2021-09-13 7:47:26 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Email2Business]') AND type in (N'U'))
 BEGIN
  DROP TABLE [dbo].[jsa_Email2Business];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Email2Business] 
(
 [e2b_Id] int NOT NULL,
 [e2b_EmailId] int NOT NULL,
 [e2b_BusinessId] int NOT NULL,
 [e2b_Active] varchar(1) NOT NULL,
 CONSTRAINT [PK__e2b_Id] PRIMARY KEY CLUSTERED ([e2b_Id] ASC) ON [PRIMARY],
 CONSTRAINT [FK_e2b_EmailId_2_e_Id] FOREIGN KEY ([e2b_EmailId]) REFERENCES [jsa_Email] ( [e_Id] ),
 CONSTRAINT [FK_e2b_BusinessId_2_b_Id] FOREIGN KEY ([e2b_BusinessId]) REFERENCES [jsa_Business] ( [b_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Email2Business] SET (LOCK_ESCALATION = TABLE);
GO

