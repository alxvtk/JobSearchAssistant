/****** Object: Table [dbo].[jsa_Url2Business]   Script Date: 2021-09-13 8:34:01 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Url2Business]') AND type in (N'U'))
 BEGIN
  DROP TABLE [dbo].[jsa_Url2Business];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Url2Business] 
(
 [u2b_Id] int NOT NULL,
 [u2b_UrlId] int NOT NULL,
 [u2b_BusinessId] int NOT NULL,
 [u2b_Active] varchar(1) NOT NULL,
 CONSTRAINT [PK__u2b_Id] PRIMARY KEY CLUSTERED ([u2b_Id] ASC) ON [PRIMARY],
 CONSTRAINT [PK_u2b_UrlId_2_u_Id] FOREIGN KEY ([u2b_UrlId]) REFERENCES [jsa_Url] ( [u_Id] ),
 CONSTRAINT [PK_u2b_BusinessId_2_b_Id] FOREIGN KEY ([u2b_BusinessId]) REFERENCES [jsa_Business] ( [b_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Url2Business] SET (LOCK_ESCALATION = TABLE);
GO