SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_ITEM](
	[ID] [int] NOT NULL IDENTITY,
	[QUANTITY] [int] NOT NULL,
	[PRICE] [decimal](18, 0) NOT NULL,
	[ID_PRODUTO] [int] NOT NULL,
	[ID_ORDER] [int] NOT NULL,
 CONSTRAINT [PK_ORDER_ITEM] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ORDER_ITEM]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_ITEM_MENU] FOREIGN KEY([ID_PRODUTO])
REFERENCES [dbo].[MENU] ([ID])
GO
ALTER TABLE [dbo].[ORDER_ITEM] CHECK CONSTRAINT [FK_ORDER_ITEM_MENU]
GO
ALTER TABLE [dbo].[ORDER_ITEM]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_ITEM_ORDER] FOREIGN KEY([ID_ORDER])
REFERENCES [dbo].[ORDER] ([ID])
GO
ALTER TABLE [dbo].[ORDER_ITEM] CHECK CONSTRAINT [FK_ORDER_ITEM_ORDER]
GO
