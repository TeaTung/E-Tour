USE [ETOUR]
GO
/****** Object:  Table [dbo].[CUSTOMER]    Script Date: 5/2/2021 1:31:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[PhoneNumber] [int] NULL,
	[Address] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[CitizenID/Passport] [int] NULL,
	[Expiration] [smalldatetime] NULL,
	[Gender] [char](10) NULL,
	[Account] [nchar](20) NULL,
	[Password] [nchar](20) NULL,
 CONSTRAINT [PK_CUSTOMER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DASHBOARD]    Script Date: 5/2/2021 1:31:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DASHBOARD](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BookTime] [smalldatetime] NULL,
	[IDCustomer] [int] NULL,
	[IDTour] [int] NULL,
	[IsPaid] [nvarchar](50) NULL,
	[ReturnedMoney] [money] NULL,
	[NumberOfTicket] [int] NULL,
 CONSTRAINT [PK_DASHBOARD] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STAFF]    Script Date: 5/2/2021 1:31:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STAFF](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Adress] [nvarchar](50) NULL,
	[PhoneNumber] [int] NULL,
	[Gender] [nchar](10) NULL,
 CONSTRAINT [PK_STAFF] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TICKET]    Script Date: 5/2/2021 1:31:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TICKET](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TourID] [int] NOT NULL,
	[Price] [money] NULL,
	[Number] [int] NULL,
	[Sale] [bit] NULL,
 CONSTRAINT [PK_TICKET] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TOUR]    Script Date: 5/2/2021 1:31:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOUR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StartPoint] [nvarchar](50) NULL,
	[Destination] [nvarchar](50) NULL,
	[TourType] [nvarchar](50) NULL,
	[TimeConsumed] [time](7) NULL,
	[StartDay] [smalldatetime] NULL,
	[TourDetail] [nvarchar](50) NULL,
 CONSTRAINT [PK_TOUR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DASHBOARD]  WITH CHECK ADD  CONSTRAINT [FK_DASHBOARD_CUSTOMER] FOREIGN KEY([IDCustomer])
REFERENCES [dbo].[CUSTOMER] ([ID])
GO
ALTER TABLE [dbo].[DASHBOARD] CHECK CONSTRAINT [FK_DASHBOARD_CUSTOMER]
GO
ALTER TABLE [dbo].[DASHBOARD]  WITH CHECK ADD  CONSTRAINT [FK_DASHBOARD_TOUR] FOREIGN KEY([IDTour])
REFERENCES [dbo].[TOUR] ([ID])
GO
ALTER TABLE [dbo].[DASHBOARD] CHECK CONSTRAINT [FK_DASHBOARD_TOUR]
GO
ALTER TABLE [dbo].[TICKET]  WITH CHECK ADD  CONSTRAINT [FK_TICKET_TOUR] FOREIGN KEY([TourID])
REFERENCES [dbo].[TOUR] ([ID])
GO
ALTER TABLE [dbo].[TICKET] CHECK CONSTRAINT [FK_TICKET_TOUR]
GO
ALTER TABLE [dbo].[CUSTOMER]  WITH CHECK ADD  CONSTRAINT [CHECK_GENDER] CHECK  (([GENDER]='Male' OR [GENDER]='Felmale'))
GO
ALTER TABLE [dbo].[CUSTOMER] CHECK CONSTRAINT [CHECK_GENDER]
GO
