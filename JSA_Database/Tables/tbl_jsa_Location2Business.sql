/****** Object: Table [dbo].[jsa_Location2Business]   Script Date: 2021-09-13 7:58:51 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Location2Business]') AND type in (N'U'))
 BEGIN
  DROP TABLE [dbo].[jsa_Location2Business];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Location2Business] 
(
 [l2b_Id] int NOT NULL,
 [l2b_BusinessId] int NOT NULL,
 [l2b_LocationId] int NOT NULL,
 [l2b_Active] varchar(1) NOT NULL,
 CONSTRAINT [PK__l2b_Id] PRIMARY KEY CLUSTERED ([l2b_Id] ASC) ON [PRIMARY],
 CONSTRAINT [PK_l2b_BusinessId_2_b_Id] FOREIGN KEY ([l2b_BusinessId]) REFERENCES [jsa_Business] ( [b_Id] ),
 CONSTRAINT [PK_l2b_LocationId_2_l_Id] FOREIGN KEY ([l2b_LocationId]) REFERENCES [jsa_Location] ( [l_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Location2Business] SET (LOCK_ESCALATION = TABLE);
GO
