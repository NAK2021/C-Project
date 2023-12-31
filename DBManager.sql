USE [DBManager2]
GO
/****** Object:  Table [dbo].[Academic_Affair]    Script Date: 12/10/2023 11:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Academic_Affair](
	[id] [nvarchar](100) NOT NULL,
	[username] [nvarchar](50) NULL,
	[name_] [nvarchar](50) NULL,
	[dob] [nvarchar](20) NULL,
	[phone_num] [nvarchar](15) NULL,
	[department_id] [nvarchar](10) NULL,
	[picture] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 12/10/2023 11:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[id] [nvarchar](100) NOT NULL,
	[usename] [nvarchar](50) NULL,
	[name_] [nvarchar](50) NULL,
	[dob] [nvarchar](20) NULL,
	[phone_num] [nvarchar](15) NULL,
	[picture] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 12/10/2023 11:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[class_id] [int] NOT NULL,
	[date_start] [nvarchar](20) NULL,
	[date_end] [nvarchar](20) NULL,
	[room] [nvarchar](50) NULL,
	[capacity] [int] NULL,
	[days_] [nvarchar](20) NULL,
	[section_start] [time](7) NULL,
	[section_end] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[class_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 12/10/2023 11:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[department_id] [nvarchar](10) NOT NULL,
	[department_name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[department_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lecture]    Script Date: 12/10/2023 11:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lecture](
	[id] [nvarchar](100) NOT NULL,
	[email] [varchar](50) NULL,
	[name_] [nvarchar](50) NULL,
	[dob] [nvarchar](20) NULL,
	[phone_num] [nvarchar](15) NULL,
	[department_id] [nvarchar](20) NULL,
	[status_] [nvarchar](20) NULL,
	[Teaching_Experience] [int] NULL,
	[Academic_rank] [nvarchar](20) NULL,
	[picture] [image] NULL,
	[assigned_subjects] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LectureRegisClass]    Script Date: 12/10/2023 11:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LectureRegisClass](
	[id] [nvarchar](100) NOT NULL,
	[class_id] [int] NOT NULL,
	[date_register] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[class_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LectureVio]    Script Date: 12/10/2023 11:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LectureVio](
	[id] [nvarchar](100) NOT NULL,
	[rules_id] [int] NOT NULL,
	[status_] [nvarchar](50) NULL,
	[date_] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[rules_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OpenClass]    Script Date: 12/10/2023 11:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OpenClass](
	[course_id] [nvarchar](10) NOT NULL,
	[class_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[course_id] ASC,
	[class_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 12/10/2023 11:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[id] [nvarchar](100) NOT NULL,
	[name_] [nvarchar](50) NULL,
	[school_year] [nvarchar](50) NULL,
	[dob] [nvarchar](50) NULL,
	[phone_num] [nvarchar](15) NULL,
	[department_id] [nvarchar](10) NULL,
	[tot_cred] [int] NULL,
	[status_] [nvarchar](50) NULL,
	[picture] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentRegisClass]    Script Date: 12/10/2023 11:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentRegisClass](
	[id] [nvarchar](100) NOT NULL,
	[class_id] [int] NOT NULL,
	[date_register] [nvarchar](20) NULL,
	[status_] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[class_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentVio]    Script Date: 12/10/2023 11:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentVio](
	[id] [nvarchar](100) NOT NULL,
	[rules_id] [int] NOT NULL,
	[status_] [nvarchar](50) NULL,
	[date_] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[rules_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject_]    Script Date: 12/10/2023 11:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject_](
	[course_id] [nvarchar](10) NOT NULL,
	[course_name] [nvarchar](50) NULL,
	[department_id] [nvarchar](10) NULL,
	[credits] [int] NULL,
	[cost] [numeric](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[course_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/10/2023 11:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [nvarchar](100) NOT NULL,
	[password_] [nvarchar](50) NULL,
	[role_] [nvarchar](20) NULL,
	[pin] [nvarchar](6) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Violate]    Script Date: 12/10/2023 11:40:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Violate](
	[rules_id] [int] NOT NULL,
	[rules_name] [nvarchar](50) NULL,
	[rules_punishment] [nvarchar](50) NULL,
	[object_] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[rules_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Academic_Affair]  WITH CHECK ADD FOREIGN KEY([department_id])
REFERENCES [dbo].[Department] ([department_id])
GO
ALTER TABLE [dbo].[Academic_Affair]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Lecture]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[LectureRegisClass]  WITH CHECK ADD FOREIGN KEY([class_id])
REFERENCES [dbo].[Class] ([class_id])
GO
ALTER TABLE [dbo].[LectureRegisClass]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[Lecture] ([id])
GO
ALTER TABLE [dbo].[LectureVio]  WITH CHECK ADD FOREIGN KEY([rules_id])
REFERENCES [dbo].[Violate] ([rules_id])
GO
ALTER TABLE [dbo].[LectureVio]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[Lecture] ([id])
GO
ALTER TABLE [dbo].[OpenClass]  WITH CHECK ADD FOREIGN KEY([class_id])
REFERENCES [dbo].[Class] ([class_id])
GO
ALTER TABLE [dbo].[OpenClass]  WITH CHECK ADD FOREIGN KEY([course_id])
REFERENCES [dbo].[Subject_] ([course_id])
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD FOREIGN KEY([department_id])
REFERENCES [dbo].[Department] ([department_id])
GO
ALTER TABLE [dbo].[StudentRegisClass]  WITH CHECK ADD FOREIGN KEY([class_id])
REFERENCES [dbo].[Class] ([class_id])
GO
ALTER TABLE [dbo].[StudentRegisClass]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[Student] ([id])
GO
ALTER TABLE [dbo].[StudentVio]  WITH CHECK ADD FOREIGN KEY([rules_id])
REFERENCES [dbo].[Violate] ([rules_id])
GO
ALTER TABLE [dbo].[StudentVio]  WITH CHECK ADD FOREIGN KEY([id])
REFERENCES [dbo].[Student] ([id])
GO
ALTER TABLE [dbo].[Subject_]  WITH CHECK ADD FOREIGN KEY([department_id])
REFERENCES [dbo].[Department] ([department_id])
GO
