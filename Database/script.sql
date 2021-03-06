USE [master]
GO
/****** Object:  Database [powingSystem_db]    Script Date: 2/15/2016 8:44:37 PM ******/
CREATE DATABASE [powingSystem_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'powingSystem_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\powingSystem_db.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'powingSystem_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\powingSystem_db_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [powingSystem_db] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [powingSystem_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [powingSystem_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [powingSystem_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [powingSystem_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [powingSystem_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [powingSystem_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [powingSystem_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [powingSystem_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [powingSystem_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [powingSystem_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [powingSystem_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [powingSystem_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [powingSystem_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [powingSystem_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [powingSystem_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [powingSystem_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [powingSystem_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [powingSystem_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [powingSystem_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [powingSystem_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [powingSystem_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [powingSystem_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [powingSystem_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [powingSystem_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [powingSystem_db] SET  MULTI_USER 
GO
ALTER DATABASE [powingSystem_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [powingSystem_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [powingSystem_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [powingSystem_db] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [powingSystem_db] SET DELAYED_DURABILITY = DISABLED 
GO
USE [powingSystem_db]
GO
/****** Object:  Table [dbo].[tbl_Carat]    Script Date: 2/15/2016 8:44:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Carat](
	[caratNo] [int] NOT NULL,
	[caratType] [int] NOT NULL,
	[priceOf1Carat] [float] NOT NULL,
	[RateNo] [int] NULL,
 CONSTRAINT [PK_tbl_Carat_1] PRIMARY KEY CLUSTERED 
(
	[caratNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Customer]    Script Date: 2/15/2016 8:44:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Customer](
	[cusNo] [int] NOT NULL,
	[date] [date] NULL,
	[name] [varchar](20) NULL,
	[addressLine1] [varchar](20) NULL,
	[addressLine2] [varchar](20) NULL,
	[city] [varchar](20) NULL,
	[nic] [int] NULL,
	[passport] [int] NULL,
	[tel] [int] NULL,
	[officerID] [varchar](20) NOT NULL,
	[Pay] [float] NOT NULL,
 CONSTRAINT [PK_tbl_Customer] PRIMARY KEY CLUSTERED 
(
	[cusNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_interest]    Script Date: 2/15/2016 8:44:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_interest](
	[RateNo] [int] NOT NULL,
	[Rate] [float] NOT NULL,
 CONSTRAINT [PK_tbl_interest] PRIMARY KEY CLUSTERED 
(
	[RateNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Jewellery]    Script Date: 2/15/2016 8:44:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Jewellery](
	[jewelleryNo] [int] NOT NULL,
	[typeOfJeweller] [varchar](50) NOT NULL,
	[weight] [float] NOT NULL,
	[paying] [float] NOT NULL,
	[cusNo] [int] NULL,
	[caratNo] [int] NULL,
	[RateNo] [int] NULL,
 CONSTRAINT [PK_tbl_Jewellery] PRIMARY KEY CLUSTERED 
(
	[jewelleryNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_JewelleryType]    Script Date: 2/15/2016 8:44:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_JewelleryType](
	[typeOfJeweller] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_JewelleryType] PRIMARY KEY CLUSTERED 
(
	[typeOfJeweller] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Officer]    Script Date: 2/15/2016 8:44:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Officer](
	[todayDate] [varchar](10) NULL,
	[officerID] [varchar](20) NOT NULL,
	[password] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tbl_Officer] PRIMARY KEY CLUSTERED 
(
	[officerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_tempJewellery]    Script Date: 2/15/2016 8:44:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_tempJewellery](
	[jewelleryNo] [int] NOT NULL,
	[typeOfJeweller] [varchar](20) NULL,
	[weight] [float] NULL,
	[paying] [float] NULL,
	[cusNo] [int] NULL,
	[caratNo] [int] NULL,
	[RateNo] [int] NULL,
 CONSTRAINT [PK_tbl_tempJewellery] PRIMARY KEY CLUSTERED 
(
	[jewelleryNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tbl_Carat]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Carat_tbl_interest] FOREIGN KEY([RateNo])
REFERENCES [dbo].[tbl_interest] ([RateNo])
GO
ALTER TABLE [dbo].[tbl_Carat] CHECK CONSTRAINT [FK_tbl_Carat_tbl_interest]
GO
ALTER TABLE [dbo].[tbl_Customer]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Customer_tbl_Officer] FOREIGN KEY([officerID])
REFERENCES [dbo].[tbl_Officer] ([officerID])
GO
ALTER TABLE [dbo].[tbl_Customer] CHECK CONSTRAINT [FK_tbl_Customer_tbl_Officer]
GO
ALTER TABLE [dbo].[tbl_Jewellery]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Jewellery_tbl_Carat1] FOREIGN KEY([caratNo])
REFERENCES [dbo].[tbl_Carat] ([caratNo])
GO
ALTER TABLE [dbo].[tbl_Jewellery] CHECK CONSTRAINT [FK_tbl_Jewellery_tbl_Carat1]
GO
ALTER TABLE [dbo].[tbl_Jewellery]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Jewellery_tbl_Customer] FOREIGN KEY([cusNo])
REFERENCES [dbo].[tbl_Customer] ([cusNo])
GO
ALTER TABLE [dbo].[tbl_Jewellery] CHECK CONSTRAINT [FK_tbl_Jewellery_tbl_Customer]
GO
ALTER TABLE [dbo].[tbl_Jewellery]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Jewellery_tbl_interest] FOREIGN KEY([RateNo])
REFERENCES [dbo].[tbl_interest] ([RateNo])
GO
ALTER TABLE [dbo].[tbl_Jewellery] CHECK CONSTRAINT [FK_tbl_Jewellery_tbl_interest]
GO
ALTER TABLE [dbo].[tbl_Jewellery]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Jewellery_tbl_JewelleryType1] FOREIGN KEY([typeOfJeweller])
REFERENCES [dbo].[tbl_JewelleryType] ([typeOfJeweller])
GO
ALTER TABLE [dbo].[tbl_Jewellery] CHECK CONSTRAINT [FK_tbl_Jewellery_tbl_JewelleryType1]
GO
USE [master]
GO
ALTER DATABASE [powingSystem_db] SET  READ_WRITE 
GO
