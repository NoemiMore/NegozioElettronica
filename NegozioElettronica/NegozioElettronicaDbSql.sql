USE [master]
GO
/****** Object:  Database [NegozioElettronica]    Script Date: 26/08/2021 15:31:45 ******/
CREATE DATABASE [NegozioElettronica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NegozioElettronica', FILENAME = N'C:\Users\noemi.more\NegozioElettronica.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NegozioElettronica_log', FILENAME = N'C:\Users\noemi.more\NegozioElettronica_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [NegozioElettronica] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NegozioElettronica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NegozioElettronica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NegozioElettronica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NegozioElettronica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NegozioElettronica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NegozioElettronica] SET ARITHABORT OFF 
GO
ALTER DATABASE [NegozioElettronica] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NegozioElettronica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NegozioElettronica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NegozioElettronica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NegozioElettronica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NegozioElettronica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NegozioElettronica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NegozioElettronica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NegozioElettronica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NegozioElettronica] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NegozioElettronica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NegozioElettronica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NegozioElettronica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NegozioElettronica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NegozioElettronica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NegozioElettronica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NegozioElettronica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NegozioElettronica] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NegozioElettronica] SET  MULTI_USER 
GO
ALTER DATABASE [NegozioElettronica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NegozioElettronica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NegozioElettronica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NegozioElettronica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NegozioElettronica] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NegozioElettronica] SET QUERY_STORE = OFF
GO
USE [NegozioElettronica]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [NegozioElettronica]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 26/08/2021 15:31:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Brand] [nvarchar](50) NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[QuantityMagazine] [int] NOT NULL,
	[SyOperation] [int] NULL,
	[Touch] [bit] NULL,
	[MemoriGB] [int] NULL,
	[Pollici] [int] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[discriminator] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Brand], [Model], [QuantityMagazine], [SyOperation], [Touch], [MemoriGB], [Pollici], [id], [discriminator]) VALUES (N'Apple', N'Mac 2.0', 5, 1, 1, NULL, NULL, 1, N'Pc')
INSERT [dbo].[Product] ([Brand], [Model], [QuantityMagazine], [SyOperation], [Touch], [MemoriGB], [Pollici], [id], [discriminator]) VALUES (N'Dell', N'Non', 2, 0, 0, NULL, NULL, 6, N'Pc')
INSERT [dbo].[Product] ([Brand], [Model], [QuantityMagazine], [SyOperation], [Touch], [MemoriGB], [Pollici], [id], [discriminator]) VALUES (N'Panasonic', N'hdgsb', 10, NULL, NULL, NULL, 32, 7, N'Tv')
INSERT [dbo].[Product] ([Brand], [Model], [QuantityMagazine], [SyOperation], [Touch], [MemoriGB], [Pollici], [id], [discriminator]) VALUES (N'Panasonic', N'jgkdnh', 2, NULL, NULL, NULL, 64, 8, N'Tv')
INSERT [dbo].[Product] ([Brand], [Model], [QuantityMagazine], [SyOperation], [Touch], [MemoriGB], [Pollici], [id], [discriminator]) VALUES (N'Iphone', N'5', 12, NULL, NULL, 128, NULL, 9, N'Phone')
INSERT [dbo].[Product] ([Brand], [Model], [QuantityMagazine], [SyOperation], [Touch], [MemoriGB], [Pollici], [id], [discriminator]) VALUES (N'Hawei', N'P30', 5, NULL, NULL, NULL, 12, 16, N'Phone')
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
USE [master]
GO
ALTER DATABASE [NegozioElettronica] SET  READ_WRITE 
GO
