USE [master]
GO

/****** Object:  Database [votacion-finales-202112]    Script Date: 26/11/2021 12:35:59 ******/
CREATE DATABASE [votacion-finales-202112]
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [votacion-finales-202112].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [votacion-finales-202112] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET ARITHABORT OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [votacion-finales-202112] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [votacion-finales-202112] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET  DISABLE_BROKER 
GO

ALTER DATABASE [votacion-finales-202112] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [votacion-finales-202112] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [votacion-finales-202112] SET  MULTI_USER 
GO

ALTER DATABASE [votacion-finales-202112] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [votacion-finales-202112] SET DB_CHAINING OFF 
GO

ALTER DATABASE [votacion-finales-202112] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [votacion-finales-202112] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [votacion-finales-202112] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [votacion-finales-202112] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [votacion-finales-202112] SET QUERY_STORE = OFF
GO

ALTER DATABASE [votacion-finales-202112] SET  READ_WRITE 
GO

CREATE TABLE [dbo].[resultados](
	[fecha] [varchar](50) NOT NULL,
	[positivos] [int] NOT NULL,
	[negativos] [int] NOT NULL,
	[abstenciones] [int] NOT NULL,
	[alumno] [varchar](150) NOT NULL
) ON [PRIMARY]
GO