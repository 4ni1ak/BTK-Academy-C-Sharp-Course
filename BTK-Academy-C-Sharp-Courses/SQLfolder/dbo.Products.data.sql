SET IDENTITY_INSERT [dbo].[Products] ON
INSERT INTO [dbo].[Products] ([Id], [Name], [UnitPrice], [StockAmount]) VALUES (1, N'Laptop', CAST(3000.0000 AS Money), 21)
SET IDENTITY_INSERT [dbo].[Products] OFF
