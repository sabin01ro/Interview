
USE [Interview]
GO
	BEGIN TRY
		BEGIN TRANSACTION 

		SET ANSI_NULLS ON

		SET QUOTED_IDENTIFIER ON
		
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


			ALTER TABLE [dbo].[Employees] ADD  DEFAULT (newid()) FOR [ID]
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
 
