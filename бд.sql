
CREATE TABLE [dbo].[�����](
	[id_�����] [int] NOT NULL,
	[��������] [nvarchar](80) NULL,
	[���_�����] [nvarchar](80) NULL,
	[�����_���] [int] NULL,
	[���������_�����] [money] NULL,
 CONSTRAINT [PK_�����] PRIMARY KEY CLUSTERED 
(
	[id_�����] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[�����_��_�����]    Script Date: 01.02.2023 10:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[�����_��_�����](
	[id_�����] [int] NOT NULL,
	[����������_������] [int] NULL,
	[����_�������������] [date] NULL,
	[�����_������] [money] NULL,
	[�����_������] [int] NULL,
	[id_�������] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[�������]    Script Date: 01.02.2023 10:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[�������](
	[id_�������] [int] NOT NULL,
	[�����_�����_����������] [int] NULL,
	[���] [nvarchar](80) NULL,
	[�������] [nvarchar](16) NULL,
	[id_������������] [int] NULL,
 CONSTRAINT [PK_�������] PRIMARY KEY CLUSTERED 
(
	[id_�������] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[������������]    Script Date: 01.02.2023 10:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[������������](
	[id_������������] [int] NOT NULL,
	[�����] [nvarchar](50) NULL,
	[������] [nvarchar](50) NULL,
	[����] [nvarchar](50) NULL,
 CONSTRAINT [PK_������������] PRIMARY KEY CLUSTERED 
(
	[id_������������] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[��������]    Script Date: 01.02.2023 10:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[��������](
	[id_��������] [int] NOT NULL,
	[��������_��������] [nvarchar](80) NULL,
	[������������] [float] NULL,
	[���_��������] [float] NULL,
	[����_��������] [float] NULL,
 CONSTRAINT [PK_��������] PRIMARY KEY CLUSTERED 
(
	[id_��������] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[�������]    Script Date: 01.02.2023 10:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[�������](
	[id_�����] [int] NOT NULL,
	[id_��������] [int] NOT NULL,
	[�����_�������������] [int] NULL,
	[������] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[�����] ([id_�����], [��������], [���_�����], [�����_���], [���������_�����]) VALUES (1, N'������� ��������', N'�������', 400, 300.0000)
GO
INSERT [dbo].[�����] ([id_�����], [��������], [���_�����], [�����_���], [���������_�����]) VALUES (2, N'����', N'����', 530, 436.0000)
GO
INSERT [dbo].[�����] ([id_�����], [��������], [���_�����], [�����_���], [���������_�����]) VALUES (3, N'�������', N'�������', 360, 470.0000)
GO
INSERT [dbo].[�����] ([id_�����], [��������], [���_�����], [�����_���], [���������_�����]) VALUES (4, N'������', N'�����', 350, 350.0000)
GO
INSERT [dbo].[�����] ([id_�����], [��������], [���_�����], [�����_���], [���������_�����]) VALUES (5, N'���������', N'�����', 240, 500.0000)
GO
INSERT [dbo].[�����_��_�����] ([id_�����], [����������_������], [����_�������������], [�����_������], [�����_������], [id_�������]) VALUES (1, 3, CAST(N'2023-01-22' AS Date), 2356.0000, 1, 1)
GO
INSERT [dbo].[�����_��_�����] ([id_�����], [����������_������], [����_�������������], [�����_������], [�����_������], [id_�������]) VALUES (3, 7, CAST(N'2023-01-23' AS Date), 12567.0000, 2, 2)
GO
INSERT [dbo].[�����_��_�����] ([id_�����], [����������_������], [����_�������������], [�����_������], [�����_������], [id_�������]) VALUES (2, 9, CAST(N'2023-01-24' AS Date), 4569.0000, 3, 3)
GO
INSERT [dbo].[�����_��_�����] ([id_�����], [����������_������], [����_�������������], [�����_������], [�����_������], [id_�������]) VALUES (4, 5, CAST(N'2023-01-23' AS Date), 2256.0000, 4, 4)
GO
INSERT [dbo].[�����_��_�����] ([id_�����], [����������_������], [����_�������������], [�����_������], [�����_������], [id_�������]) VALUES (5, 13, CAST(N'2023-01-22' AS Date), 9752.0000, 5, 5)
GO
INSERT [dbo].[�������] ([id_�������], [�����_�����_����������], [���], [�������], [id_������������]) VALUES (1, 123, N'������� ������ ���������', N'89535782345', 4)
GO
INSERT [dbo].[�������] ([id_�������], [�����_�����_����������], [���], [�������], [id_������������]) VALUES (2, 234, N'������� ����', N'89539873526', 4)
GO
INSERT [dbo].[�������] ([id_�������], [�����_�����_����������], [���], [�������], [id_������������]) VALUES (3, 345, N'������� �����', N'89535671122', 5)
GO
INSERT [dbo].[�������] ([id_�������], [�����_�����_����������], [���], [�������], [id_������������]) VALUES (4, 456, N'������ ������ ����������', N'89213472875', 5)
GO
INSERT [dbo].[�������] ([id_�������], [�����_�����_����������], [���], [�������], [id_������������]) VALUES (5, 567, N'�������� ������ ��������', N'89048674632', 5)
GO
INSERT [dbo].[������������] ([id_������������], [�����], [������], [����]) VALUES (1, N'admin', N'1234', N'�����')
GO
INSERT [dbo].[������������] ([id_������������], [�����], [������], [����]) VALUES (2, N'shef', N'1357', N'���')
GO
INSERT [dbo].[������������] ([id_������������], [�����], [������], [����]) VALUES (3, N'offik', N'2468', N'��������')
GO
INSERT [dbo].[������������] ([id_������������], [�����], [������], [����]) VALUES (4, N'user', N'0000', N'������������')
GO
INSERT [dbo].[������������] ([id_������������], [�����], [������], [����]) VALUES (5, N'user1', N'0001', N'������������')
GO
INSERT [dbo].[��������] ([id_��������], [��������_��������], [������������], [���_��������], [����_��������]) VALUES (1, N'�����', 120, 200, 350)
GO
INSERT [dbo].[��������] ([id_��������], [��������_��������], [������������], [���_��������], [����_��������]) VALUES (2, N'�������� ���������', 346, 400, 1300)
GO
INSERT [dbo].[��������] ([id_��������], [��������_��������], [������������], [���_��������], [����_��������]) VALUES (3, N'��������', 273, 100, 700)
GO
INSERT [dbo].[��������] ([id_��������], [��������_��������], [������������], [���_��������], [����_��������]) VALUES (4, N'������', 300, 500, 320)
GO
INSERT [dbo].[��������] ([id_��������], [��������_��������], [������������], [���_��������], [����_��������]) VALUES (5, N'������ ������', 56, 140, 230)
GO
INSERT [dbo].[��������] ([id_��������], [��������_��������], [������������], [���_��������], [����_��������]) VALUES (6, N'�������', 68, 480, 90)
GO
INSERT [dbo].[��������] ([id_��������], [��������_��������], [������������], [���_��������], [����_��������]) VALUES (7, N'�����', 600, 570, 950)
GO
INSERT [dbo].[�������] ([id_�����], [id_��������], [�����_�������������], [������]) VALUES (2, 6, 15, N'������������� �������')
GO
INSERT [dbo].[�������] ([id_�����], [id_��������], [�����_�������������], [������]) VALUES (2, 5, 3, N'�������� � ���������� ������')
GO
INSERT [dbo].[�������] ([id_�����], [id_��������], [�����_�������������], [������]) VALUES (2, 2, 30, N'������������� ��������� �������')
GO
ALTER TABLE [dbo].[�����_��_�����]  WITH CHECK ADD  CONSTRAINT [FK_�����_��_�����_�����] FOREIGN KEY([id_�����])
REFERENCES [dbo].[�����] ([id_�����])
GO
ALTER TABLE [dbo].[�����_��_�����] CHECK CONSTRAINT [FK_�����_��_�����_�����]
GO
ALTER TABLE [dbo].[�����_��_�����]  WITH CHECK ADD  CONSTRAINT [FK_�����_��_�����_�������] FOREIGN KEY([id_�������])
REFERENCES [dbo].[�������] ([id_�������])
GO
ALTER TABLE [dbo].[�����_��_�����] CHECK CONSTRAINT [FK_�����_��_�����_�������]
GO
ALTER TABLE [dbo].[�������]  WITH CHECK ADD  CONSTRAINT [FK_�������_������������] FOREIGN KEY([id_������������])
REFERENCES [dbo].[������������] ([id_������������])
GO
ALTER TABLE [dbo].[�������] CHECK CONSTRAINT [FK_�������_������������]
GO
ALTER TABLE [dbo].[�������]  WITH CHECK ADD  CONSTRAINT [FK_�������_�����] FOREIGN KEY([id_�����])
REFERENCES [dbo].[�����] ([id_�����])
GO
ALTER TABLE [dbo].[�������] CHECK CONSTRAINT [FK_�������_�����]
GO
ALTER TABLE [dbo].[�������]  WITH CHECK ADD  CONSTRAINT [FK_�������_��������] FOREIGN KEY([id_��������])
REFERENCES [dbo].[��������] ([id_��������])
GO
ALTER TABLE [dbo].[�������] CHECK CONSTRAINT [FK_�������_��������]
