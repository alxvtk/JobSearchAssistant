/****** Object: Table [dbo].[jsa_Email2Person]   Script Date: 2021-09-13 7:51:10 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Email2Person]') AND type in (N'U'))
 BEGIN
  DROP TABLE [dbo].[jsa_Email2Person];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Email2Person] 
(
 [e2p_Id] int NOT NULL,
 [e2p_EmailId] int NOT NULL,
 [e2p_PersonId] int NOT NULL,
 [e2p_Active] varchar(1) NOT NULL,
 CONSTRAINT [PK__e2p_Id] PRIMARY KEY CLUSTERED ([e2p_Id] ASC) ON [PRIMARY],
 CONSTRAINT [PK__e2p_EmailId_2_e_Id] FOREIGN KEY ([e2p_EmailId]) REFERENCES [jsa_Email] ( [e_Id] ),
 CONSTRAINT [PK__e2p_PersonId_2_p_Id] FOREIGN KEY ([e2p_PersonId]) REFERENCES [jsa_Person] ( [p_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Email2Person] SET (LOCK_ESCALATION = TABLE);
GO

