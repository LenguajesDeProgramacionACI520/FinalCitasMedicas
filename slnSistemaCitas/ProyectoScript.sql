USE [master]
GO
/****** Object:  Database [dbProyecto]    Script Date: 13/12/2016 6:18:01 ******/
CREATE DATABASE [dbProyecto]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbProyecto', FILENAME = N'C:\Users\viana\dbProyecto.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbProyecto_log', FILENAME = N'C:\Users\viana\dbProyecto_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbProyecto].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbProyecto] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbProyecto] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbProyecto] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbProyecto] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbProyecto] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbProyecto] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbProyecto] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbProyecto] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbProyecto] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbProyecto] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbProyecto] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbProyecto] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbProyecto] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbProyecto] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbProyecto] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbProyecto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbProyecto] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbProyecto] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbProyecto] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbProyecto] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbProyecto] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbProyecto] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbProyecto] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbProyecto] SET  MULTI_USER 
GO
ALTER DATABASE [dbProyecto] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbProyecto] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbProyecto] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbProyecto] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbProyecto] SET DELAYED_DURABILITY = DISABLED 
GO
USE [dbProyecto]
GO
/****** Object:  Table [dbo].[TblAdmin]    Script Date: 13/12/2016 6:18:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblAdmin](
	[idAdmin] [varchar](10) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[genero] [int] NOT NULL,
 CONSTRAINT [PK_TblAdmin] PRIMARY KEY CLUSTERED 
(
	[idAdmin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblCiudad]    Script Date: 13/12/2016 6:18:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblCiudad](
	[idCiudad] [int] NOT NULL,
	[nombreC] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idCiudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblDoctores]    Script Date: 13/12/2016 6:18:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblDoctores](
	[cedulaDoc] [varchar](10) NOT NULL,
	[nombreDoc] [varchar](20) NOT NULL,
	[apellidoDoc] [varchar](20) NOT NULL,
	[generoDoc] [int] NOT NULL,
	[fechaN_Doc] [datetime] NOT NULL,
	[celDoc] [varchar](12) NOT NULL,
	[idHospital] [int] NOT NULL,
	[idEspecialidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cedulaDoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblEspecialidad]    Script Date: 13/12/2016 6:18:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblEspecialidad](
	[id] [int] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[costo] [float] NOT NULL,
 CONSTRAINT [PK_TblEspecialidad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblEspecialidadHospital]    Script Date: 13/12/2016 6:18:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblEspecialidadHospital](
	[idEspecialidad] [int] NOT NULL,
	[idHospital] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idEspecialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblEspecialidadSeguro]    Script Date: 13/12/2016 6:18:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblEspecialidadSeguro](
	[idEspecialidad] [int] NOT NULL,
	[idSeguroE] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idEspecialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblGenero]    Script Date: 13/12/2016 6:18:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblGenero](
	[Id] [int] NOT NULL,
	[gen_nombre] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblHospital]    Script Date: 13/12/2016 6:18:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblHospital](
	[idH] [int] NOT NULL,
	[nombreH] [nchar](20) NOT NULL,
	[ciudadH] [int] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[idH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblLogin1]    Script Date: 13/12/2016 6:18:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblLogin1](
	[usuario] [varchar](10) NOT NULL,
	[pass] [varchar](20) NOT NULL,
	[rol] [int] NOT NULL,
 CONSTRAINT [PK_TblLogin1] PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblPromociones]    Script Date: 13/12/2016 6:18:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblPromociones](
	[id] [int] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[descuento] [int] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblRol]    Script Date: 13/12/2016 6:18:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblRol](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_TblRol] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblSeguro]    Script Date: 13/12/2016 6:18:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblSeguro](
	[idSeguro] [int] NOT NULL,
	[nombreSeguro] [varchar](25) NOT NULL,
	[descuentoSeguro] [int] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[idSeguro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblUsuario]    Script Date: 13/12/2016 6:18:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblUsuario](
	[idCedula] [varchar](10) NOT NULL,
	[nombre_p] [nchar](20) NOT NULL,
	[nombre_s] [nchar](20) NULL,
	[apellido_p] [varchar](20) NOT NULL,
	[apellido_s] [nchar](20) NULL,
	[genero] [int] NULL,
	[fecha_Nacimiento] [datetime] NULL,
	[correo] [varchar](50) NULL,
	[cel] [nchar](12) NULL,
	[seguroMedico] [int] NULL DEFAULT ((0)),
	[ciudad] [int] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[idCedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[TblDoctores] ADD  DEFAULT ((1)) FOR [generoDoc]
GO
USE [master]
GO
ALTER DATABASE [dbProyecto] SET  READ_WRITE 
GO
