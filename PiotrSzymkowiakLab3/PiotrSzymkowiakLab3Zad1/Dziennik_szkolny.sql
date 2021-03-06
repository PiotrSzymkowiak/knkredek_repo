USE [master]
GO
/****** Object:  Database [Dziennik_szkolny]    Script Date: 2017-04-20 02:53:51 ******/
CREATE DATABASE [Dziennik_szkolny]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Dziennik_szkolny', FILENAME = N'B:\Piotrek\Inf\C#\Kredek_C#\MSSQL13.KREDEKINSTANCE\MSSQL\DATA\Dziennik_szkolny.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Dziennik_szkolny_log', FILENAME = N'B:\Piotrek\Inf\C#\Kredek_C#\MSSQL13.KREDEKINSTANCE\MSSQL\DATA\Dziennik_szkolny_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Dziennik_szkolny] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Dziennik_szkolny].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Dziennik_szkolny] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET ARITHABORT OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Dziennik_szkolny] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Dziennik_szkolny] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Dziennik_szkolny] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Dziennik_szkolny] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Dziennik_szkolny] SET  MULTI_USER 
GO
ALTER DATABASE [Dziennik_szkolny] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Dziennik_szkolny] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Dziennik_szkolny] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Dziennik_szkolny] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Dziennik_szkolny] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Dziennik_szkolny] SET QUERY_STORE = OFF
GO
USE [Dziennik_szkolny]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Dziennik_szkolny]
GO
/****** Object:  Table [dbo].[adres_zamieszkania]    Script Date: 2017-04-20 02:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adres_zamieszkania](
	[adres_zamieszkania] [numeric](8, 0) IDENTITY(1,1) NOT NULL,
	[kod_pocz] [varchar](6) NOT NULL,
	[Miasto] [varchar](30) NOT NULL,
	[Ulica] [varchar](30) NOT NULL,
	[nr_bud] [varchar](5) NOT NULL,
	[nr_miesz] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[adres_zamieszkania] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Klasa]    Script Date: 2017-04-20 02:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Klasa](
	[id_klasy] [numeric](8, 0) IDENTITY(1,1) NOT NULL,
	[stopien] [numeric](1, 0) NOT NULL,
	[numer] [numeric](1, 0) NOT NULL,
	[id_nauczyciela] [numeric](8, 0) NOT NULL,
	[specjalizacja] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_klasy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Komentarz]    Script Date: 2017-04-20 02:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Komentarz](
	[id_komentarza] [numeric](8, 0) IDENTITY(1,1) NOT NULL,
	[tytul] [varchar](30) NOT NULL,
	[komentarz] [varchar](255) NOT NULL,
	[id_ucznia] [numeric](8, 0) NOT NULL,
	[id_nauczyciela] [numeric](8, 0) NOT NULL,
	[data] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_komentarza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lekcja]    Script Date: 2017-04-20 02:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lekcja](
	[id_lekcji] [numeric](8, 0) IDENTITY(1,1) NOT NULL,
	[tytul] [varchar](30) NOT NULL,
	[id_nauczyciela] [numeric](8, 0) NOT NULL,
	[id_klasy] [numeric](8, 0) NOT NULL,
	[data] [date] NOT NULL,
	[sala] [varchar](5) NOT NULL,
	[uwagi] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_lekcji] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nauczyciel]    Script Date: 2017-04-20 02:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nauczyciel](
	[id_nauczyciela] [numeric](8, 0) IDENTITY(1,1) NOT NULL,
	[imie] [varchar](20) NOT NULL,
	[nazwisko] [varchar](60) NOT NULL,
	[adres_zamieszkania] [numeric](8, 0) NOT NULL,
	[PESEL] [numeric](11, 0) NOT NULL,
	[stanowisko] [varchar](50) NULL,
	[zarobki] [numeric](10, 0) NULL,
	[staz] [numeric](5, 0) NULL,
	[numer_umowy] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_nauczyciela] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ocena]    Script Date: 2017-04-20 02:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ocena](
	[id_oceny] [numeric](8, 0) IDENTITY(1,1) NOT NULL,
	[tytul] [varchar](30) NOT NULL,
	[ocena] [numeric](1, 0) NOT NULL,
	[modyfikator] [varchar](1) NULL,
	[Waga] [numeric](1, 0) NOT NULL,
	[id_ucznia] [numeric](8, 0) NOT NULL,
	[id_nauczyciela] [numeric](8, 0) NOT NULL,
	[id_lekcji] [numeric](8, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_oceny] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Opiekun]    Script Date: 2017-04-20 02:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Opiekun](
	[id_opiekuna] [numeric](8, 0) IDENTITY(1,1) NOT NULL,
	[imie] [varchar](20) NOT NULL,
	[nazwisko] [varchar](60) NOT NULL,
	[PESEL] [numeric](11, 0) NOT NULL,
	[adres_zamieszkania] [numeric](8, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_opiekuna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Plan_lekcji]    Script Date: 2017-04-20 02:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plan_lekcji](
	[id_lekcji] [numeric](8, 0) NOT NULL,
	[id_ucznia] [numeric](8, 0) NOT NULL,
	[frekwencja] [numeric](1, 0) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Uczen]    Script Date: 2017-04-20 02:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uczen](
	[id_ucznia] [numeric](8, 0) IDENTITY(1,1) NOT NULL,
	[imie] [varchar](20) NOT NULL,
	[nazwisko] [varchar](60) NOT NULL,
	[adres_zamieszkania] [numeric](8, 0) NOT NULL,
	[PESEL] [numeric](11, 0) NOT NULL,
	[id_klasy] [numeric](8, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ucznia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[uczen_opiekun]    Script Date: 2017-04-20 02:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uczen_opiekun](
	[id_ucznia] [numeric](8, 0) NOT NULL,
	[id_opiekuna] [numeric](8, 0) NOT NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[adres_zamieszkania] ON 

INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(1 AS Numeric(8, 0)), N'50-355', N'Wrocław', N'Grunwaldzka', N'23', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(2 AS Numeric(8, 0)), N'50-305', N'Wrocław', N'Brodzka', N'54', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(3 AS Numeric(8, 0)), N'51-356', N'Wrocław', N'Sienkiewicza', N'12', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(4 AS Numeric(8, 0)), N'53-474', N'Wrocław', N'Pl. Jana Pawła II', N'13', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(5 AS Numeric(8, 0)), N'54-335', N'Wrocław', N'Pl. Grunwaldzki', N'6a', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(6 AS Numeric(8, 0)), N'51-334', N'Wrocław', N'Nowowiejska', N'32', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(7 AS Numeric(8, 0)), N'53-435', N'Wrocław', N'Trzebnicka', N'44', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(8 AS Numeric(8, 0)), N'52-311', N'Wrocław', N'Żmigrodzka', N'1', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(9 AS Numeric(8, 0)), N'50-453', N'Wrocław', N'Obornicka', N'43', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(10 AS Numeric(8, 0)), N'50-335', N'Wrocław', N'Grunwaldzka', N'7', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(11 AS Numeric(8, 0)), N'51-385', N'Wrocław', N'Pl. Grunwaldzki', N'15', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(12 AS Numeric(8, 0)), N'50-321', N'Wrocław', N'Nowowiejska', N'16', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(13 AS Numeric(8, 0)), N'52-463', N'Wrocław', N'Świdnicka', N'75', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(14 AS Numeric(8, 0)), N'52-358', N'Wrocław', N'Ruska', N'33', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(15 AS Numeric(8, 0)), N'50-355', N'Wrocław', N'Legnicka', N'9', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(16 AS Numeric(8, 0)), N'53-405', N'Wrocław', N'Kolista', N'2', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(17 AS Numeric(8, 0)), N'51-321', N'Wrocław', N'Niedźwiedzia', N'42', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(18 AS Numeric(8, 0)), N'50-345', N'Wrocław', N'Pl. Dominikański', N'11', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(19 AS Numeric(8, 0)), N'55-373', N'Wrocław', N'Wyszyńskiego', N'7', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(20 AS Numeric(8, 0)), N'52-352', N'Wrocław', N'Szczytnicka', N'58', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(21 AS Numeric(8, 0)), N'50-455', N'Wrocław', N'Katedralna', N'89', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(22 AS Numeric(8, 0)), N'50-355', N'Wrocław', N'Pl. Bema', N'22', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(23 AS Numeric(8, 0)), N'50-345', N'Wrocław', N'Rydygiera', N'28', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(24 AS Numeric(8, 0)), N'53-456', N'Wrocław', N'Nożownicza', N'36', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(25 AS Numeric(8, 0)), N'50-355', N'Wrocław', N'Krupnicza', N'57', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(26 AS Numeric(8, 0)), N'51-345', N'Wrocław', N'Szewska', N'39', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(27 AS Numeric(8, 0)), N'50-355', N'Wrocław', N'Wojanowska', N'41', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(28 AS Numeric(8, 0)), N'50-456', N'Wrocław', N'Arbuzowa', N'27', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(29 AS Numeric(8, 0)), N'50-378', N'Wrocław', N'Kasprowicza', N'83', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(30 AS Numeric(8, 0)), N'52-455', N'Wrocław', N'Sienkiewicza', N'3', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(31 AS Numeric(8, 0)), N'50-334', N'Wrocław', N'Broniewskiego', N'67', NULL)
INSERT [dbo].[adres_zamieszkania] ([adres_zamieszkania], [kod_pocz], [Miasto], [Ulica], [nr_bud], [nr_miesz]) VALUES (CAST(32 AS Numeric(8, 0)), N'53-455', N'Wrocław', N'Kleczkowska', N'5', NULL)
SET IDENTITY_INSERT [dbo].[adres_zamieszkania] OFF
SET IDENTITY_INSERT [dbo].[Klasa] ON 

INSERT [dbo].[Klasa] ([id_klasy], [stopien], [numer], [id_nauczyciela], [specjalizacja]) VALUES (CAST(1 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)), CAST(1 AS Numeric(1, 0)), CAST(5 AS Numeric(8, 0)), N'Humanistyczna')
INSERT [dbo].[Klasa] ([id_klasy], [stopien], [numer], [id_nauczyciela], [specjalizacja]) VALUES (CAST(2 AS Numeric(8, 0)), CAST(2 AS Numeric(1, 0)), CAST(1 AS Numeric(1, 0)), CAST(2 AS Numeric(8, 0)), N'Matematyczna')
INSERT [dbo].[Klasa] ([id_klasy], [stopien], [numer], [id_nauczyciela], [specjalizacja]) VALUES (CAST(3 AS Numeric(8, 0)), CAST(3 AS Numeric(1, 0)), CAST(1 AS Numeric(1, 0)), CAST(7 AS Numeric(8, 0)), N'Lingwistyczna')
SET IDENTITY_INSERT [dbo].[Klasa] OFF
SET IDENTITY_INSERT [dbo].[Komentarz] ON 

INSERT [dbo].[Komentarz] ([id_komentarza], [tytul], [komentarz], [id_ucznia], [id_nauczyciela], [data]) VALUES (CAST(1 AS Numeric(8, 0)), N'Pochwała', N'Uczeń/Uczennica dostał/a bardzo dobrą ocenę', CAST(1 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)), NULL)
INSERT [dbo].[Komentarz] ([id_komentarza], [tytul], [komentarz], [id_ucznia], [id_nauczyciela], [data]) VALUES (CAST(2 AS Numeric(8, 0)), N'Pochwała', N'Uczeń/Uczennica dostał/a bardzo dobrą ocenę', CAST(13 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), NULL)
INSERT [dbo].[Komentarz] ([id_komentarza], [tytul], [komentarz], [id_ucznia], [id_nauczyciela], [data]) VALUES (CAST(3 AS Numeric(8, 0)), N'Pochwała', N'Uczeń/Uczennica dostał/a bardzo dobrą ocenę', CAST(17 AS Numeric(8, 0)), CAST(7 AS Numeric(8, 0)), NULL)
INSERT [dbo].[Komentarz] ([id_komentarza], [tytul], [komentarz], [id_ucznia], [id_nauczyciela], [data]) VALUES (CAST(4 AS Numeric(8, 0)), N'Pochwała', N'Uczeń/Uczennica dostał/a bardzo dobrą ocenę', CAST(19 AS Numeric(8, 0)), CAST(7 AS Numeric(8, 0)), NULL)
INSERT [dbo].[Komentarz] ([id_komentarza], [tytul], [komentarz], [id_ucznia], [id_nauczyciela], [data]) VALUES (CAST(5 AS Numeric(8, 0)), N'Pochwała', N'Uczeń/Uczennica dostał/a bardzo dobrą ocenę', CAST(8 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), NULL)
INSERT [dbo].[Komentarz] ([id_komentarza], [tytul], [komentarz], [id_ucznia], [id_nauczyciela], [data]) VALUES (CAST(6 AS Numeric(8, 0)), N'Pochwała', N'Uczeń/Uczennica dostał/a bardzo dobrą ocenę', CAST(9 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), NULL)
INSERT [dbo].[Komentarz] ([id_komentarza], [tytul], [komentarz], [id_ucznia], [id_nauczyciela], [data]) VALUES (CAST(7 AS Numeric(8, 0)), N'Ostrzeżenie', N'Uczeń/Uczennica dostał/a ocenę niedsotateczną!', CAST(12 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), NULL)
INSERT [dbo].[Komentarz] ([id_komentarza], [tytul], [komentarz], [id_ucznia], [id_nauczyciela], [data]) VALUES (CAST(8 AS Numeric(8, 0)), N'Ostrzeżenie', N'Uczeń/Uczennica dostał/a ocenę niedsotateczną!', CAST(5 AS Numeric(8, 0)), CAST(6 AS Numeric(8, 0)), NULL)
INSERT [dbo].[Komentarz] ([id_komentarza], [tytul], [komentarz], [id_ucznia], [id_nauczyciela], [data]) VALUES (CAST(9 AS Numeric(8, 0)), N'Ostrzeżenie', N'Uczeń/Uczennica dostał/a ocenę niedsotateczną!', CAST(5 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)), NULL)
SET IDENTITY_INSERT [dbo].[Komentarz] OFF
SET IDENTITY_INSERT [dbo].[Lekcja] ON 

INSERT [dbo].[Lekcja] ([id_lekcji], [tytul], [id_nauczyciela], [id_klasy], [data], [sala], [uwagi]) VALUES (CAST(1 AS Numeric(8, 0)), N'j.polski', CAST(5 AS Numeric(8, 0)), CAST(1 AS Numeric(8, 0)), CAST(N'2016-11-29' AS Date), N'7', NULL)
INSERT [dbo].[Lekcja] ([id_lekcji], [tytul], [id_nauczyciela], [id_klasy], [data], [sala], [uwagi]) VALUES (CAST(2 AS Numeric(8, 0)), N'matematyka', CAST(6 AS Numeric(8, 0)), CAST(1 AS Numeric(8, 0)), CAST(N'2016-12-01' AS Date), N'1', NULL)
INSERT [dbo].[Lekcja] ([id_lekcji], [tytul], [id_nauczyciela], [id_klasy], [data], [sala], [uwagi]) VALUES (CAST(3 AS Numeric(8, 0)), N'j.angielski', CAST(1 AS Numeric(8, 0)), CAST(1 AS Numeric(8, 0)), CAST(N'2016-11-30' AS Date), N'4', NULL)
INSERT [dbo].[Lekcja] ([id_lekcji], [tytul], [id_nauczyciela], [id_klasy], [data], [sala], [uwagi]) VALUES (CAST(4 AS Numeric(8, 0)), N'j.polski', CAST(3 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), CAST(N'2016-12-01' AS Date), N'8', NULL)
INSERT [dbo].[Lekcja] ([id_lekcji], [tytul], [id_nauczyciela], [id_klasy], [data], [sala], [uwagi]) VALUES (CAST(5 AS Numeric(8, 0)), N'matematyka', CAST(2 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), CAST(N'2016-11-29' AS Date), N'2', NULL)
INSERT [dbo].[Lekcja] ([id_lekcji], [tytul], [id_nauczyciela], [id_klasy], [data], [sala], [uwagi]) VALUES (CAST(6 AS Numeric(8, 0)), N'angielski', CAST(7 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), CAST(N'2016-11-30' AS Date), N'5', NULL)
INSERT [dbo].[Lekcja] ([id_lekcji], [tytul], [id_nauczyciela], [id_klasy], [data], [sala], [uwagi]) VALUES (CAST(7 AS Numeric(8, 0)), N'j.polski', CAST(8 AS Numeric(8, 0)), CAST(3 AS Numeric(8, 0)), CAST(N'2016-11-30' AS Date), N'9', NULL)
INSERT [dbo].[Lekcja] ([id_lekcji], [tytul], [id_nauczyciela], [id_klasy], [data], [sala], [uwagi]) VALUES (CAST(8 AS Numeric(8, 0)), N'matematyka', CAST(4 AS Numeric(8, 0)), CAST(3 AS Numeric(8, 0)), CAST(N'2016-12-01' AS Date), N'3', NULL)
INSERT [dbo].[Lekcja] ([id_lekcji], [tytul], [id_nauczyciela], [id_klasy], [data], [sala], [uwagi]) VALUES (CAST(9 AS Numeric(8, 0)), N'angielski', CAST(7 AS Numeric(8, 0)), CAST(3 AS Numeric(8, 0)), CAST(N'2016-11-29' AS Date), N'6', NULL)
SET IDENTITY_INSERT [dbo].[Lekcja] OFF
SET IDENTITY_INSERT [dbo].[Nauczyciel] ON 

INSERT [dbo].[Nauczyciel] ([id_nauczyciela], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [stanowisko], [zarobki], [staz], [numer_umowy]) VALUES (CAST(1 AS Numeric(8, 0)), N'Piotr', N'Wójcik', CAST(1 AS Numeric(8, 0)), CAST(73072305432 AS Numeric(11, 0)), NULL, NULL, NULL, NULL)
INSERT [dbo].[Nauczyciel] ([id_nauczyciela], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [stanowisko], [zarobki], [staz], [numer_umowy]) VALUES (CAST(2 AS Numeric(8, 0)), N'Mikołaj', N'Świątek', CAST(2 AS Numeric(8, 0)), CAST(77120607431 AS Numeric(11, 0)), NULL, NULL, NULL, NULL)
INSERT [dbo].[Nauczyciel] ([id_nauczyciela], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [stanowisko], [zarobki], [staz], [numer_umowy]) VALUES (CAST(3 AS Numeric(8, 0)), N'Anna', N'Mazur', CAST(3 AS Numeric(8, 0)), CAST(81030316742 AS Numeric(11, 0)), NULL, NULL, NULL, NULL)
INSERT [dbo].[Nauczyciel] ([id_nauczyciela], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [stanowisko], [zarobki], [staz], [numer_umowy]) VALUES (CAST(4 AS Numeric(8, 0)), N'Wiktoria', N'Wawrzyniak', CAST(4 AS Numeric(8, 0)), CAST(75051514565 AS Numeric(11, 0)), NULL, NULL, NULL, NULL)
INSERT [dbo].[Nauczyciel] ([id_nauczyciela], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [stanowisko], [zarobki], [staz], [numer_umowy]) VALUES (CAST(5 AS Numeric(8, 0)), N'Kazimiera', N'Paździor', CAST(5 AS Numeric(8, 0)), CAST(56060713621 AS Numeric(11, 0)), NULL, NULL, NULL, NULL)
INSERT [dbo].[Nauczyciel] ([id_nauczyciela], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [stanowisko], [zarobki], [staz], [numer_umowy]) VALUES (CAST(6 AS Numeric(8, 0)), N'Paweł', N'Janas', CAST(6 AS Numeric(8, 0)), CAST(83082703146 AS Numeric(11, 0)), NULL, NULL, NULL, NULL)
INSERT [dbo].[Nauczyciel] ([id_nauczyciela], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [stanowisko], [zarobki], [staz], [numer_umowy]) VALUES (CAST(7 AS Numeric(8, 0)), N'Adam', N'Duda', CAST(7 AS Numeric(8, 0)), CAST(76091107623 AS Numeric(11, 0)), NULL, NULL, NULL, NULL)
INSERT [dbo].[Nauczyciel] ([id_nauczyciela], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [stanowisko], [zarobki], [staz], [numer_umowy]) VALUES (CAST(8 AS Numeric(8, 0)), N'Beata', N'Wesołowska', CAST(8 AS Numeric(8, 0)), CAST(79010101967 AS Numeric(11, 0)), NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Nauczyciel] OFF
SET IDENTITY_INSERT [dbo].[Ocena] ON 

INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(1 AS Numeric(8, 0)), N'Odpowiedź ustna', CAST(5 AS Numeric(1, 0)), NULL, CAST(1 AS Numeric(1, 0)), CAST(1 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)), CAST(1 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(2 AS Numeric(8, 0)), N'Odpowiedź ustna', CAST(3 AS Numeric(1, 0)), NULL, CAST(1 AS Numeric(1, 0)), CAST(2 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)), CAST(1 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(3 AS Numeric(8, 0)), N'Odpowiedź ustna', CAST(2 AS Numeric(1, 0)), NULL, CAST(1 AS Numeric(1, 0)), CAST(3 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)), CAST(1 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(4 AS Numeric(8, 0)), N'Odpowiedź ustna', CAST(4 AS Numeric(1, 0)), NULL, CAST(1 AS Numeric(1, 0)), CAST(4 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)), CAST(1 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(5 AS Numeric(8, 0)), N'Odpowiedź ustna', CAST(1 AS Numeric(1, 0)), NULL, CAST(1 AS Numeric(1, 0)), CAST(5 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)), CAST(1 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(6 AS Numeric(8, 0)), N'Sprawdzian', CAST(4 AS Numeric(1, 0)), NULL, CAST(2 AS Numeric(1, 0)), CAST(6 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(7 AS Numeric(8, 0)), N'Sprawdzian', CAST(3 AS Numeric(1, 0)), NULL, CAST(2 AS Numeric(1, 0)), CAST(7 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(8 AS Numeric(8, 0)), N'Sprawdzian', CAST(5 AS Numeric(1, 0)), NULL, CAST(2 AS Numeric(1, 0)), CAST(8 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(9 AS Numeric(8, 0)), N'Sprawdzian', CAST(5 AS Numeric(1, 0)), NULL, CAST(2 AS Numeric(1, 0)), CAST(9 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(10 AS Numeric(8, 0)), N'Sprawdzian', CAST(2 AS Numeric(1, 0)), NULL, CAST(2 AS Numeric(1, 0)), CAST(10 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(11 AS Numeric(8, 0)), N'Sprawdzian', CAST(3 AS Numeric(1, 0)), NULL, CAST(2 AS Numeric(1, 0)), CAST(11 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(12 AS Numeric(8, 0)), N'Sprawdzian', CAST(1 AS Numeric(1, 0)), NULL, CAST(2 AS Numeric(1, 0)), CAST(12 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(13 AS Numeric(8, 0)), N'Sprawdzian', CAST(5 AS Numeric(1, 0)), NULL, CAST(2 AS Numeric(1, 0)), CAST(13 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(14 AS Numeric(8, 0)), N'Sprawdzian', CAST(4 AS Numeric(1, 0)), NULL, CAST(2 AS Numeric(1, 0)), CAST(14 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(15 AS Numeric(8, 0)), N'Sprawdzian', CAST(4 AS Numeric(1, 0)), NULL, CAST(2 AS Numeric(1, 0)), CAST(15 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(16 AS Numeric(8, 0)), N'Kartkówka', CAST(3 AS Numeric(1, 0)), NULL, CAST(1 AS Numeric(1, 0)), CAST(16 AS Numeric(8, 0)), CAST(7 AS Numeric(8, 0)), CAST(9 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(17 AS Numeric(8, 0)), N'Kartkówka', CAST(5 AS Numeric(1, 0)), NULL, CAST(1 AS Numeric(1, 0)), CAST(17 AS Numeric(8, 0)), CAST(7 AS Numeric(8, 0)), CAST(9 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(18 AS Numeric(8, 0)), N'Kartkówka', CAST(4 AS Numeric(1, 0)), NULL, CAST(1 AS Numeric(1, 0)), CAST(18 AS Numeric(8, 0)), CAST(7 AS Numeric(8, 0)), CAST(9 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(19 AS Numeric(8, 0)), N'Kartkówka', CAST(5 AS Numeric(1, 0)), NULL, CAST(1 AS Numeric(1, 0)), CAST(19 AS Numeric(8, 0)), CAST(7 AS Numeric(8, 0)), CAST(9 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(20 AS Numeric(8, 0)), N'Kartkówka', CAST(3 AS Numeric(1, 0)), NULL, CAST(1 AS Numeric(1, 0)), CAST(20 AS Numeric(8, 0)), CAST(7 AS Numeric(8, 0)), CAST(9 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(21 AS Numeric(8, 0)), N'Kartkówka', CAST(2 AS Numeric(1, 0)), NULL, CAST(1 AS Numeric(1, 0)), CAST(21 AS Numeric(8, 0)), CAST(7 AS Numeric(8, 0)), CAST(9 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(22 AS Numeric(8, 0)), N'Kartkówka', CAST(4 AS Numeric(1, 0)), NULL, CAST(1 AS Numeric(1, 0)), CAST(22 AS Numeric(8, 0)), CAST(7 AS Numeric(8, 0)), CAST(9 AS Numeric(8, 0)))
INSERT [dbo].[Ocena] ([id_oceny], [tytul], [ocena], [modyfikator], [Waga], [id_ucznia], [id_nauczyciela], [id_lekcji]) VALUES (CAST(23 AS Numeric(8, 0)), N'Brak zadania', CAST(1 AS Numeric(1, 0)), NULL, CAST(1 AS Numeric(1, 0)), CAST(5 AS Numeric(8, 0)), CAST(6 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)))
SET IDENTITY_INSERT [dbo].[Ocena] OFF
SET IDENTITY_INSERT [dbo].[Opiekun] ON 

INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(1 AS Numeric(8, 0)), N'Paweł', N'Nowak', CAST(76010703475 AS Numeric(11, 0)), CAST(9 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(2 AS Numeric(8, 0)), N'Anna', N'Kowalska', CAST(77021113465 AS Numeric(11, 0)), CAST(10 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(3 AS Numeric(8, 0)), N'Ewa', N'Paluszek', CAST(73050513254 AS Numeric(11, 0)), CAST(11 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(4 AS Numeric(8, 0)), N'Gabriela', N'Owczarek', CAST(81050213498 AS Numeric(11, 0)), CAST(12 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(5 AS Numeric(8, 0)), N'Mirek', N'Kalisz', CAST(68032004875 AS Numeric(11, 0)), CAST(13 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(6 AS Numeric(8, 0)), N'Jan', N'Szymański', CAST(69021201653 AS Numeric(11, 0)), CAST(14 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(7 AS Numeric(8, 0)), N'Leszek', N'Dziuba', CAST(70072208361 AS Numeric(11, 0)), CAST(15 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(8 AS Numeric(8, 0)), N'Kamil', N'Jednacz', CAST(76052719573 AS Numeric(11, 0)), CAST(16 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(9 AS Numeric(8, 0)), N'Robert', N'Milik', CAST(79041201542 AS Numeric(11, 0)), CAST(17 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(10 AS Numeric(8, 0)), N'Aleksander', N'Rzeźniczak', CAST(73050508674 AS Numeric(11, 0)), CAST(18 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(11 AS Numeric(8, 0)), N'Ryszard', N'Skorupski', CAST(72030303893 AS Numeric(11, 0)), CAST(19 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(12 AS Numeric(8, 0)), N'Grażyna', N'Kordiak', CAST(71031314565 AS Numeric(11, 0)), CAST(20 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(13 AS Numeric(8, 0)), N'Maria', N'Błaszczak', CAST(64021717634 AS Numeric(11, 0)), CAST(21 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(14 AS Numeric(8, 0)), N'Arkadiusz', N'Lewandowski', CAST(69111408723 AS Numeric(11, 0)), CAST(22 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(15 AS Numeric(8, 0)), N'Wojciech', N'Wasilewski', CAST(73061604763 AS Numeric(11, 0)), CAST(23 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(16 AS Numeric(8, 0)), N'Marek', N'Sobala', CAST(71070806745 AS Numeric(11, 0)), CAST(24 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(17 AS Numeric(8, 0)), N'Piotr', N'Tyrcz', CAST(77032312658 AS Numeric(11, 0)), CAST(25 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(18 AS Numeric(8, 0)), N'Adam', N'Tylus', CAST(74071615643 AS Numeric(11, 0)), CAST(26 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(19 AS Numeric(8, 0)), N'Wioletta', N'Gryniewicz', CAST(67051918789 AS Numeric(11, 0)), CAST(27 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(20 AS Numeric(8, 0)), N'Kamila', N'Karczmarczyk', CAST(78021213443 AS Numeric(11, 0)), CAST(28 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(21 AS Numeric(8, 0)), N'Czesław', N'Ruszkiewicz', CAST(82112106775 AS Numeric(11, 0)), CAST(29 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(22 AS Numeric(8, 0)), N'Szymon', N'Kucharczak', CAST(81050202244 AS Numeric(11, 0)), CAST(30 AS Numeric(8, 0)))
INSERT [dbo].[Opiekun] ([id_opiekuna], [imie], [nazwisko], [PESEL], [adres_zamieszkania]) VALUES (CAST(25 AS Numeric(8, 0)), N'tewd', N'ds', CAST(12 AS Numeric(11, 0)), CAST(1 AS Numeric(8, 0)))
SET IDENTITY_INSERT [dbo].[Opiekun] OFF
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(1 AS Numeric(8, 0)), CAST(1 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(1 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(1 AS Numeric(8, 0)), CAST(3 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(1 AS Numeric(8, 0)), CAST(4 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(1 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(5 AS Numeric(8, 0)), CAST(6 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(5 AS Numeric(8, 0)), CAST(7 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(5 AS Numeric(8, 0)), CAST(8 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(5 AS Numeric(8, 0)), CAST(9 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(5 AS Numeric(8, 0)), CAST(10 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(5 AS Numeric(8, 0)), CAST(11 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(5 AS Numeric(8, 0)), CAST(12 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(5 AS Numeric(8, 0)), CAST(13 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(5 AS Numeric(8, 0)), CAST(14 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(5 AS Numeric(8, 0)), CAST(15 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(9 AS Numeric(8, 0)), CAST(16 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(9 AS Numeric(8, 0)), CAST(17 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(9 AS Numeric(8, 0)), CAST(18 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(9 AS Numeric(8, 0)), CAST(19 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(9 AS Numeric(8, 0)), CAST(20 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(9 AS Numeric(8, 0)), CAST(21 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(9 AS Numeric(8, 0)), CAST(22 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(2 AS Numeric(8, 0)), CAST(1 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(2 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(2 AS Numeric(8, 0)), CAST(3 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(2 AS Numeric(8, 0)), CAST(4 AS Numeric(8, 0)), CAST(0 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(2 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(4 AS Numeric(8, 0)), CAST(6 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(4 AS Numeric(8, 0)), CAST(7 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(4 AS Numeric(8, 0)), CAST(8 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(4 AS Numeric(8, 0)), CAST(9 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(4 AS Numeric(8, 0)), CAST(10 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(4 AS Numeric(8, 0)), CAST(11 AS Numeric(8, 0)), CAST(0 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(4 AS Numeric(8, 0)), CAST(12 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(4 AS Numeric(8, 0)), CAST(13 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(4 AS Numeric(8, 0)), CAST(14 AS Numeric(8, 0)), CAST(0 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(4 AS Numeric(8, 0)), CAST(15 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(7 AS Numeric(8, 0)), CAST(16 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(7 AS Numeric(8, 0)), CAST(17 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(7 AS Numeric(8, 0)), CAST(18 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(7 AS Numeric(8, 0)), CAST(19 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(7 AS Numeric(8, 0)), CAST(20 AS Numeric(8, 0)), CAST(0 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(7 AS Numeric(8, 0)), CAST(21 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(7 AS Numeric(8, 0)), CAST(22 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(3 AS Numeric(8, 0)), CAST(1 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(3 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(3 AS Numeric(8, 0)), CAST(3 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(3 AS Numeric(8, 0)), CAST(4 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(3 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(6 AS Numeric(8, 0)), CAST(6 AS Numeric(8, 0)), CAST(0 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(6 AS Numeric(8, 0)), CAST(7 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(6 AS Numeric(8, 0)), CAST(8 AS Numeric(8, 0)), CAST(0 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(6 AS Numeric(8, 0)), CAST(9 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(6 AS Numeric(8, 0)), CAST(10 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(6 AS Numeric(8, 0)), CAST(11 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(6 AS Numeric(8, 0)), CAST(12 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(6 AS Numeric(8, 0)), CAST(13 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(6 AS Numeric(8, 0)), CAST(14 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(6 AS Numeric(8, 0)), CAST(15 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(8 AS Numeric(8, 0)), CAST(16 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(8 AS Numeric(8, 0)), CAST(17 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(8 AS Numeric(8, 0)), CAST(18 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(8 AS Numeric(8, 0)), CAST(19 AS Numeric(8, 0)), CAST(0 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(8 AS Numeric(8, 0)), CAST(20 AS Numeric(8, 0)), CAST(0 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(8 AS Numeric(8, 0)), CAST(21 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
INSERT [dbo].[Plan_lekcji] ([id_lekcji], [id_ucznia], [frekwencja]) VALUES (CAST(8 AS Numeric(8, 0)), CAST(22 AS Numeric(8, 0)), CAST(1 AS Numeric(1, 0)))
SET IDENTITY_INSERT [dbo].[Uczen] ON 

INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(1 AS Numeric(8, 0)), N'Artur', N'Nowak', CAST(9 AS Numeric(8, 0)), CAST(20010104576 AS Numeric(11, 0)), CAST(1 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(2 AS Numeric(8, 0)), N'Magłorzata', N'Kowalska', CAST(10 AS Numeric(8, 0)), CAST(20081119745 AS Numeric(11, 0)), CAST(1 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(3 AS Numeric(8, 0)), N'Basia', N'Paluszek', CAST(11 AS Numeric(8, 0)), CAST(20110512376 AS Numeric(11, 0)), CAST(1 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(4 AS Numeric(8, 0)), N'Monika', N'Owczarek', CAST(12 AS Numeric(8, 0)), CAST(20010911325 AS Numeric(11, 0)), CAST(1 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(5 AS Numeric(8, 0)), N'Adrian', N'Kalisz', CAST(13 AS Numeric(8, 0)), CAST(20032705652 AS Numeric(11, 0)), CAST(1 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(6 AS Numeric(8, 0)), N'Arkadiusz', N'Szymański', CAST(14 AS Numeric(8, 0)), CAST(99051207634 AS Numeric(11, 0)), CAST(2 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(7 AS Numeric(8, 0)), N'Adam', N'Dziuba', CAST(15 AS Numeric(8, 0)), CAST(99072207643 AS Numeric(11, 0)), CAST(2 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(8 AS Numeric(8, 0)), N'Amanda', N'Jednacz', CAST(16 AS Numeric(8, 0)), CAST(99042118745 AS Numeric(11, 0)), CAST(2 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(9 AS Numeric(8, 0)), N'Karol', N'Milik', CAST(17 AS Numeric(8, 0)), CAST(99091107624 AS Numeric(11, 0)), CAST(2 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(10 AS Numeric(8, 0)), N'Dawid', N'Rzeźniczak', CAST(18 AS Numeric(8, 0)), CAST(99060608734 AS Numeric(11, 0)), CAST(2 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(11 AS Numeric(8, 0)), N'Piotr', N'Skorupski', CAST(19 AS Numeric(8, 0)), CAST(99111106523 AS Numeric(11, 0)), CAST(2 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(12 AS Numeric(8, 0)), N'Agnieszka', N'Kordiak', CAST(20 AS Numeric(8, 0)), CAST(99012915423 AS Numeric(11, 0)), CAST(2 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(13 AS Numeric(8, 0)), N'Ola', N'Błaszczak', CAST(21 AS Numeric(8, 0)), CAST(99022514622 AS Numeric(11, 0)), CAST(2 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(14 AS Numeric(8, 0)), N'Wojtek', N'Lewandowski', CAST(22 AS Numeric(8, 0)), CAST(99121202456 AS Numeric(11, 0)), CAST(2 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(15 AS Numeric(8, 0)), N'Mariusz', N'Wasilewski', CAST(23 AS Numeric(8, 0)), CAST(99041106587 AS Numeric(11, 0)), CAST(2 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(16 AS Numeric(8, 0)), N'Bartosz', N'Sobala', CAST(24 AS Numeric(8, 0)), CAST(98010805687 AS Numeric(11, 0)), CAST(3 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(17 AS Numeric(8, 0)), N'Anita', N'Tyrcz', CAST(25 AS Numeric(8, 0)), CAST(98022619834 AS Numeric(11, 0)), CAST(3 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(18 AS Numeric(8, 0)), N'Wiktoria', N'Tylus', CAST(26 AS Numeric(8, 0)), CAST(98050811265 AS Numeric(11, 0)), CAST(3 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(19 AS Numeric(8, 0)), N'Weronika', N'Gryniewicz', CAST(27 AS Numeric(8, 0)), CAST(98081412376 AS Numeric(11, 0)), CAST(3 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(20 AS Numeric(8, 0)), N'Klaudia', N'Karczmarczyk', CAST(28 AS Numeric(8, 0)), CAST(98092711276 AS Numeric(11, 0)), CAST(3 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(21 AS Numeric(8, 0)), N'Damian', N'Ruszkiewicz', CAST(29 AS Numeric(8, 0)), CAST(98112504863 AS Numeric(11, 0)), CAST(3 AS Numeric(8, 0)))
INSERT [dbo].[Uczen] ([id_ucznia], [imie], [nazwisko], [adres_zamieszkania], [PESEL], [id_klasy]) VALUES (CAST(22 AS Numeric(8, 0)), N'Mateusz', N'Kucharczak', CAST(30 AS Numeric(8, 0)), CAST(98030307634 AS Numeric(11, 0)), CAST(3 AS Numeric(8, 0)))
SET IDENTITY_INSERT [dbo].[Uczen] OFF
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(1 AS Numeric(8, 0)), CAST(1 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(2 AS Numeric(8, 0)), CAST(2 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(3 AS Numeric(8, 0)), CAST(3 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(4 AS Numeric(8, 0)), CAST(4 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(5 AS Numeric(8, 0)), CAST(5 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(6 AS Numeric(8, 0)), CAST(6 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(7 AS Numeric(8, 0)), CAST(7 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(8 AS Numeric(8, 0)), CAST(8 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(9 AS Numeric(8, 0)), CAST(9 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(10 AS Numeric(8, 0)), CAST(10 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(11 AS Numeric(8, 0)), CAST(11 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(12 AS Numeric(8, 0)), CAST(12 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(13 AS Numeric(8, 0)), CAST(13 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(14 AS Numeric(8, 0)), CAST(14 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(15 AS Numeric(8, 0)), CAST(15 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(16 AS Numeric(8, 0)), CAST(16 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(17 AS Numeric(8, 0)), CAST(17 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(18 AS Numeric(8, 0)), CAST(18 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(19 AS Numeric(8, 0)), CAST(19 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(20 AS Numeric(8, 0)), CAST(20 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(21 AS Numeric(8, 0)), CAST(21 AS Numeric(8, 0)))
INSERT [dbo].[uczen_opiekun] ([id_ucznia], [id_opiekuna]) VALUES (CAST(22 AS Numeric(8, 0)), CAST(22 AS Numeric(8, 0)))
ALTER TABLE [dbo].[Klasa]  WITH CHECK ADD  CONSTRAINT [Klasa_id_nauczyciela_FK] FOREIGN KEY([id_nauczyciela])
REFERENCES [dbo].[Nauczyciel] ([id_nauczyciela])
GO
ALTER TABLE [dbo].[Klasa] CHECK CONSTRAINT [Klasa_id_nauczyciela_FK]
GO
ALTER TABLE [dbo].[Komentarz]  WITH CHECK ADD  CONSTRAINT [Komentarz_id_nauczyciela_FK] FOREIGN KEY([id_nauczyciela])
REFERENCES [dbo].[Nauczyciel] ([id_nauczyciela])
GO
ALTER TABLE [dbo].[Komentarz] CHECK CONSTRAINT [Komentarz_id_nauczyciela_FK]
GO
ALTER TABLE [dbo].[Komentarz]  WITH CHECK ADD  CONSTRAINT [Komentarz_id_ucznia_FK] FOREIGN KEY([id_ucznia])
REFERENCES [dbo].[Uczen] ([id_ucznia])
GO
ALTER TABLE [dbo].[Komentarz] CHECK CONSTRAINT [Komentarz_id_ucznia_FK]
GO
ALTER TABLE [dbo].[Lekcja]  WITH CHECK ADD  CONSTRAINT [Lekcja_id_klasy_FK] FOREIGN KEY([id_klasy])
REFERENCES [dbo].[Klasa] ([id_klasy])
GO
ALTER TABLE [dbo].[Lekcja] CHECK CONSTRAINT [Lekcja_id_klasy_FK]
GO
ALTER TABLE [dbo].[Lekcja]  WITH CHECK ADD  CONSTRAINT [Lekcja_id_nauczyciela_FK] FOREIGN KEY([id_nauczyciela])
REFERENCES [dbo].[Nauczyciel] ([id_nauczyciela])
GO
ALTER TABLE [dbo].[Lekcja] CHECK CONSTRAINT [Lekcja_id_nauczyciela_FK]
GO
ALTER TABLE [dbo].[Nauczyciel]  WITH CHECK ADD  CONSTRAINT [Nauczyciel_adres_zamieszkania_FK] FOREIGN KEY([adres_zamieszkania])
REFERENCES [dbo].[adres_zamieszkania] ([adres_zamieszkania])
GO
ALTER TABLE [dbo].[Nauczyciel] CHECK CONSTRAINT [Nauczyciel_adres_zamieszkania_FK]
GO
ALTER TABLE [dbo].[Ocena]  WITH CHECK ADD  CONSTRAINT [Ocena_id_lekcji_FK] FOREIGN KEY([id_lekcji])
REFERENCES [dbo].[Lekcja] ([id_lekcji])
GO
ALTER TABLE [dbo].[Ocena] CHECK CONSTRAINT [Ocena_id_lekcji_FK]
GO
ALTER TABLE [dbo].[Ocena]  WITH CHECK ADD  CONSTRAINT [Ocena_id_nauczyciela_FK] FOREIGN KEY([id_nauczyciela])
REFERENCES [dbo].[Nauczyciel] ([id_nauczyciela])
GO
ALTER TABLE [dbo].[Ocena] CHECK CONSTRAINT [Ocena_id_nauczyciela_FK]
GO
ALTER TABLE [dbo].[Ocena]  WITH CHECK ADD  CONSTRAINT [Ocena_id_ucznia_FK] FOREIGN KEY([id_ucznia])
REFERENCES [dbo].[Uczen] ([id_ucznia])
GO
ALTER TABLE [dbo].[Ocena] CHECK CONSTRAINT [Ocena_id_ucznia_FK]
GO
ALTER TABLE [dbo].[Opiekun]  WITH CHECK ADD  CONSTRAINT [Opiekun_adres_zamieszkania_FK] FOREIGN KEY([adres_zamieszkania])
REFERENCES [dbo].[adres_zamieszkania] ([adres_zamieszkania])
GO
ALTER TABLE [dbo].[Opiekun] CHECK CONSTRAINT [Opiekun_adres_zamieszkania_FK]
GO
ALTER TABLE [dbo].[Plan_lekcji]  WITH CHECK ADD  CONSTRAINT [Plan_lekcji_id_lekcji_FK] FOREIGN KEY([id_lekcji])
REFERENCES [dbo].[Lekcja] ([id_lekcji])
GO
ALTER TABLE [dbo].[Plan_lekcji] CHECK CONSTRAINT [Plan_lekcji_id_lekcji_FK]
GO
ALTER TABLE [dbo].[Plan_lekcji]  WITH CHECK ADD  CONSTRAINT [Plan_lekcji_id_ucznia_FK] FOREIGN KEY([id_ucznia])
REFERENCES [dbo].[Uczen] ([id_ucznia])
GO
ALTER TABLE [dbo].[Plan_lekcji] CHECK CONSTRAINT [Plan_lekcji_id_ucznia_FK]
GO
ALTER TABLE [dbo].[Uczen]  WITH CHECK ADD  CONSTRAINT [Uczen_adres_zamieszkania_FK] FOREIGN KEY([adres_zamieszkania])
REFERENCES [dbo].[adres_zamieszkania] ([adres_zamieszkania])
GO
ALTER TABLE [dbo].[Uczen] CHECK CONSTRAINT [Uczen_adres_zamieszkania_FK]
GO
ALTER TABLE [dbo].[Uczen]  WITH CHECK ADD  CONSTRAINT [Uczen_id_klasy_FK] FOREIGN KEY([id_klasy])
REFERENCES [dbo].[Klasa] ([id_klasy])
GO
ALTER TABLE [dbo].[Uczen] CHECK CONSTRAINT [Uczen_id_klasy_FK]
GO
ALTER TABLE [dbo].[uczen_opiekun]  WITH CHECK ADD  CONSTRAINT [uczen_opiekun_id_opiekuna_FK] FOREIGN KEY([id_opiekuna])
REFERENCES [dbo].[Opiekun] ([id_opiekuna])
GO
ALTER TABLE [dbo].[uczen_opiekun] CHECK CONSTRAINT [uczen_opiekun_id_opiekuna_FK]
GO
ALTER TABLE [dbo].[uczen_opiekun]  WITH CHECK ADD  CONSTRAINT [uczen_opiekun_id_ucznia_FK] FOREIGN KEY([id_ucznia])
REFERENCES [dbo].[Uczen] ([id_ucznia])
GO
ALTER TABLE [dbo].[uczen_opiekun] CHECK CONSTRAINT [uczen_opiekun_id_ucznia_FK]
GO
ALTER TABLE [dbo].[Ocena]  WITH CHECK ADD  CONSTRAINT [ocena_check_less_6] CHECK  (([ocena]>(0) AND [ocena]<=(6)))
GO
ALTER TABLE [dbo].[Ocena] CHECK CONSTRAINT [ocena_check_less_6]
GO
/****** Object:  StoredProcedure [dbo].[spAktualizujOpiekuna]    Script Date: 2017-04-20 02:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spAktualizujOpiekuna]
@id_opiekuna numeric(8,0), @imie varchar(20) = null, @nazwisko varchar(60) = null,
@adres numeric(8,0)= null, @PESEL numeric(11,0) = null
AS
BEGIN
UPDATE Opiekun
SET imie = ISNULL(@imie, imie), nazwisko = ISNULL(@nazwisko, nazwisko),
	adres_zamieszkania = ISNULL(@adres, adres_zamieszkania), PESEL = ISNULL(@PESEL, PESEL)		
WHERE id_opiekuna = @id_opiekuna
END

GO
USE [master]
GO
ALTER DATABASE [Dziennik_szkolny] SET  READ_WRITE 
GO
