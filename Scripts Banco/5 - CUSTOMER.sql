SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CUSTOMER](
	[ID] [int] NOT NULL IDENTITY,
	[LOGIN] [varchar](20) NULL,
	[NAME] [varchar](150) NULL,
	[EMAIL] [varchar](150) NOT NULL,
	[TELEPHONE] [varchar](30) NOT NULL,
	[ADRESS] [varchar](200) NOT NULL,
	[NUMBER] [varchar](30) NOT NULL,
	[OPTIONAL_ADRESS] [varchar](100) NULL,
	[ACCESS_KEY] [varchar](32) NOT NULL,
	[IMAGE_PATH] [varchar](150) NULL,
	[ID_PERMISSION] [int] NOT NULL,
 CONSTRAINT [PK_CUSTOMER] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CUSTOMER]  WITH CHECK ADD  CONSTRAINT [FK_CUSTOMER_PERMISSION] FOREIGN KEY([ID_PERMISSION])
REFERENCES [dbo].[PERMISSION] ([ID])
GO