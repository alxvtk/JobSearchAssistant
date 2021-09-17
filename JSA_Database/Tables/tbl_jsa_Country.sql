/****** Object: Table [dbo].[jsa_Country]   Script Date: 2021-09-13 7:39:52 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Country]') AND type in (N'U'))
 BEGIN
  DROP TABLE [dbo].[jsa_Country];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Country] 
(
 [c_Id] int NOT NULL,
 [c_Code] varchar(3) NOT NULL,
 [c_Name] varchar(128) NOT NULL,
 CONSTRAINT [PK__c_Id] PRIMARY KEY CLUSTERED ([c_Id] ASC) ON [PRIMARY]
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Country] SET (LOCK_ESCALATION = TABLE);
GO

