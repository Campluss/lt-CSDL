
USE [master]
GO

CREATE DATABASE [PNPdata]
Go
use [PNPdata]
GO
ALTER DATABASE [PNPdata] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PNPdata] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PNPdata] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PNPdata] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PNPdata] SET ARITHABORT OFF 
GO
ALTER DATABASE [PNPdata] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PNPdata] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PNPdata] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PNPdata] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PNPdata] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PNPdata] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PNPdata] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PNPdata] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PNPdata] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PNPdata] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PNPdata] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PNPdata] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PNPdata] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PNPdata] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PNPdata] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PNPdata] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PNPdata] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PNPdata] SET RECOVERY FULL 
GO
ALTER DATABASE [PNPdata] SET  MULTI_USER 
GO
ALTER DATABASE [PNPdata] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PNPdata] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PNPdata] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PNPdata] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PNPdata] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PNPdata', N'ON'
GO
ALTER DATABASE [PNPdata] SET QUERY_STORE = OFF
GO
USE [PNPdata]
GO
/****** Object:  Table [dbo].[tbBill*]    Script Date: 11/10/2020 5:02:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbBill*](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[StaffID] [int] NULL,
	[DOS] [datetime] NULL,
	[Total] [float] NULL,
	[CustomerCode] [nvarchar](20) NULL,
	[StaffCode] [nvarchar](20) NULL,
 CONSTRAINT [PK_tbBill] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbBillDetails*]    Script Date: 11/10/2020 5:02:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbBillDetails*](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[ProductName] [nvarchar](50) NULL,
	[ProductCode] [nvarchar](20) NULL,
	[BillID] [int] NULL,
	[BillCode] [nvarchar](20) NULL,
	[Amount] [int] NULL,
	[UnitPrice] [float] NULL,
	[Discount] [float] NULL,
	[IntoMoney] [float] NULL,
 CONSTRAINT [PK_tbBillDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCustomer*]    Script Date: 11/10/2020 5:02:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCustomer*](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerCode] [nvarchar](20) NULL,
	[Name] [nvarchar](50) NULL,
	[Age] [datetime] NULL,
	[Gender] [nvarchar](10) NULL,
	[PhoneNumber] [nvarchar](12) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbCustomer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbLogin](
	[ID] [int] NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbLogin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON

GO
CREATE TABLE [dbo].[tbProduct*](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductCode] [nvarchar](20) NULL,
	[ProductName] [nvarchar](50) NULL,
	[Size] [nvarchar](5) NULL,
	[Corlor] [nvarchar](10) NULL,
	[Amount] [int] NULL,
	[ProductType] [nvarchar](10) NULL,
	[Price] [float] NULL,
 CONSTRAINT [PK_tbProduct] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[tbSalary*]    Script Date: 11/10/2020 5:02:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbSalary*](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StaffID] [int] NULL,
	[StaffCode] [nvarchar](20) NULL,
	[StaffName] [nvarchar](20) NULL,
	[Hours work] [int] NULL,
	[Bonus] [float] NULL,
	[Total Salary] [float] NULL,
 CONSTRAINT [PK_tbSalary] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbStaff*]    Script Date: 11/10/2020 5:02:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbStaff*](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StaffCode] [nvarchar](20) NULL,
	[Name] [nvarchar](50) NULL,
	[Age] [datetime] NULL,
	[Gender] [nvarchar](10) NULL,
	[PhoneNumber] [nvarchar](12) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbStaff] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbStatistic*]    Script Date: 11/10/2020 5:02:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbStatistic*](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Total amount of bill] [int] NULL,
	[[Total salary of Staff] [float] NULL,
	[Revuene] [float] NULL,
	[Profit] [float] NULL,
	[BillIDDetails] [int] NULL,
	[SalaryID] [int] NULL,
	[ProductID] [int] NULL,
 CONSTRAINT [PK_tbStatistic] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbWarehouse*]    Script Date: 11/10/2020 5:02:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbWarehouse*](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[ProductName] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[ProductCode] [nvarchar](20) NULL,
 CONSTRAINT [PK_tbWarehouse] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbBill*]  WITH CHECK ADD  CONSTRAINT [FK_tbBill_tbCustomer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tbCustomer*] ([ID])
GO
ALTER TABLE [dbo].[tbBill*] CHECK CONSTRAINT [FK_tbBill_tbCustomer]
GO
ALTER TABLE [dbo].[tbBill*]  WITH CHECK ADD  CONSTRAINT [FK_tbBill_tbStaff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[tbStaff*] ([ID])
GO
ALTER TABLE [dbo].[tbBill*] CHECK CONSTRAINT [FK_tbBill_tbStaff]
GO
ALTER TABLE [dbo].[tbBillDetails*]  WITH CHECK ADD  CONSTRAINT [FK_tbBillDetails*_tbBill*] FOREIGN KEY([BillID])
REFERENCES [dbo].[tbBill*] ([ID])
GO
ALTER TABLE [dbo].[tbBillDetails*] CHECK CONSTRAINT [FK_tbBillDetails*_tbBill*]
GO
ALTER TABLE [dbo].[tbBillDetails*]  WITH CHECK ADD  CONSTRAINT [FK_tbBillDetails_tbProduct] FOREIGN KEY([ProductID])
REFERENCES [dbo].[tbProduct*] ([ID])
GO
ALTER TABLE [dbo].[tbBillDetails*] CHECK CONSTRAINT [FK_tbBillDetails_tbProduct]
GO
ALTER TABLE [dbo].[tbSalary*]  WITH CHECK ADD  CONSTRAINT [FK_tbSalary_tbStaff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[tbStaff*] ([ID])
GO
ALTER TABLE [dbo].[tbSalary*] CHECK CONSTRAINT [FK_tbSalary_tbStaff]
GO
ALTER TABLE [dbo].[tbStatistic*]  WITH CHECK ADD  CONSTRAINT [FK_tbStatistic_tbBillDetails] FOREIGN KEY([BillIDDetails])
REFERENCES [dbo].[tbBillDetails*] ([ID])
GO
ALTER TABLE [dbo].[tbStatistic*] CHECK CONSTRAINT [FK_tbStatistic_tbBillDetails]
GO
ALTER TABLE [dbo].[tbStatistic*]  WITH CHECK ADD  CONSTRAINT [FK_tbStatistic_tbProduct] FOREIGN KEY([ProductID])
REFERENCES [dbo].[tbProduct*] ([ID])
GO
ALTER TABLE [dbo].[tbStatistic*] CHECK CONSTRAINT [FK_tbStatistic_tbProduct]
GO
ALTER TABLE [dbo].[tbStatistic*]  WITH CHECK ADD  CONSTRAINT [FK_tbStatistic_tbSalary] FOREIGN KEY([SalaryID])
REFERENCES [dbo].[tbSalary*] ([ID])
GO
ALTER TABLE [dbo].[tbStatistic*] CHECK CONSTRAINT [FK_tbStatistic_tbSalary]
GO
ALTER TABLE [dbo].[tbWarehouse*]  WITH CHECK ADD  CONSTRAINT [FK_tbWarehouse_tbProduct] FOREIGN KEY([ProductID])
REFERENCES [dbo].[tbProduct*] ([ID])
GO
ALTER TABLE [dbo].[tbWarehouse*] CHECK CONSTRAINT [FK_tbWarehouse_tbProduct]
GO
USE [master]
GO
ALTER DATABASE [PNPdata] SET  READ_WRITE 
GO


SELECT 
    *
FROM
    PNPdata.dbo.tbLogin;

	
SELECT 
    *
FROM
    PNPdata.dbo.[tbStaff*];


INSERT INTO PNPdata.dbo.tbLogin
(Username, Password, ID)
VALUES
('admin', 'admin',3);


SET IDENTITY_INSERT PNPdata.dbo.[tbCustomer*] OFF
INSERT INTO PNPdata.dbo.[tbCustomer*]
(ID, CustomerCode, Name, Age, Gender, PhoneNumber, Address)
VALUES
(2, 2,'Nguyễn Văn B', 20, 'Nam', 0123456789, '150 Hoàng Văn Việt');



SET IDENTITY_INSERT PNPdata.dbo.[tbStaff*] ON

INSERT INTO PNPdata.dbo.[tbStaff*]
(ID, StaffCode, Name, Age, Gender, PhoneNumber, Address)
VALUES
(1, 1,'Nguyễn Thị A', 20, 'Nữ', 0123456789, '69 Hoàng Văn Việt');

