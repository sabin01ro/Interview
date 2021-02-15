USE [Interview]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 12/02/2021 03:04:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[ID] [uniqueidentifier] NOT NULL,
	[Title] [nvarchar](10) NULL,
	[First_Name] [nvarchar](50) NULL,
	[Last_Name] [nvarchar](50) NULL,
	[Sex] [nvarchar](10) NULL,
	[Date_Of_Birth] [date] NULL,
	[Email] [nvarchar](255) NULL,
	[Job_Title] [nvarchar](255) NULL,
	[Salary] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Employees] ADD  DEFAULT (newid()) FOR [ID]
GO


