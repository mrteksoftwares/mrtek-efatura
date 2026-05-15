
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Items]') AND type in (N'U'))
DROP TABLE [dbo].[Items]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Items](
	[ItemID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Item_Name] [nvarchar](255) NULL DEFAULT '',
	[Item_Description] [nvarchar](255) NULL DEFAULT '',
	[GTIPNO] [nvarchar](255) NULL DEFAULT ''
)

GO

