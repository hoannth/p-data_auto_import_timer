USE [import_from_excel]
GO
/****** Object:  Table [dbo].[test_table]    Script Date: 8/5/2015 12:58:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test_table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[birthday] [datetime] NULL,
	[age] [int] NULL,
	[address] [nvarchar](100) NULL,
	[phone] [nchar](15) NULL,
 CONSTRAINT [PK_test_table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
