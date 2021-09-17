/****** Object: Table [dbo].[jsa_Phone2Business]   Script Date: 2021-09-13 8:19:17 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Phone2Business]') AND type in (N'U'))
 BEGIN
  DROP TABLE [dbo].[jsa_Phone2Business];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Phone2Business] 
(
 [ph2b_Id] int NOT NULL,
 [ph2b_PhoneId] int NOT NULL,
 [ph2b_BusinessId] int NOT NULL,
 [ph2b_Active] varchar(1) NOT NULL,
 CONSTRAINT [PK__ph2b_Id] PRIMARY KEY CLUSTERED ([ph2b_Id] ASC) ON [PRIMARY],
 CONSTRAINT [PK__ph2b_PhoneId_2_ph_Id] FOREIGN KEY ([ph2b_PhoneId]) REFERENCES [jsa_Phone] ( [ph_Id] ),
 CONSTRAINT [PK__ph2b_BusinessId_2_b_Id] FOREIGN KEY ([ph2b_BusinessId]) REFERENCES [jsa_Business] ( [b_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Phone2Business] SET (LOCK_ESCALATION = TABLE);
GO

