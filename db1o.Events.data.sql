SET IDENTITY_INSERT [dbo].[Events] ON
INSERT INTO [dbo].[Events] ([id], [text], [start_date], [end_date], [room_id], [user_id]) VALUES (1, N'Pierwszy', N'2016-10-28 23:00:00', N'2016-10-29 00:00:00', 1, 1)
INSERT INTO [dbo].[Events] ([id], [text], [start_date], [end_date], [room_id], [user_id]) VALUES (2, N'Drugi', N'2016-10-29 00:00:00', N'2016-10-29 01:00:00', 2, 2)
INSERT INTO [dbo].[Events] ([id], [text], [start_date], [end_date], [room_id], [user_id]) VALUES (3, N'Trzeci', N'2016-10-29 01:00:00', N'2016-10-29 02:00:00', 3, 3)
INSERT INTO [dbo].[Events] ([id], [text], [start_date], [end_date], [room_id], [user_id]) VALUES (4, N'Czwarty', N'2016-10-29 02:00:00', N'2016-10-29 03:00:00', 1, 4)
INSERT INTO [dbo].[Events] ([id], [text], [start_date], [end_date], [room_id], [user_id]) VALUES (5, N'Piaty', N'2016-10-29 03:00:00', N'2016-10-29 04:00:00', 2, 1)
INSERT INTO [dbo].[Events] ([id], [text], [start_date], [end_date], [room_id], [user_id]) VALUES (6, N'Szosty', N'2016-10-29 04:00:00', N'2016-10-29 05:00:00', 3, 2)
INSERT INTO [dbo].[Events] ([id], [text], [start_date], [end_date], [room_id], [user_id]) VALUES (7, N'Siudmy', N'2016-10-29 05:00:00', N'2016-10-29 06:00:00', 2, 3)
INSERT INTO [dbo].[Events] ([id], [text], [start_date], [end_date], [room_id], [user_id]) VALUES (8, N'Osmy', N'2016-10-29 06:00:00', N'2016-10-29 07:00:00', 1, 3)
SET IDENTITY_INSERT [dbo].[Events] OFF
