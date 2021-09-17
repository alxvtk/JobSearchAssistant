/****** Object: Table [dbo].[jsa_Document]   Script Date: 2021-09-14 6:52:28 PM ******/
USE [JobSearchAssistant];
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[jsa_Document]') AND type in (N'U'))
 BEGIN
  DROP TABLE [dbo].[jsa_Document];
 END
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE [dbo].[jsa_Document] 
(
 [d_Id] int NOT NULL,
 [d_UrlId] int NULL,
 [d_EmailId] int NULL,
 [d_DocFormatId] int NULL,
 [d_Body] varchar(8000) NULL,
 [d_FullPath] varchar(260) NULL,
 CONSTRAINT [PK__d_Id] PRIMARY KEY CLUSTERED ([d_Id] ASC)  ON [PRIMARY],
 CONSTRAINT [FK__d_UrlId_2_u_Id] FOREIGN KEY ([d_UrlId]) REFERENCES [jsa_Url] ( [u_Id] ),
 CONSTRAINT [FK__d_DocFormatId_2_df_Id] FOREIGN KEY ([d_DocFormatId]) REFERENCES [jsa_DocFormat] ( [df_Id] ),
 CONSTRAINT [FK__d_EmailId_2_e_Id] FOREIGN KEY ([d_EmailId]) REFERENCES [jsa_Email] ( [e_Id] )
)
ON [PRIMARY];
GO
ALTER TABLE [dbo].[jsa_Document] SET (LOCK_ESCALATION = TABLE);
GO
