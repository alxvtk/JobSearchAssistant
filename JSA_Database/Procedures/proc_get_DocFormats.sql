/****** Object: Procedure [dbo].[proc_get_DocFormats]   Script Date: 2021-08-24 7:08:04 PM ******/
USE [JobSearchAssistant];
GO
SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE PROCEDURE [dbo].[proc_get_DocFormats]
AS
BEGIN
	select * from jsa_DocFormat
	order by [df_Id];
END
GO