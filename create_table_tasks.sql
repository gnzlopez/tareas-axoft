CREATE TABLE [dbo].[Tasks](
	[IdTask] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[State] [int] NOT NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED 
(
	[IdTask] ASC
)
) ON [PRIMARY]


