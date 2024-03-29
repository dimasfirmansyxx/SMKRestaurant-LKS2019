USE [master]
GO
/****** Object:  Database [dbresto]    Script Date: 11/8/2019 3:06:00 PM ******/
CREATE DATABASE [dbresto]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbresto', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLSERVER\MSSQL\DATA\dbresto.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbresto_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLSERVER\MSSQL\DATA\dbresto_log.ldf' , SIZE = 1280KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbresto] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbresto].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbresto] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbresto] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbresto] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbresto] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbresto] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbresto] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbresto] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbresto] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbresto] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbresto] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbresto] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbresto] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbresto] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbresto] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbresto] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbresto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbresto] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbresto] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbresto] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbresto] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbresto] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbresto] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbresto] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbresto] SET  MULTI_USER 
GO
ALTER DATABASE [dbresto] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbresto] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbresto] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbresto] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbresto] SET DELAYED_DURABILITY = DISABLED 
GO
USE [dbresto]
GO
/****** Object:  Table [dbo].[tblemployee]    Script Date: 11/8/2019 3:06:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblemployee](
	[id_employee] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[handphone] [char](15) NOT NULL,
	[position] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblemployee] PRIMARY KEY CLUSTERED 
(
	[id_employee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblmember]    Script Date: 11/8/2019 3:06:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblmember](
	[id_member] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
	[joindate] [date] NOT NULL,
 CONSTRAINT [PK_tblmember] PRIMARY KEY CLUSTERED 
(
	[id_member] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblmenu]    Script Date: 11/8/2019 3:06:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblmenu](
	[id_menu] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[price] [int] NOT NULL,
	[photo] [image] NOT NULL,
 CONSTRAINT [PK_tblmenu] PRIMARY KEY CLUSTERED 
(
	[id_menu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblorder]    Script Date: 11/8/2019 3:06:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblorder](
	[id_order] [char](16) NOT NULL,
	[id_employee] [int] NULL,
	[id_member] [int] NOT NULL,
	[date] [date] NOT NULL,
	[payment] [varchar](50) NULL,
	[bank] [varchar](50) NULL,
 CONSTRAINT [PK_tblorder] PRIMARY KEY CLUSTERED 
(
	[id_order] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblorderdetail]    Script Date: 11/8/2019 3:06:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblorderdetail](
	[id_detail] [int] IDENTITY(1,1) NOT NULL,
	[id_order] [char](16) NOT NULL,
	[id_menu] [int] NOT NULL,
	[qty] [int] NOT NULL,
	[price] [int] NOT NULL,
	[status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblorderdetail] PRIMARY KEY CLUSTERED 
(
	[id_detail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tblorder]  WITH CHECK ADD  CONSTRAINT [FK_tblorder_tblemployee] FOREIGN KEY([id_employee])
REFERENCES [dbo].[tblemployee] ([id_employee])
GO
ALTER TABLE [dbo].[tblorder] CHECK CONSTRAINT [FK_tblorder_tblemployee]
GO
ALTER TABLE [dbo].[tblorder]  WITH CHECK ADD  CONSTRAINT [FK_tblorder_tblmember] FOREIGN KEY([id_member])
REFERENCES [dbo].[tblmember] ([id_member])
GO
ALTER TABLE [dbo].[tblorder] CHECK CONSTRAINT [FK_tblorder_tblmember]
GO
ALTER TABLE [dbo].[tblorderdetail]  WITH CHECK ADD  CONSTRAINT [FK_tblorderdetail_tblmenu] FOREIGN KEY([id_menu])
REFERENCES [dbo].[tblmenu] ([id_menu])
GO
ALTER TABLE [dbo].[tblorderdetail] CHECK CONSTRAINT [FK_tblorderdetail_tblmenu]
GO
ALTER TABLE [dbo].[tblorderdetail]  WITH CHECK ADD  CONSTRAINT [FK_tblorderdetail_tblorder] FOREIGN KEY([id_order])
REFERENCES [dbo].[tblorder] ([id_order])
GO
ALTER TABLE [dbo].[tblorderdetail] CHECK CONSTRAINT [FK_tblorderdetail_tblorder]
GO
USE [master]
GO
ALTER DATABASE [dbresto] SET  READ_WRITE 
GO
