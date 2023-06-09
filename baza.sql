
CREATE DATABASE [Gym Managment]

USE [Gym Managment]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 03.02.2023 18:20:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](25) NOT NULL,
	[Surname] [nvarchar](25) NOT NULL,
	[Birth Date] [date] NOT NULL,
	[Telephone] [varchar](9) NOT NULL,
	[PESEL] [varchar](11) NOT NULL,
	[Pass Type] [int] NOT NULL,
	[Expiration Date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GymPasses]    Script Date: 03.02.2023 18:20:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GymPasses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](25) NOT NULL,
	[Price] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 03.02.2023 18:20:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Origin] [varchar](50) NOT NULL,
	[PayDate] [datetime] NOT NULL,
	[Sum] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 03.02.2023 18:20:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Price] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 03.02.2023 18:20:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] NOT NULL,
	[username] [varchar](25) NOT NULL,
	[password] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

Insert into [dbo].[GymPasses] (Name, Price) Values ("Open",120), ("Half-Open",100), ("Limited",90), ("Student",80), ("Jednorazowe",20)
GO

Insert into [dbo].[Users] (username, password) values ("Admin","Haslo")
GO

Insert into [dbo].[Clients] (Name,Surname,[Birth Date],Telephone,PESEL,[Pass Type],[Expiration Date]) Values ("Jakub","Kowalski","1997-04-04","777888777","9809809809",4,"2023-04-22"),
("Mateusz","Dąbrowski","1998-01-29","555666555","97012123411",5,"2023-02-02"),  ("Michał","Kamiński","1990-05-13","999888777","920322090851",3,"2023-05-21"),
("Antoni","Zieliński","2000-05-05","777444777","99988877766",4,"2023-03-18"), ("Maciej","Kozłowski","1980-05-05","898777444","88899988833",1,"2023-04-11"),
("Mikołaj","Kwiatkowski","2000-12-10","888999888","12345678901",3,"2023-05-01")

ALTER TABLE [dbo].[Clients]  WITH CHECK ADD FOREIGN KEY([Pass Type])
REFERENCES [dbo].[GymPasses] ([Id])
GO

