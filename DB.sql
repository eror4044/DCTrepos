USE [master]
GO
/****** Object:  Database [User]    Script Date: Ср 03.02.21 14:35:31 ******/
CREATE DATABASE [User]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'User', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\User.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'User_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\User_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [User] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [User].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [User] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [User] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [User] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [User] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [User] SET ARITHABORT OFF 
GO
ALTER DATABASE [User] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [User] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [User] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [User] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [User] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [User] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [User] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [User] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [User] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [User] SET  DISABLE_BROKER 
GO
ALTER DATABASE [User] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [User] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [User] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [User] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [User] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [User] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [User] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [User] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [User] SET  MULTI_USER 
GO
ALTER DATABASE [User] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [User] SET DB_CHAINING OFF 
GO
ALTER DATABASE [User] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [User] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [User] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [User] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [User] SET QUERY_STORE = OFF
GO
USE [User]
GO
/****** Object:  ColumnMasterKey [CMK_Auto1]    Script Date: Ср 03.02.21 14:35:32 ******/
CREATE COLUMN MASTER KEY [CMK_Auto1]
WITH
(
	KEY_STORE_PROVIDER_NAME = N'MSSQL_CERTIFICATE_STORE',
	KEY_PATH = N'CurrentUser/my/8EE7138DEDEE74FA92E8B5C5CB4D2C48D5BB4811'
)
GO
/****** Object:  ColumnEncryptionKey [CEK_Auto1]    Script Date: Ср 03.02.21 14:35:32 ******/
CREATE COLUMN ENCRYPTION KEY [CEK_Auto1]
WITH VALUES
(
	COLUMN_MASTER_KEY = [CMK_Auto1],
	ALGORITHM = 'RSA_OAEP',
	ENCRYPTED_VALUE = 0x016E000001630075007200720065006E00740075007300650072002F006D0079002F0038006500650037003100330038006400650064006500650037003400660061003900320065003800620035006300350063006200340064003200630034003800640035006200620034003800310031008E22FD6C3E8F205DEBFD7C1FA61806415E6F09E52C49944A7496037761F5F6CBCADDAB57EED8D7D7DB73195A2CA9F326A5BD7564CAAE471CB561D918F4E3CA09986BDF030BF46ADD0C30F0EAB019BDFC37EB226303D49F468E487A05097D0EF208604EA6FA188A3B4345F4B0ED831542EC770C55DAE0D860A25CB2D3AC1E85CB1BFBF618520F6E87990056419F2845AFE37D4E0C4EA997076B4278BF87F18571E8BE675C08BAC24B474D5F13E9967EF00C762006DF38E95461A208F5F2B7F03CCC2EC2D66A2095CBC325761B6D7857272C86F50B9A302FB981296E74A9945B40207E0E1EA2201969B7DF55D81D53C2660D1D606AECD3429826423C77E603FD3FA3F4E65C01FA5100A74C88E6A1A254FB0DCC3125FB41CA11591DC33251B869E16468688AF158CD9FACF54E853480B5371FB6CDD4F261B58AD65871DEE0FF8935712CA1258262B093168143822CA1412C335FDCAF3F03280E427B2B93A9A1546F7B4941429D50384827A99DEE470289B5E7511AA3CC9FF1A261323994768CF48EC339BF4B85B7C2A9981E4A7CC2CF6F0E4C9A8506259D888F86285C80C8C6004BA6167FCD860958B4DA8FA0FDFB11F39C7C9AE8BAA585576B9FD35251B54776C76E6A7181911613A69FCEC991D164EB8501FDB0A4971A1D25A9C0B257994C6702F1509B5CCC2A7D9233949735C740B418E0BCEBD9823961FB67776973EEFA330D
)
GO
/****** Object:  Table [dbo].[Products]    Script Date: Ср 03.02.21 14:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](100) NOT NULL,
	[Price] [money] NOT NULL,
	[Count] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: Ср 03.02.21 14:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[login] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [User] SET  READ_WRITE 
GO
