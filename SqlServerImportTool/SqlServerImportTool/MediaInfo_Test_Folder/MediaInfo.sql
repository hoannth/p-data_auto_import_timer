USE [MediaInfo]
GO
/****** Object:  Table [dbo].[media_info_tbl]    Script Date: 8/16/2015 5:33:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[media_info_tbl](
	[Brochure_ID] [int] NOT NULL,
	[Is_Published] [nvarchar](50) NULL,
	[Property_Name] [nvarchar](120) NULL,
	[Brand] [nvarchar](50) NULL,
	[Primary_HR_ID] [int] NULL,
	[Photos] [int] NULL,
	[HD360s] [int] NULL,
	[Videos] [int] NULL,
	[iFrames] [int] NULL,
 CONSTRAINT [PK_MediaInfo] PRIMARY KEY CLUSTERED 
(
	[Brochure_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
