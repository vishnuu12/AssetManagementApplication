USE [AssetManagementSystemDB]
GO
/****** Object:  Table [dbo].[Assets]    Script Date: 9/15/2024 7:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assets](
	[AssetId] [int] IDENTITY(1,1) NOT NULL,
	[BrandName] [varchar](100) NOT NULL,
	[Description] [varchar](100) NULL,
	[AssetType] [varchar](100) NOT NULL,
	[CreatedTime] [datetime] NOT NULL,
	[CreatedBy] [varchar](100) NOT NULL,
	[ModifiedTime] [datetime] NULL,
	[ModifiedBy] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[AssetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 9/15/2024 7:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[PhoneNo] [varchar](100) NULL,
	[Email] [varchar](100) NOT NULL,
	[CreatedTime] [datetime] NOT NULL,
	[CreatedBy] [varchar](100) NOT NULL,
	[ModifiedTime] [datetime] NULL,
	[ModifiedBy] [varchar](100) NULL,
	[RoleId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 9/15/2024 7:50:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](100) NOT NULL,
	[Description] [varchar](100) NULL,
	[CreatedTime] [datetime] NOT NULL,
	[CreatedBy] [varchar](100) NOT NULL,
	[ModifiedTime] [datetime] NULL,
	[ModifiedBy] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Assets] ON 

INSERT [dbo].[Assets] ([AssetId], [BrandName], [Description], [AssetType], [CreatedTime], [CreatedBy], [ModifiedTime], [ModifiedBy]) VALUES (5, N'asas', N'string', N'vinith', CAST(N'2024-09-14T09:13:07.147' AS DateTime), N'la', NULL, NULL)
INSERT [dbo].[Assets] ([AssetId], [BrandName], [Description], [AssetType], [CreatedTime], [CreatedBy], [ModifiedTime], [ModifiedBy]) VALUES (6, N'string', N'string', N'string', CAST(N'2024-09-15T14:11:09.640' AS DateTime), N'string', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Assets] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeId], [Name], [PhoneNo], [Email], [CreatedTime], [CreatedBy], [ModifiedTime], [ModifiedBy], [RoleId]) VALUES (1002, N'aaa', N'aaa', N'aaa', CAST(N'2024-09-14T05:20:59.283' AS DateTime), N'aaa', NULL, NULL, 2)
INSERT [dbo].[Employee] ([EmployeeId], [Name], [PhoneNo], [Email], [CreatedTime], [CreatedBy], [ModifiedTime], [ModifiedBy], [RoleId]) VALUES (1005, N'string', N'string', N'string', CAST(N'2024-09-15T14:12:22.730' AS DateTime), N'string', NULL, NULL, 2)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleId], [RoleName], [Description], [CreatedTime], [CreatedBy], [ModifiedTime], [ModifiedBy]) VALUES (2, N'dada', N'dada', CAST(N'2024-09-14T05:22:20.723' AS DateTime), N'dada', NULL, NULL)
INSERT [dbo].[Role] ([RoleId], [RoleName], [Description], [CreatedTime], [CreatedBy], [ModifiedTime], [ModifiedBy]) VALUES (1002, N'aa', N'aaa', CAST(N'2024-09-12T17:00:45.630' AS DateTime), N'aaa', NULL, NULL)
INSERT [dbo].[Role] ([RoleId], [RoleName], [Description], [CreatedTime], [CreatedBy], [ModifiedTime], [ModifiedBy]) VALUES (1004, N'test', N'test', CAST(N'2024-09-13T17:39:00.470' AS DateTime), N'test', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([RoleId])
GO
