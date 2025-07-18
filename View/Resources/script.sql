USE [master]
GO
/****** Object:  Database [PharmacyApp]    Script Date: 11-Jul-25 10:57:39 PM ******/
CREATE DATABASE [PharmacyApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PharmacyApp', FILENAME = N'C:\Users\milos\PharmacyApp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PharmacyApp_log', FILENAME = N'C:\Users\milos\PharmacyApp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PharmacyApp] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PharmacyApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PharmacyApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PharmacyApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PharmacyApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PharmacyApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PharmacyApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [PharmacyApp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PharmacyApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PharmacyApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PharmacyApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PharmacyApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PharmacyApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PharmacyApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PharmacyApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PharmacyApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PharmacyApp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PharmacyApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PharmacyApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PharmacyApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PharmacyApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PharmacyApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PharmacyApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PharmacyApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PharmacyApp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PharmacyApp] SET  MULTI_USER 
GO
ALTER DATABASE [PharmacyApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PharmacyApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PharmacyApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PharmacyApp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PharmacyApp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PharmacyApp] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PharmacyApp] SET QUERY_STORE = OFF
GO
USE [PharmacyApp]
GO
/****** Object:  Table [dbo].[Farmaceut]    Script Date: 11-Jul-25 10:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Farmaceut](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[KontaktTelefon] [varchar](50) NOT NULL,
	[DatumZaposlenja] [date] NOT NULL,
	[KorisnickoIme] [varchar](50) NOT NULL,
	[Lozinka] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Farmaceut] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FarmaceutLokacija]    Script Date: 11-Jul-25 10:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FarmaceutLokacija](
	[IdFarmaceut] [int] NOT NULL,
	[IdLokacija] [int] NOT NULL,
	[DatumIzdavanjaDozvole] [date] NOT NULL,
 CONSTRAINT [PK_FarmaceutLokacija] PRIMARY KEY CLUSTERED 
(
	[IdFarmaceut] ASC,
	[IdLokacija] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korisnik]    Script Date: 11-Jul-25 10:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnik](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[KontaktTelefon] [varchar](50) NOT NULL,
	[DatumUclanjenja] [date] NOT NULL,
	[GodineClanstva] [int] NOT NULL,
	[IdPromoKod] [int] NOT NULL,
 CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lek]    Script Date: 11-Jul-25 10:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lek](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NOT NULL,
	[RokTrajanja] [date] NOT NULL,
	[Kolicina] [int] NOT NULL,
	[ZemljaPorekla] [int] NOT NULL,
	[Cena] [float] NOT NULL,
 CONSTRAINT [PK_Lek] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lokacija]    Script Date: 11-Jul-25 10:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lokacija](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdresaLokacije] [varchar](50) NOT NULL,
	[Opstina] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Lokacija] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PromoKod]    Script Date: 11-Jul-25 10:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PromoKod](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IznosPopusta] [float] NOT NULL,
	[DatumNastanka] [date] NOT NULL,
 CONSTRAINT [PK_PromoKod] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Racun]    Script Date: 11-Jul-25 10:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Racun](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UkupnaVrednost] [float] NOT NULL,
	[IznosPoreza] [float] NOT NULL,
	[UkupnaVrednostSaPorezom] [float] NOT NULL,
	[DatumIzdavanja] [date] NOT NULL,
	[IdFarmaceut] [int] NOT NULL,
	[IdKorisnik] [int] NOT NULL,
 CONSTRAINT [PK_Racun] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StavkaRacuna]    Script Date: 11-Jul-25 10:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StavkaRacuna](
	[IdRacun] [int] NOT NULL,
	[RbStavke] [int] NOT NULL,
	[Kolicina] [int] NOT NULL,
	[ProdajnaVrednost] [float] NOT NULL,
	[IdLek] [int] NOT NULL,
 CONSTRAINT [PK_StavkaRacuna] PRIMARY KEY CLUSTERED 
(
	[IdRacun] ASC,
	[RbStavke] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Farmaceut] ON 

INSERT [dbo].[Farmaceut] ([Id], [Ime], [Prezime], [Email], [KontaktTelefon], [DatumZaposlenja], [KorisnickoIme], [Lozinka]) VALUES (1, N'Milos', N'Damjanovic', N'milos@gmail.com', N'060111111', CAST(N'2025-01-01' AS Date), N'shomica', N'milos123')
INSERT [dbo].[Farmaceut] ([Id], [Ime], [Prezime], [Email], [KontaktTelefon], [DatumZaposlenja], [KorisnickoIme], [Lozinka]) VALUES (2, N'admin', N'admin', N'admin', N'/', CAST(N'2025-01-01' AS Date), N'admin', N'admin')
INSERT [dbo].[Farmaceut] ([Id], [Ime], [Prezime], [Email], [KontaktTelefon], [DatumZaposlenja], [KorisnickoIme], [Lozinka]) VALUES (3, N'Sofija', N'Nikolic', N'sofija@gmail.com', N'0691343434', CAST(N'2025-01-01' AS Date), N'sofke', N'sofija123')
SET IDENTITY_INSERT [dbo].[Farmaceut] OFF
GO
SET IDENTITY_INSERT [dbo].[Korisnik] ON 

INSERT [dbo].[Korisnik] ([Id], [Ime], [Prezime], [Email], [KontaktTelefon], [DatumUclanjenja], [GodineClanstva], [IdPromoKod]) VALUES (3, N'Pera', N'Peric', N'pera@gmail.com', N'060111111', CAST(N'2020-03-21' AS Date), 5, 2)
INSERT [dbo].[Korisnik] ([Id], [Ime], [Prezime], [Email], [KontaktTelefon], [DatumUclanjenja], [GodineClanstva], [IdPromoKod]) VALUES (1003, N'jelena', N'markovic', N'jelena@gmail.com', N'0699999999', CAST(N'2020-03-21' AS Date), 5, 2)
INSERT [dbo].[Korisnik] ([Id], [Ime], [Prezime], [Email], [KontaktTelefon], [DatumUclanjenja], [GodineClanstva], [IdPromoKod]) VALUES (1004, N'Bojan', N'Peric', N'bojan@gmail.com', N'0622222', CAST(N'2020-03-21' AS Date), 5, 1002)
INSERT [dbo].[Korisnik] ([Id], [Ime], [Prezime], [Email], [KontaktTelefon], [DatumUclanjenja], [GodineClanstva], [IdPromoKod]) VALUES (2042, N'cAR', N'damjanovic', N'kraljevic@gmail.com', N'06134211', CAST(N'2025-06-04' AS Date), 0, 1036)
INSERT [dbo].[Korisnik] ([Id], [Ime], [Prezime], [Email], [KontaktTelefon], [DatumUclanjenja], [GodineClanstva], [IdPromoKod]) VALUES (3003, N'milica', N'pavlovic', N'milica@gmail.com', N'061321231', CAST(N'2025-06-04' AS Date), 0, 2004)
INSERT [dbo].[Korisnik] ([Id], [Ime], [Prezime], [Email], [KontaktTelefon], [DatumUclanjenja], [GodineClanstva], [IdPromoKod]) VALUES (3004, N'jovana', N'nikolic', N'jovana@gmail.com', N'/', CAST(N'2025-06-04' AS Date), 0, 2005)
INSERT [dbo].[Korisnik] ([Id], [Ime], [Prezime], [Email], [KontaktTelefon], [DatumUclanjenja], [GodineClanstva], [IdPromoKod]) VALUES (3010, N'lazar', N'markovic', N'laza02@gmail.com', N'067657567', CAST(N'2025-06-04' AS Date), 0, 2011)
INSERT [dbo].[Korisnik] ([Id], [Ime], [Prezime], [Email], [KontaktTelefon], [DatumUclanjenja], [GodineClanstva], [IdPromoKod]) VALUES (3016, N'vasilije', N'micic', N'vasa@gmail.com', N'061234125', CAST(N'2025-06-04' AS Date), 0, 2017)
INSERT [dbo].[Korisnik] ([Id], [Ime], [Prezime], [Email], [KontaktTelefon], [DatumUclanjenja], [GodineClanstva], [IdPromoKod]) VALUES (4003, N'Neuspeli', N'Racun', N'defaultkorisnik@gmail.com', N'/', CAST(N'2025-01-01' AS Date), 5, 2)
INSERT [dbo].[Korisnik] ([Id], [Ime], [Prezime], [Email], [KontaktTelefon], [DatumUclanjenja], [GodineClanstva], [IdPromoKod]) VALUES (8008, N'nevena', N'smiljanic', N'nena.smiljanic@gmailcom', N'+381123456', CAST(N'2025-07-02' AS Date), 0, 7009)
INSERT [dbo].[Korisnik] ([Id], [Ime], [Prezime], [Email], [KontaktTelefon], [DatumUclanjenja], [GodineClanstva], [IdPromoKod]) VALUES (8009, N'nicifor', N'kostadinovic', N'nicifor.carina@gmail.co', N'062452156', CAST(N'2025-07-02' AS Date), 0, 7010)
INSERT [dbo].[Korisnik] ([Id], [Ime], [Prezime], [Email], [KontaktTelefon], [DatumUclanjenja], [GodineClanstva], [IdPromoKod]) VALUES (10002, N'sofija', N'mladenovic', N'sofijam@gmail.com', N'064723612', CAST(N'2025-07-07' AS Date), 0, 9003)
INSERT [dbo].[Korisnik] ([Id], [Ime], [Prezime], [Email], [KontaktTelefon], [DatumUclanjenja], [GodineClanstva], [IdPromoKod]) VALUES (11002, N'mladena', N'trunisic', N'mladenaaa@gmail.com', N'0612412561', CAST(N'2025-07-11' AS Date), 0, 10003)
SET IDENTITY_INSERT [dbo].[Korisnik] OFF
GO
SET IDENTITY_INSERT [dbo].[Lek] ON 

INSERT [dbo].[Lek] ([Id], [Naziv], [RokTrajanja], [Kolicina], [ZemljaPorekla], [Cena]) VALUES (2, N'Šerbet grlo', CAST(N'2026-12-31' AS Date), 23, 2, 450)
INSERT [dbo].[Lek] ([Id], [Naziv], [RokTrajanja], [Kolicina], [ZemljaPorekla], [Cena]) VALUES (3, N'Antibiotik', CAST(N'2027-05-05' AS Date), 19, 1, 550.43)
INSERT [dbo].[Lek] ([Id], [Naziv], [RokTrajanja], [Kolicina], [ZemljaPorekla], [Cena]) VALUES (5, N'Bromazepam', CAST(N'2027-07-02' AS Date), 35, 0, 650)
INSERT [dbo].[Lek] ([Id], [Naziv], [RokTrajanja], [Kolicina], [ZemljaPorekla], [Cena]) VALUES (6, N'Sirup prehlada', CAST(N'2028-12-12' AS Date), 10, 3, 426.28)
INSERT [dbo].[Lek] ([Id], [Naziv], [RokTrajanja], [Kolicina], [ZemljaPorekla], [Cena]) VALUES (7, N'C + D3 kompleks', CAST(N'2030-01-31' AS Date), 4, 4, 299.99)
INSERT [dbo].[Lek] ([Id], [Naziv], [RokTrajanja], [Kolicina], [ZemljaPorekla], [Cena]) VALUES (13, N'Brufen', CAST(N'2026-11-05' AS Date), 100, 0, 400)
INSERT [dbo].[Lek] ([Id], [Naziv], [RokTrajanja], [Kolicina], [ZemljaPorekla], [Cena]) VALUES (3004, N'Presing', CAST(N'2026-08-28' AS Date), 12, 1, 233.54)
SET IDENTITY_INSERT [dbo].[Lek] OFF
GO
SET IDENTITY_INSERT [dbo].[Lokacija] ON 

INSERT [dbo].[Lokacija] ([Id], [AdresaLokacije], [Opstina]) VALUES (1, N'jove ilica 82', N'vozdovac')
INSERT [dbo].[Lokacija] ([Id], [AdresaLokacije], [Opstina]) VALUES (2, N'Maksima Gorkog 46', N'Vozdovac')
INSERT [dbo].[Lokacija] ([Id], [AdresaLokacije], [Opstina]) VALUES (3, N'Bulevar Kralja Aleksandra 356', N'Zvezdara')
INSERT [dbo].[Lokacija] ([Id], [AdresaLokacije], [Opstina]) VALUES (4, N'francuska 23', N'Dorcol')
SET IDENTITY_INSERT [dbo].[Lokacija] OFF
GO
SET IDENTITY_INSERT [dbo].[PromoKod] ON 

INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (2, 25, CAST(N'2030-06-25' AS Date))
INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (1002, 15, CAST(N'2030-06-25' AS Date))
INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (1036, 0, CAST(N'2025-06-04' AS Date))
INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (1037, 0, CAST(N'2025-06-04' AS Date))
INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (1046, 0, CAST(N'2025-06-04' AS Date))
INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (2004, 0, CAST(N'2025-06-04' AS Date))
INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (2005, 0, CAST(N'2025-06-04' AS Date))
INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (2011, 0, CAST(N'2025-06-04' AS Date))
INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (2017, 0, CAST(N'2025-06-04' AS Date))
INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (4004, 0, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (5004, 0, CAST(N'2025-06-07' AS Date))
INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (7004, 0, CAST(N'2025-07-02' AS Date))
INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (7005, 0, CAST(N'2025-07-02' AS Date))
INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (7009, 0, CAST(N'2025-07-02' AS Date))
INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (7010, 0, CAST(N'2025-07-02' AS Date))
INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (9003, 0, CAST(N'2025-07-07' AS Date))
INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (9004, 0, CAST(N'2025-07-07' AS Date))
INSERT [dbo].[PromoKod] ([Id], [IznosPopusta], [DatumNastanka]) VALUES (10003, 0, CAST(N'2025-07-11' AS Date))
SET IDENTITY_INSERT [dbo].[PromoKod] OFF
GO
SET IDENTITY_INSERT [dbo].[Racun] ON 

INSERT [dbo].[Racun] ([Id], [UkupnaVrednost], [IznosPoreza], [UkupnaVrednostSaPorezom], [DatumIzdavanja], [IdFarmaceut], [IdKorisnik]) VALUES (2, 2500, 7, 2675, CAST(N'2025-06-06' AS Date), 1, 1003)
INSERT [dbo].[Racun] ([Id], [UkupnaVrednost], [IznosPoreza], [UkupnaVrednostSaPorezom], [DatumIzdavanja], [IdFarmaceut], [IdKorisnik]) VALUES (4, 4000, 10, 4400, CAST(N'2025-05-05' AS Date), 1, 1003)
INSERT [dbo].[Racun] ([Id], [UkupnaVrednost], [IznosPoreza], [UkupnaVrednostSaPorezom], [DatumIzdavanja], [IdFarmaceut], [IdKorisnik]) VALUES (5, 2000, 6, 2120, CAST(N'2025-02-02' AS Date), 3, 3)
INSERT [dbo].[Racun] ([Id], [UkupnaVrednost], [IznosPoreza], [UkupnaVrednostSaPorezom], [DatumIzdavanja], [IdFarmaceut], [IdKorisnik]) VALUES (7, 1000, 15, 1150, CAST(N'2025-03-03' AS Date), 2, 3004)
INSERT [dbo].[Racun] ([Id], [UkupnaVrednost], [IznosPoreza], [UkupnaVrednostSaPorezom], [DatumIzdavanja], [IdFarmaceut], [IdKorisnik]) VALUES (13, 6000, 6, 6360, CAST(N'2025-06-06' AS Date), 3, 3016)
INSERT [dbo].[Racun] ([Id], [UkupnaVrednost], [IznosPoreza], [UkupnaVrednostSaPorezom], [DatumIzdavanja], [IdFarmaceut], [IdKorisnik]) VALUES (1003, 5300, 3, 5459, CAST(N'2025-06-06' AS Date), 3, 1003)
INSERT [dbo].[Racun] ([Id], [UkupnaVrednost], [IznosPoreza], [UkupnaVrednostSaPorezom], [DatumIzdavanja], [IdFarmaceut], [IdKorisnik]) VALUES (3003, 5234.52, 7, 5600.9364000000005, CAST(N'2025-07-02' AS Date), 3, 2042)
INSERT [dbo].[Racun] ([Id], [UkupnaVrednost], [IznosPoreza], [UkupnaVrednostSaPorezom], [DatumIzdavanja], [IdFarmaceut], [IdKorisnik]) VALUES (4022, 2650, 5, 2782.5, CAST(N'2025-07-07' AS Date), 3, 1003)
INSERT [dbo].[Racun] ([Id], [UkupnaVrednost], [IznosPoreza], [UkupnaVrednostSaPorezom], [DatumIzdavanja], [IdFarmaceut], [IdKorisnik]) VALUES (4027, 899.97, 7, 962.9679, CAST(N'2025-07-07' AS Date), 3, 3016)
INSERT [dbo].[Racun] ([Id], [UkupnaVrednost], [IznosPoreza], [UkupnaVrednostSaPorezom], [DatumIzdavanja], [IdFarmaceut], [IdKorisnik]) VALUES (5018, 1350, 5, 1417.5, CAST(N'2025-07-10' AS Date), 1, 3004)
INSERT [dbo].[Racun] ([Id], [UkupnaVrednost], [IznosPoreza], [UkupnaVrednostSaPorezom], [DatumIzdavanja], [IdFarmaceut], [IdKorisnik]) VALUES (6015, 6250, 5, 6562.5, CAST(N'2025-07-11' AS Date), 1, 8008)
SET IDENTITY_INSERT [dbo].[Racun] OFF
GO
INSERT [dbo].[StavkaRacuna] ([IdRacun], [RbStavke], [Kolicina], [ProdajnaVrednost], [IdLek]) VALUES (4022, 1, 2, 1300, 5)
INSERT [dbo].[StavkaRacuna] ([IdRacun], [RbStavke], [Kolicina], [ProdajnaVrednost], [IdLek]) VALUES (4022, 2, 3, 1350, 2)
INSERT [dbo].[StavkaRacuna] ([IdRacun], [RbStavke], [Kolicina], [ProdajnaVrednost], [IdLek]) VALUES (4027, 1, 3, 899.97, 7)
INSERT [dbo].[StavkaRacuna] ([IdRacun], [RbStavke], [Kolicina], [ProdajnaVrednost], [IdLek]) VALUES (5018, 2, 3, 1350, 2)
INSERT [dbo].[StavkaRacuna] ([IdRacun], [RbStavke], [Kolicina], [ProdajnaVrednost], [IdLek]) VALUES (6015, 1, 5, 3250, 5)
INSERT [dbo].[StavkaRacuna] ([IdRacun], [RbStavke], [Kolicina], [ProdajnaVrednost], [IdLek]) VALUES (6015, 2, 4, 1800, 2)
INSERT [dbo].[StavkaRacuna] ([IdRacun], [RbStavke], [Kolicina], [ProdajnaVrednost], [IdLek]) VALUES (6015, 3, 3, 1200, 13)
GO
ALTER TABLE [dbo].[FarmaceutLokacija]  WITH CHECK ADD  CONSTRAINT [FK_FarmaceutLokacija_Farmaceut] FOREIGN KEY([IdFarmaceut])
REFERENCES [dbo].[Farmaceut] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[FarmaceutLokacija] CHECK CONSTRAINT [FK_FarmaceutLokacija_Farmaceut]
GO
ALTER TABLE [dbo].[FarmaceutLokacija]  WITH CHECK ADD  CONSTRAINT [FK_FarmaceutLokacija_Lokacija] FOREIGN KEY([IdLokacija])
REFERENCES [dbo].[Lokacija] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[FarmaceutLokacija] CHECK CONSTRAINT [FK_FarmaceutLokacija_Lokacija]
GO
ALTER TABLE [dbo].[Korisnik]  WITH CHECK ADD  CONSTRAINT [FK_Korisnik_PromoKod] FOREIGN KEY([IdPromoKod])
REFERENCES [dbo].[PromoKod] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Korisnik] CHECK CONSTRAINT [FK_Korisnik_PromoKod]
GO
ALTER TABLE [dbo].[StavkaRacuna]  WITH CHECK ADD  CONSTRAINT [FK_StavkaRacuna_Lek] FOREIGN KEY([IdLek])
REFERENCES [dbo].[Lek] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StavkaRacuna] CHECK CONSTRAINT [FK_StavkaRacuna_Lek]
GO
ALTER TABLE [dbo].[StavkaRacuna]  WITH CHECK ADD  CONSTRAINT [FK_StavkaRacuna_Racun] FOREIGN KEY([IdRacun])
REFERENCES [dbo].[Racun] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StavkaRacuna] CHECK CONSTRAINT [FK_StavkaRacuna_Racun]
GO
USE [master]
GO
ALTER DATABASE [PharmacyApp] SET  READ_WRITE 
GO
