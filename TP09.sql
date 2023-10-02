USE [TP09]
GO
/****** Object:  User [alumno]    Script Date: 2/10/2023 08:24:03 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 2/10/2023 08:24:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Username] [nvarchar](max) NOT NULL,
	[Contraseña] [nvarchar](max) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Telefono] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Usuarios] ([Username], [Contraseña], [Nombre], [Email], [Telefono]) VALUES (N'Fedeostro', N'C@ndadot', N'Federico Ostrovksy', N'ferdferdostro@gmail.com', N'1234-5678')
GO
