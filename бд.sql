
CREATE TABLE [dbo].[Блюда](
	[id_блюда] [int] NOT NULL,
	[Название] [nvarchar](80) NULL,
	[Вид_блюда] [nvarchar](80) NULL,
	[Выход_вес] [int] NULL,
	[Стоимость_блюда] [money] NULL,
 CONSTRAINT [PK_Блюда] PRIMARY KEY CLUSTERED 
(
	[id_блюда] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Заказ_На_Блюда]    Script Date: 01.02.2023 10:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Заказ_На_Блюда](
	[id_блюда] [int] NOT NULL,
	[Количество_Порций] [int] NULL,
	[Дата_Приготовления] [date] NULL,
	[Сумма_заказа] [money] NULL,
	[Номер_заказа] [int] NULL,
	[id_Клиента] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Клиенты]    Script Date: 01.02.2023 10:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Клиенты](
	[id_Клиента] [int] NOT NULL,
	[номер_карты_лояльности] [int] NULL,
	[ФИО] [nvarchar](80) NULL,
	[телефон] [nvarchar](16) NULL,
	[id_пользователя] [int] NULL,
 CONSTRAINT [PK_Клиенты] PRIMARY KEY CLUSTERED 
(
	[id_Клиента] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Пользователи]    Script Date: 01.02.2023 10:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Пользователи](
	[id_пользователя] [int] NOT NULL,
	[логин] [nvarchar](50) NULL,
	[пароль] [nvarchar](50) NULL,
	[роль] [nvarchar](50) NULL,
 CONSTRAINT [PK_Пользователи] PRIMARY KEY CLUSTERED 
(
	[id_пользователя] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Продукты]    Script Date: 01.02.2023 10:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Продукты](
	[id_продукта] [int] NOT NULL,
	[Название_продукта] [nvarchar](80) NULL,
	[Калорийность] [float] NULL,
	[Вес_продукта] [float] NULL,
	[Цена_продукта] [float] NULL,
 CONSTRAINT [PK_Продукты] PRIMARY KEY CLUSTERED 
(
	[id_продукта] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[рецепты]    Script Date: 01.02.2023 10:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[рецепты](
	[id_блюда] [int] NOT NULL,
	[id_продукта] [int] NOT NULL,
	[Время_приготовления] [int] NULL,
	[Рецепт] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Блюда] ([id_блюда], [Название], [Вид_блюда], [Выход_вес], [Стоимость_блюда]) VALUES (1, N'Жареные Пельмеши', N'Горячее', 400, 300.0000)
GO
INSERT [dbo].[Блюда] ([id_блюда], [Название], [Вид_блюда], [Выход_вес], [Стоимость_блюда]) VALUES (2, N'Борщ', N'Супы', 530, 436.0000)
GO
INSERT [dbo].[Блюда] ([id_блюда], [Название], [Вид_блюда], [Выход_вес], [Стоимость_блюда]) VALUES (3, N'Лазанья', N'Горячее', 360, 470.0000)
GO
INSERT [dbo].[Блюда] ([id_блюда], [Название], [Вид_блюда], [Выход_вес], [Стоимость_блюда]) VALUES (4, N'Цезарь', N'Салат', 350, 350.0000)
GO
INSERT [dbo].[Блюда] ([id_блюда], [Название], [Вид_блюда], [Выход_вес], [Стоимость_блюда]) VALUES (5, N'Карбонара', N'Паста', 240, 500.0000)
GO
INSERT [dbo].[Заказ_На_Блюда] ([id_блюда], [Количество_Порций], [Дата_Приготовления], [Сумма_заказа], [Номер_заказа], [id_Клиента]) VALUES (1, 3, CAST(N'2023-01-22' AS Date), 2356.0000, 1, 1)
GO
INSERT [dbo].[Заказ_На_Блюда] ([id_блюда], [Количество_Порций], [Дата_Приготовления], [Сумма_заказа], [Номер_заказа], [id_Клиента]) VALUES (3, 7, CAST(N'2023-01-23' AS Date), 12567.0000, 2, 2)
GO
INSERT [dbo].[Заказ_На_Блюда] ([id_блюда], [Количество_Порций], [Дата_Приготовления], [Сумма_заказа], [Номер_заказа], [id_Клиента]) VALUES (2, 9, CAST(N'2023-01-24' AS Date), 4569.0000, 3, 3)
GO
INSERT [dbo].[Заказ_На_Блюда] ([id_блюда], [Количество_Порций], [Дата_Приготовления], [Сумма_заказа], [Номер_заказа], [id_Клиента]) VALUES (4, 5, CAST(N'2023-01-23' AS Date), 2256.0000, 4, 4)
GO
INSERT [dbo].[Заказ_На_Блюда] ([id_блюда], [Количество_Порций], [Дата_Приготовления], [Сумма_заказа], [Номер_заказа], [id_Клиента]) VALUES (5, 13, CAST(N'2023-01-22' AS Date), 9752.0000, 5, 5)
GO
INSERT [dbo].[Клиенты] ([id_Клиента], [номер_карты_лояльности], [ФИО], [телефон], [id_пользователя]) VALUES (1, 123, N'Киселев Михаил Андреевич', N'89535782345', 4)
GO
INSERT [dbo].[Клиенты] ([id_Клиента], [номер_карты_лояльности], [ФИО], [телефон], [id_пользователя]) VALUES (2, 234, N'Мусевич Марк', N'89539873526', 4)
GO
INSERT [dbo].[Клиенты] ([id_Клиента], [номер_карты_лояльности], [ФИО], [телефон], [id_пользователя]) VALUES (3, 345, N'Куржиев Ислам', N'89535671122', 5)
GO
INSERT [dbo].[Клиенты] ([id_Клиента], [номер_карты_лояльности], [ФИО], [телефон], [id_пользователя]) VALUES (4, 456, N'Юргель Таисия Дмитриевна', N'89213472875', 5)
GO
INSERT [dbo].[Клиенты] ([id_Клиента], [номер_карты_лояльности], [ФИО], [телефон], [id_пользователя]) VALUES (5, 567, N'Курьяков Даниил Игоревич', N'89048674632', 5)
GO
INSERT [dbo].[Пользователи] ([id_пользователя], [логин], [пароль], [роль]) VALUES (1, N'admin', N'1234', N'админ')
GO
INSERT [dbo].[Пользователи] ([id_пользователя], [логин], [пароль], [роль]) VALUES (2, N'shef', N'1357', N'шеф')
GO
INSERT [dbo].[Пользователи] ([id_пользователя], [логин], [пароль], [роль]) VALUES (3, N'offik', N'2468', N'официант')
GO
INSERT [dbo].[Пользователи] ([id_пользователя], [логин], [пароль], [роль]) VALUES (4, N'user', N'0000', N'пользователь')
GO
INSERT [dbo].[Пользователи] ([id_пользователя], [логин], [пароль], [роль]) VALUES (5, N'user1', N'0001', N'пользователь')
GO
INSERT [dbo].[Продукты] ([id_продукта], [Название_продукта], [Калорийность], [Вес_продукта], [Цена_продукта]) VALUES (1, N'Тесто', 120, 200, 350)
GO
INSERT [dbo].[Продукты] ([id_продукта], [Название_продукта], [Калорийность], [Вес_продукта], [Цена_продукта]) VALUES (2, N'Говядина рубленная', 346, 400, 1300)
GO
INSERT [dbo].[Продукты] ([id_продукта], [Название_продукта], [Калорийность], [Вес_продукта], [Цена_продукта]) VALUES (3, N'Канилони', 273, 100, 700)
GO
INSERT [dbo].[Продукты] ([id_продукта], [Название_продукта], [Калорийность], [Вес_продукта], [Цена_продукта]) VALUES (4, N'Сливки', 300, 500, 320)
GO
INSERT [dbo].[Продукты] ([id_продукта], [Название_продукта], [Калорийность], [Вес_продукта], [Цена_продукта]) VALUES (5, N'Зелень свежая', 56, 140, 230)
GO
INSERT [dbo].[Продукты] ([id_продукта], [Название_продукта], [Калорийность], [Вес_продукта], [Цена_продукта]) VALUES (6, N'Капуста', 68, 480, 90)
GO
INSERT [dbo].[Продукты] ([id_продукта], [Название_продукта], [Калорийность], [Вес_продукта], [Цена_продукта]) VALUES (7, N'Бекон', 600, 570, 950)
GO
INSERT [dbo].[рецепты] ([id_блюда], [id_продукта], [Время_приготовления], [Рецепт]) VALUES (2, 6, 15, N'Приготовление капусты')
GO
INSERT [dbo].[рецепты] ([id_блюда], [id_продукта], [Время_приготовления], [Рецепт]) VALUES (2, 5, 3, N'Шинковка и добавление зелени')
GO
INSERT [dbo].[рецепты] ([id_блюда], [id_продукта], [Время_приготовления], [Рецепт]) VALUES (2, 2, 30, N'Приготовление говяжьего бульона')
GO
ALTER TABLE [dbo].[Заказ_На_Блюда]  WITH CHECK ADD  CONSTRAINT [FK_Заказ_На_Блюда_Блюда] FOREIGN KEY([id_блюда])
REFERENCES [dbo].[Блюда] ([id_блюда])
GO
ALTER TABLE [dbo].[Заказ_На_Блюда] CHECK CONSTRAINT [FK_Заказ_На_Блюда_Блюда]
GO
ALTER TABLE [dbo].[Заказ_На_Блюда]  WITH CHECK ADD  CONSTRAINT [FK_Заказ_На_Блюда_Клиенты] FOREIGN KEY([id_Клиента])
REFERENCES [dbo].[Клиенты] ([id_Клиента])
GO
ALTER TABLE [dbo].[Заказ_На_Блюда] CHECK CONSTRAINT [FK_Заказ_На_Блюда_Клиенты]
GO
ALTER TABLE [dbo].[Клиенты]  WITH CHECK ADD  CONSTRAINT [FK_Клиенты_Пользователи] FOREIGN KEY([id_пользователя])
REFERENCES [dbo].[Пользователи] ([id_пользователя])
GO
ALTER TABLE [dbo].[Клиенты] CHECK CONSTRAINT [FK_Клиенты_Пользователи]
GO
ALTER TABLE [dbo].[рецепты]  WITH CHECK ADD  CONSTRAINT [FK_рецепты_Блюда] FOREIGN KEY([id_блюда])
REFERENCES [dbo].[Блюда] ([id_блюда])
GO
ALTER TABLE [dbo].[рецепты] CHECK CONSTRAINT [FK_рецепты_Блюда]
GO
ALTER TABLE [dbo].[рецепты]  WITH CHECK ADD  CONSTRAINT [FK_рецепты_Продукты] FOREIGN KEY([id_продукта])
REFERENCES [dbo].[Продукты] ([id_продукта])
GO
ALTER TABLE [dbo].[рецепты] CHECK CONSTRAINT [FK_рецепты_Продукты]
