USE [master]
GO
/****** Object:  Database [Prototipo]    Script Date: 19/6/2022 17:52:18 ******/
CREATE DATABASE [Prototipo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Prototipo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Prototipo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Prototipo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Prototipo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Prototipo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Prototipo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Prototipo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Prototipo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Prototipo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Prototipo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Prototipo] SET ARITHABORT OFF 
GO
ALTER DATABASE [Prototipo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Prototipo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Prototipo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Prototipo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Prototipo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Prototipo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Prototipo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Prototipo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Prototipo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Prototipo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Prototipo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Prototipo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Prototipo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Prototipo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Prototipo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Prototipo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Prototipo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Prototipo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Prototipo] SET  MULTI_USER 
GO
ALTER DATABASE [Prototipo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Prototipo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Prototipo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Prototipo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Prototipo] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Prototipo', N'ON'
GO
ALTER DATABASE [Prototipo] SET QUERY_STORE = OFF
GO
USE [Prototipo]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 19/6/2022 17:52:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] NOT NULL,
	[Dni] [varchar](10) NOT NULL,
	[Email] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Componente]    Script Date: 19/6/2022 17:52:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Componente](
	[Id] [int] NOT NULL,
	[Precio] [decimal](10, 2) NOT NULL,
	[Calidad] [int] NOT NULL,
	[Tipo] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Componente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComprobanteArmado]    Script Date: 19/6/2022 17:52:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComprobanteArmado](
	[Id] [int] NOT NULL,
	[IdPedido] [int] NOT NULL,
 CONSTRAINT [PK_ComprobanteArmado] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Computadora]    Script Date: 19/6/2022 17:52:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Computadora](
	[Id] [int] NOT NULL,
	[Precio] [decimal](12, 0) NOT NULL,
	[Calidad] [int] NOT NULL,
	[IdPedido] [int] NOT NULL,
 CONSTRAINT [PK_Computadora] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComputadoraComponente]    Script Date: 19/6/2022 17:52:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComputadoraComponente](
	[IdComputadora] [int] NOT NULL,
	[IdComponente] [int] NOT NULL,
 CONSTRAINT [PK_ComputadoraComponente] PRIMARY KEY CLUSTERED 
(
	[IdComputadora] ASC,
	[IdComponente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 19/6/2022 17:52:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[Id] [int] NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[NombreUsuario] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especificacion]    Script Date: 19/6/2022 17:52:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especificacion](
	[Id] [int] NOT NULL,
	[TipoUso] [varchar](20) NOT NULL,
	[CalidadEsperada] [int] NOT NULL,
 CONSTRAINT [PK_Especificacion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 19/6/2022 17:52:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[Id] [int] NOT NULL,
	[IdPedido] [int] NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InformeError]    Script Date: 19/6/2022 17:52:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InformeError](
	[Id] [int] NOT NULL,
	[TipoComponente] [varchar](20) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[ComponenteReemplazo] [int] NOT NULL,
	[ComponenteDefectuoso] [int] NOT NULL,
	[Descripcion] [varchar](max) NOT NULL,
 CONSTRAINT [PK_InformeError] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 19/6/2022 17:52:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[Id] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdEspecificacion] [int] NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[Comentario] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ComprobanteArmado]  WITH CHECK ADD  CONSTRAINT [FK_ComprobanteArmado_Pedido] FOREIGN KEY([IdPedido])
REFERENCES [dbo].[Pedido] ([Id])
GO
ALTER TABLE [dbo].[ComprobanteArmado] CHECK CONSTRAINT [FK_ComprobanteArmado_Pedido]
GO
ALTER TABLE [dbo].[Computadora]  WITH CHECK ADD  CONSTRAINT [FK_Computadora_Pedido] FOREIGN KEY([IdPedido])
REFERENCES [dbo].[Pedido] ([Id])
GO
ALTER TABLE [dbo].[Computadora] CHECK CONSTRAINT [FK_Computadora_Pedido]
GO
ALTER TABLE [dbo].[ComputadoraComponente]  WITH CHECK ADD  CONSTRAINT [FK_ComputadoraComponente_Componente] FOREIGN KEY([IdComponente])
REFERENCES [dbo].[Componente] ([Id])
GO
ALTER TABLE [dbo].[ComputadoraComponente] CHECK CONSTRAINT [FK_ComputadoraComponente_Componente]
GO
ALTER TABLE [dbo].[ComputadoraComponente]  WITH CHECK ADD  CONSTRAINT [FK_ComputadoraComponente_Computadora] FOREIGN KEY([IdComputadora])
REFERENCES [dbo].[Computadora] ([Id])
GO
ALTER TABLE [dbo].[ComputadoraComponente] CHECK CONSTRAINT [FK_ComputadoraComponente_Computadora]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Pedido] FOREIGN KEY([IdPedido])
REFERENCES [dbo].[Pedido] ([Id])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Pedido]
GO
ALTER TABLE [dbo].[InformeError]  WITH CHECK ADD  CONSTRAINT [FK_InformeError_Componente] FOREIGN KEY([ComponenteReemplazo])
REFERENCES [dbo].[Componente] ([Id])
GO
ALTER TABLE [dbo].[InformeError] CHECK CONSTRAINT [FK_InformeError_Componente]
GO
ALTER TABLE [dbo].[InformeError]  WITH CHECK ADD  CONSTRAINT [FK_InformeError_Componente1] FOREIGN KEY([ComponenteDefectuoso])
REFERENCES [dbo].[Componente] ([Id])
GO
ALTER TABLE [dbo].[InformeError] CHECK CONSTRAINT [FK_InformeError_Componente1]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Cliente]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Empleado] FOREIGN KEY([IdEspecificacion])
REFERENCES [dbo].[Empleado] ([Id])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Empleado]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Especificacion] FOREIGN KEY([IdEspecificacion])
REFERENCES [dbo].[Especificacion] ([Id])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Especificacion]
GO
USE [master]
GO
ALTER DATABASE [Prototipo] SET  READ_WRITE 
GO
