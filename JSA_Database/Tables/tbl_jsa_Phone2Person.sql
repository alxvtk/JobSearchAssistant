/****** Object: Table [dbo].[jsa_Phone2Person]   Script Date: 2021-09-13 8:20:55 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Phone2Person]') AND type in (N'U'))
 BEGIN
  DROP TABLE [dbo].[jsa_Phone2Person];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Phone2Person] 
(
 [ph2p_Id] int NOT NULL,
 [ph2p_PhoneId] int NOT NULL,
 [ph2p_PersonId] int NOT NULL,
 [ph2p_Active] varchar(1) NOT NULL,
 CONSTRAINT [PK__ph2p_Id] PRIMARY KEY CLUSTERED ([ph2p_Id] ASC) ON [PRIMARY],
 CONSTRAINT [PK__ph2p_PhoneId_2_ph_Id] FOREIGN KEY ([ph2p_PhoneId]) REFERENCES [jsa_Phone] ( [ph_Id] ),
 CONSTRAINT [PK__ph2p_PersonId_2_p_Id] FOREIGN KEY ([ph2p_PersonId]) REFERENCES [jsa_Person] ( [p_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Phone2Person] SET (LOCK_ESCALATION = TABLE);
GO

