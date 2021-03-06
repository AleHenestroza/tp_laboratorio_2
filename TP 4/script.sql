USE [master]
GO
/****** Object:  Database [TP4_Henestroza_Alejandro]    Script Date: 11/7/2021 20:16:59 ******/
CREATE DATABASE [TP4_Henestroza_Alejandro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP4_Henestroza_Alejandro', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TP4_Henestroza_Alejandro.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP4_Henestroza_Alejandro_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TP4_Henestroza_Alejandro_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP4_Henestroza_Alejandro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET RECOVERY FULL 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET  MULTI_USER 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TP4_Henestroza_Alejandro', N'ON'
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET QUERY_STORE = OFF
GO
USE [TP4_Henestroza_Alejandro]
GO
/****** Object:  Table [dbo].[Cascos]    Script Date: 11/7/2021 20:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cascos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[talla] [decimal](18, 2) NOT NULL,
	[costo] [decimal](18, 2) NOT NULL,
	[orden_id] [int] NOT NULL,
 CONSTRAINT [PK_Cascos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Costos]    Script Date: 11/7/2021 20:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Costos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[costo] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Costos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Luces]    Script Date: 11/7/2021 20:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Luces](
	[id] [int] NOT NULL,
	[color] [varchar](50) NULL,
	[costo] [decimal](18, 2) NULL,
	[ordenId] [int] NULL,
 CONSTRAINT [PK_Luces] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MountainBikes]    Script Date: 11/7/2021 20:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MountainBikes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rodado] [decimal](18, 0) NULL,
	[tamanioCuadro] [decimal](18, 2) NULL,
	[material] [varchar](50) NULL,
	[costo] [decimal](18, 2) NULL,
	[tieneCambios] [int] NULL,
	[ordenId] [int] NULL,
 CONSTRAINT [PK_MountainBikes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordenes]    Script Date: 11/7/2021 20:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordenes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[costo] [decimal](18, 2) NULL,
	[tieneMountainBike] [int] NULL,
	[tienePlayera] [int] NULL,
	[tieneCasco] [int] NULL,
	[tieneLuz] [int] NULL,
 CONSTRAINT [PK_Ordenes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Playeras]    Script Date: 11/7/2021 20:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Playeras](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rodado] [decimal](18, 0) NULL,
	[tamanioCuadro] [decimal](18, 2) NULL,
	[material] [varchar](50) NULL,
	[costo] [decimal](18, 2) NULL,
	[tieneFrenos] [int] NULL,
	[ordenId] [int] NULL,
 CONSTRAINT [PK_Playeras] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 11/7/2021 20:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[cantidad] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cascos] ON 

INSERT [dbo].[Cascos] ([id], [talla], [costo], [orden_id]) VALUES (4, CAST(51.00 AS Decimal(18, 2)), CAST(1338.75 AS Decimal(18, 2)), 1)
INSERT [dbo].[Cascos] ([id], [talla], [costo], [orden_id]) VALUES (5, CAST(51.00 AS Decimal(18, 2)), CAST(1338.75 AS Decimal(18, 2)), 1)
SET IDENTITY_INSERT [dbo].[Cascos] OFF
GO
SET IDENTITY_INSERT [dbo].[Costos] ON 

INSERT [dbo].[Costos] ([id], [nombre], [costo]) VALUES (1, N'Acero', CAST(90.00 AS Decimal(18, 2)))
INSERT [dbo].[Costos] ([id], [nombre], [costo]) VALUES (2, N'Aluminio', CAST(135.00 AS Decimal(18, 2)))
INSERT [dbo].[Costos] ([id], [nombre], [costo]) VALUES (3, N'Titanio', CAST(180.00 AS Decimal(18, 2)))
INSERT [dbo].[Costos] ([id], [nombre], [costo]) VALUES (4, N'Fibra de Carbono', CAST(235.00 AS Decimal(18, 2)))
INSERT [dbo].[Costos] ([id], [nombre], [costo]) VALUES (9, N'Rueda', CAST(110.75 AS Decimal(18, 2)))
INSERT [dbo].[Costos] ([id], [nombre], [costo]) VALUES (10, N'Casco', CAST(1050.00 AS Decimal(18, 2)))
INSERT [dbo].[Costos] ([id], [nombre], [costo]) VALUES (11, N'Luz', CAST(800.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Costos] OFF
GO
SET IDENTITY_INSERT [dbo].[MountainBikes] ON 

INSERT [dbo].[MountainBikes] ([id], [rodado], [tamanioCuadro], [material], [costo], [tieneCambios], [ordenId]) VALUES (3, CAST(26 AS Decimal(18, 0)), CAST(47.50 AS Decimal(18, 2)), N'Acero', CAST(10034.00 AS Decimal(18, 2)), 0, 4)
INSERT [dbo].[MountainBikes] ([id], [rodado], [tamanioCuadro], [material], [costo], [tieneCambios], [ordenId]) VALUES (4, CAST(26 AS Decimal(18, 0)), CAST(47.50 AS Decimal(18, 2)), N'Acero', CAST(10034.00 AS Decimal(18, 2)), 0, 4)
INSERT [dbo].[MountainBikes] ([id], [rodado], [tamanioCuadro], [material], [costo], [tieneCambios], [ordenId]) VALUES (5, CAST(26 AS Decimal(18, 0)), CAST(47.50 AS Decimal(18, 2)), N'Titanio', CAST(14309.00 AS Decimal(18, 2)), 0, 5)
INSERT [dbo].[MountainBikes] ([id], [rodado], [tamanioCuadro], [material], [costo], [tieneCambios], [ordenId]) VALUES (6, CAST(26 AS Decimal(18, 0)), CAST(47.50 AS Decimal(18, 2)), N'Titanio', CAST(14309.00 AS Decimal(18, 2)), 0, 5)
SET IDENTITY_INSERT [dbo].[MountainBikes] OFF
GO
SET IDENTITY_INSERT [dbo].[Ordenes] ON 

INSERT [dbo].[Ordenes] ([id], [costo], [tieneMountainBike], [tienePlayera], [tieneCasco], [tieneLuz]) VALUES (4, CAST(20068.00 AS Decimal(18, 2)), 1, 0, 0, 0)
INSERT [dbo].[Ordenes] ([id], [costo], [tieneMountainBike], [tienePlayera], [tieneCasco], [tieneLuz]) VALUES (5, CAST(14309.00 AS Decimal(18, 2)), 1, 0, 0, 0)
INSERT [dbo].[Ordenes] ([id], [costo], [tieneMountainBike], [tienePlayera], [tieneCasco], [tieneLuz]) VALUES (10, CAST(35597.00 AS Decimal(18, 2)), 0, 1, 0, 0)
SET IDENTITY_INSERT [dbo].[Ordenes] OFF
GO
SET IDENTITY_INSERT [dbo].[Playeras] ON 

INSERT [dbo].[Playeras] ([id], [rodado], [tamanioCuadro], [material], [costo], [tieneFrenos], [ordenId]) VALUES (2, CAST(24 AS Decimal(18, 0)), CAST(49.50 AS Decimal(18, 2)), N'Fibra de Carbono', CAST(17798.50 AS Decimal(18, 2)), 0, 10)
INSERT [dbo].[Playeras] ([id], [rodado], [tamanioCuadro], [material], [costo], [tieneFrenos], [ordenId]) VALUES (3, CAST(24 AS Decimal(18, 0)), CAST(49.50 AS Decimal(18, 2)), N'Fibra de Carbono', CAST(17798.50 AS Decimal(18, 2)), 0, 10)
SET IDENTITY_INSERT [dbo].[Playeras] OFF
GO
SET IDENTITY_INSERT [dbo].[Stock] ON 

INSERT [dbo].[Stock] ([id], [nombre], [cantidad]) VALUES (1, N'Acero', CAST(521.00 AS Decimal(18, 2)))
INSERT [dbo].[Stock] ([id], [nombre], [cantidad]) VALUES (2, N'Aluminio', CAST(355.50 AS Decimal(18, 2)))
INSERT [dbo].[Stock] ([id], [nombre], [cantidad]) VALUES (3, N'Titanio', CAST(516.00 AS Decimal(18, 2)))
INSERT [dbo].[Stock] ([id], [nombre], [cantidad]) VALUES (4, N'Fibra de Carbono', CAST(225.50 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Stock] OFF
GO
USE [master]
GO
ALTER DATABASE [TP4_Henestroza_Alejandro] SET  READ_WRITE 
GO
