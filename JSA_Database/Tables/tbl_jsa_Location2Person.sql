/****** Object: Table [dbo].[jsa_Location2Person]   Script Date: 2021-09-13 8:00:20 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Location2Person]') AND type in (N'U'))
 BEGIN
  DROP TABLE [dbo].[jsa_Location2Person];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Location2Person] 
(
 [l2p_Id] int NOT NULL,
 [l2p_PersonId] int NOT NULL,
 [l2p_LocationId] int NOT NULL,
 [l2p_Active] varchar(1) NOT NULL,
 CONSTRAINT [PK__l2p_Id] PRIMARY KEY CLUSTERED ([l2p_Id] ASC) ON [PRIMARY],
 CONSTRAINT [FK_l2p_PersonId_2_p_Id] FOREIGN KEY ([l2p_PersonId]) REFERENCES [jsa_Person] ( [p_Id] ),
 CONSTRAINT [FK_l2p_LocationId_2_l_Id] FOREIGN KEY ([l2p_LocationId]) REFERENCES [jsa_Location] ( [l_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Location2Person] SET (LOCK_ESCALATION = TABLE);
GO

