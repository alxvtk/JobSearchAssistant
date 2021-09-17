/****** Object: Procedure [dbo].[proc_get_SourceTypes]   Script Date: 2021-08-24 7:21:08 PM ******/
USE [JobSearchAssistant];
GO
SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE PROCEDURE [dbo].[proc_get_SourceTypes]
AS
BEGIN
	select * from jsa_SourceType
		order by [st_Id]
END
GO