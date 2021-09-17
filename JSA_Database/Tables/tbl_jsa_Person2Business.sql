/****** Object: Table [dbo].[jsa_Person2Business]   Script Date: 2021-09-13 8:14:54 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Person2Business]') AND type in (N'U'))
 BEGIN
  DROP TABLE [dbo].[jsa_Person2Business];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Person2Business] 
(
 [p2b_Id] int NOT NULL,
 [p2b_PersonId] int NOT NULL,
 [p2b_BusinessId] int NOT NULL,
 [p2b_Active] varchar(1) NOT NULL,
 CONSTRAINT [PK__p2b_Id] PRIMARY KEY CLUSTERED ([p2b_Id] ASC) ON [PRIMARY],
 CONSTRAINT [PK__p2b_PersonId_2_p_Id] FOREIGN KEY ([p2b_PersonId]) REFERENCES [jsa_Person] ( [p_Id] ),
 CONSTRAINT [PK__p2b_BusinessId_2_b_Id] FOREIGN KEY ([p2b_BusinessId]) REFERENCES [jsa_Business] ( [b_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Person2Business] SET (LOCK_ESCALATION = TABLE);
GO

