USE [SCHEDULE]
GO
/****** Object:  Table [dbo].[TASK]    Script Date: 1/14/2023 3:45:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TASK](
	[TASKNAME] [nvarchar](max) NOT NULL,
	[TASKDETAIL] [nvarchar](max) NULL,
	[HSTART] [int] NOT NULL,
	[MSTART] [int] NOT NULL,
	[PERIOD] [int] NOT NULL,
	[DAY] [int] NOT NULL,
	[MONTH] [int] NOT NULL,
	[YEAR] [int] NOT NULL,
	[PRIORITY] [nvarchar](100) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Get ready and go to work', N'', 7, 30, 0, 1, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Add Laidsiv paper to CV', N'', 9, 0, 30, 1, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Write YFA grand report', N'', 10, 0, 15, 1, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Dinner', N'', 12, 0, 45, 1, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Practice playing guitar', N'', 15, 0, 90, 1, 1, 2023, N'Study')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Perceptive meeting with classmates', N'', 8, 0, 60, 2, 1, 2023, N'Study')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Have lunch with classmates', N'', 9, 0, 30, 2, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Planning for next semester courses', N'', 11, 0, 15, 2, 1, 2023, N'Study')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Have a look at articles Phong sent', N'', 13, 0, 45, 2, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Sleep in', N'', 7, 0, 60, 4, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Cook a lunch', N'', 9, 0, 30, 4, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Online group meeting', N'', 11, 30, 30, 4, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Algorithmic art coding', N'', 13, 0, 60, 4, 1, 2023, N'Study')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Have a day off', N'', 7, 0, 0, 5, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Call mom', N'', 9, 0, 0, 5, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Get ready to work', N'', 7, 30, 0, 6, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'AI guest interview', N'', 9, 0, 70, 6, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Short Break', N'', 11, 0, 25, 6, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Meet RE candidates', N'', 13, 30, 40, 6, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Look into Atlas department', N'', 8, 0, 90, 7, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Call Shankar & Gulpreet', N'', 10, 30, 30, 7, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Write time managment for next course', N'', 11, 30, 60, 7, 1, 2023, N'Study')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Ready to Work', N'', 7, 30, 0, 9, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Answer questions in journal', N'', 10, 30, 45, 9, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Mark guitar class status', N'', 14, 20, 60, 9, 1, 2023, N'Study')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Meeting Julie & Andy', N'', 16, 0, 60, 9, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Sleep in', N'', 7, 30, 0, 10, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Maria''s Q and A', N'', 9, 30, 15, 10, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Read articles Dory sent', N'', 11, 30, 30, 10, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Have a day off', N'', 7, 30, 0, 12, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Cooking a meal for family', N'', 9, 0, 30, 12, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Practice guitar', N'', 16, 0, 60, 12, 1, 2023, N'Study')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Get ready to work', N'', 7, 30, 0, 13, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Have a look at Lif''s data', N'', 9, 30, 15, 13, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Break and Dinner', N'', 10, 30, 30, 13, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Watching Black Mirror', N'', 16, 30, 90, 13, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Get ready and go to work', N'', 7, 30, 0, 15, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Plan PRCV18', N'', 9, 0, 30, 15, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Dinner', N'', 10, 30, 30, 15, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Finish the last assignments', N'', 14, 30, 60, 15, 1, 2023, N'Study')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Nanny''s birthday', N'', 7, 30, 0, 17, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Take a day off', N'', 6, 30, 0, 17, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'let Brian know about sudden change', N'', 9, 30, 15, 17, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Get ready and go to work', N'', 9, 0, 0, 18, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Finish the latest assignment report', N'', 10, 30, 45, 18, 1, 2023, N'Study')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Prepare for hiring meeting', N'', 13, 30, 45, 18, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Dinner', N'', 18, 30, 30, 18, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Have a day off', N'', 7, 30, 0, 19, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Support shift at 9p.m', N'', 19, 0, 30, 19, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Coworking at Latte cafe', N'', 9, 30, 0, 21, 1, 2023, N'Study')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Checking in with Bob', N'', 11, 30, 45, 21, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Get ready and go to work', N'', 7, 30, 30, 22, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Holding a conference with John', N'', 9, 30, 90, 22, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Call Bob', N'', 10, 30, 15, 22, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Brand Design course starts', N'', 14, 30, 90, 22, 1, 2023, N'Study')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Climbing day', N'', 7, 30, 0, 25, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Stop for a break and lunch', N'', 9, 30, 30, 25, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Updating photos to Instagram', N'', 11, 30, 15, 25, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Guitar practice', N'', 20, 30, 45, 25, 1, 2023, N'Study')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Get ready and go to work', N'', 7, 30, 0, 26, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Lunch', N'', 9, 30, 30, 26, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'End shift early', N'', 10, 30, 0, 26, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Attend UX/UI course', N'', 13, 20, 90, 26, 1, 2023, N'Study')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Work out', N'', 17, 30, 90, 26, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Attend Brand Design course', N'', 8, 30, 90, 27, 1, 2023, N'Study')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Meeting Tracy at the park', N'', 10, 30, 45, 27, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Re enabled studio work', N'', 13, 0, 60, 27, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Go to college for Ramesh''s presentation', N'', 7, 30, 90, 30, 1, 2023, N'Study')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Have lunch', N'', 11, 30, 30, 30, 1, 2023, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Get back to work', N'', 13, 30, 90, 30, 1, 2023, N'Work')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'task12', N'ádádádá', 4, 25, 30, 8, 2, 2023, N'Study')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'sada', N'ádád', 10, 0, 0, 10, 12, 2011, N'Other')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Study', N'eqưeq', 11, 8, 60, 14, 1, 2023, N'Study')
INSERT [dbo].[TASK] ([TASKNAME], [TASKDETAIL], [HSTART], [MSTART], [PERIOD], [DAY], [MONTH], [YEAR], [PRIORITY]) VALUES (N'Dinner', N'', 18, 0, 0, 30, 1, 2023, N'Other')
GO
