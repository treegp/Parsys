CREATE TABLE [ShopDb].[dbo][Corporations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Address] [nvarchar](1000) NULL,
	[Telephone] [nvarchar](21) NULL,
	[Fax] [nvarchar](21) NULL,
	[Description] [nvarchar](1000) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteByUserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [ShopDb].[dbo][FinancialYears]    Script Date: 20/07/2022 3:55:19 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [ShopDb].[dbo][FinancialYears](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CorporationId] [int] NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[StartDate] [datetime] NOT NULL,
	[FinishDate] [datetime] NOT NULL,
	[IsClosed] [bit] NOT NULL,
	[CloseDate] [datetime] NULL,
	[ClosedByUserId] [int] NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteByUserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [ShopDb].[dbo][Inventories]    Script Date: 20/07/2022 3:55:19 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [ShopDb].[dbo][Inventories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CorporationId] [int] NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteByUserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [ShopDb].[dbo][InventoryInsDetails]    Script Date: 20/07/2022 3:55:19 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [ShopDb].[dbo][InventoryInsDetails](
	[InventoryInsHeaderId] [bigint] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[TotalPrice] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC,
	[InventoryInsHeaderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [ShopDb].[dbo][InventoryInsHeaders]    Script Date: 20/07/2022 3:55:19 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [ShopDb].[dbo][InventoryInsHeaders](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[InventoryId] [int] NOT NULL,
	[TypeId] [int] NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[Date] [datetime] NOT NULL,
	[Accepted] [bit] NOT NULL,
	[AcceptDate] [datetime] NULL,
	[AcceptedByUserId] [int] NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteByUserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [ShopDb].[dbo][InventoryInsType]    Script Date: 20/07/2022 3:55:19 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [ShopDb].[dbo][InventoryInsType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteByUserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [ShopDb].[dbo][InventoryOutsDetails]    Script Date: 20/07/2022 3:55:19 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [ShopDb].[dbo][InventoryOutsDetails](
	[InventoryOutsHeaderId] [bigint] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[TotalPrice] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC,
	[InventoryOutsHeaderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [ShopDb].[dbo][InventoryOutsHeaders]    Script Date: 20/07/2022 3:55:19 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [ShopDb].[dbo][InventoryOutsHeaders](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[InventoryId] [int] NOT NULL,
	[TypeId] [int] NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[Date] [datetime] NOT NULL,
	[Accepted] [bit] NOT NULL,
	[AcceptDate] [datetime] NULL,
	[AcceptedByUserId] [int] NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteByUserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [ShopDb].[dbo][InventoryOutsType]    Script Date: 20/07/2022 3:55:19 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [ShopDb].[dbo][InventoryOutsType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteByUserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [ShopDb].[dbo][ProductCateries]    Script Date: 20/07/2022 3:55:19 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [ShopDb].[dbo][ProductCateries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InventoryId] [int] NOT NULL,
	[ParentCateryId] [int] NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteByUserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [ShopDb].[dbo][ProductParameters]    Script Date: 20/07/2022 3:55:19 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [ShopDb].[dbo][ProductParameters](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductCateryId] [int] NOT NULL,
	[Key] [varchar](100) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[Data] [nvarchar](max) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteByUserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

/****** Object:  Table [ShopDb].[dbo][ProductParameterValues]    Script Date: 20/07/2022 3:55:19 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [ShopDb].[dbo][ProductParameterValues](
	[ProductId] [int] NOT NULL,
	[ProductParameterId] [int] NOT NULL,
	[Value] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC,
	[ProductParameterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

/****** Object:  Table [ShopDb].[dbo][ProductPrices]    Script Date: 20/07/2022 3:55:19 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [ShopDb].[dbo][ProductPrices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [ShopDb].[dbo][Products]    Script Date: 20/07/2022 3:55:19 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [ShopDb].[dbo][Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductCateryId] [int] NOT NULL,
	[ProductUnitId] [int] NULL,
	[Code] [varchar](10) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteByUserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [ShopDb].[dbo][ProductUnits]    Script Date: 20/07/2022 3:55:19 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [ShopDb].[dbo][ProductUnits](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteByUserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [ShopDb].[dbo][Users]    Script Date: 20/07/2022 3:55:19 PM ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [ShopDb].[dbo][Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](200) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeleteDate] [datetime] NULL,
	[DeleteByUserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [ShopDb].[dbo][Corporations] ADD  DEFAULT (getdate()) FOR [DeleteDate]

ALTER TABLE [ShopDb].[dbo][FinancialYears] ADD  DEFAULT (getdate()) FOR [DeleteDate]

ALTER TABLE [ShopDb].[dbo][Inventories] ADD  DEFAULT (getdate()) FOR [DeleteDate]

ALTER TABLE [ShopDb].[dbo][InventoryInsHeaders] ADD  DEFAULT (getdate()) FOR [DeleteDate]

ALTER TABLE [ShopDb].[dbo][InventoryInsType] ADD  DEFAULT (getdate()) FOR [DeleteDate]

ALTER TABLE [ShopDb].[dbo][InventoryOutsHeaders] ADD  DEFAULT (getdate()) FOR [DeleteDate]

ALTER TABLE [ShopDb].[dbo][InventoryOutsType] ADD  DEFAULT (getdate()) FOR [DeleteDate]

ALTER TABLE [ShopDb].[dbo][ProductCateries] ADD  DEFAULT (getdate()) FOR [DeleteDate]

ALTER TABLE [ShopDb].[dbo][ProductParameters] ADD  DEFAULT (getdate()) FOR [DeleteDate]

ALTER TABLE [ShopDb].[dbo][ProductPrices] ADD  DEFAULT (getdate()) FOR [Date]

ALTER TABLE [ShopDb].[dbo][Products] ADD  DEFAULT (getdate()) FOR [DeleteDate]

ALTER TABLE [ShopDb].[dbo][ProductUnits] ADD  DEFAULT (getdate()) FOR [DeleteDate]

ALTER TABLE [ShopDb].[dbo][Users] ADD  DEFAULT (getdate()) FOR [DeleteDate]

ALTER TABLE [ShopDb].[dbo][Corporations]  WITH CHECK ADD FOREIGN KEY([DeleteByUserId])
REFERENCES [ShopDb].[dbo][Users] ([Id])

ALTER TABLE [ShopDb].[dbo][FinancialYears]  WITH CHECK ADD FOREIGN KEY([ClosedByUserId])
REFERENCES [ShopDb].[dbo][Users] ([Id])

ALTER TABLE [ShopDb].[dbo][FinancialYears]  WITH CHECK ADD FOREIGN KEY([CorporationId])
REFERENCES [ShopDb].[dbo][Corporations] ([Id])

ALTER TABLE [ShopDb].[dbo][FinancialYears]  WITH CHECK ADD FOREIGN KEY([DeleteByUserId])
REFERENCES [ShopDb].[dbo][Users] ([Id])

ALTER TABLE [ShopDb].[dbo][Inventories]  WITH CHECK ADD FOREIGN KEY([CorporationId])
REFERENCES [ShopDb].[dbo][Corporations] ([Id])

ALTER TABLE [ShopDb].[dbo][Inventories]  WITH CHECK ADD FOREIGN KEY([DeleteByUserId])
REFERENCES [ShopDb].[dbo][Users] ([Id])

ALTER TABLE [ShopDb].[dbo][InventoryInsDetails]  WITH CHECK ADD FOREIGN KEY([InventoryInsHeaderId])
REFERENCES [ShopDb].[dbo][InventoryInsHeaders] ([Id])

ALTER TABLE [ShopDb].[dbo][InventoryInsDetails]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [ShopDb].[dbo][Products] ([Id])

ALTER TABLE [ShopDb].[dbo][InventoryInsHeaders]  WITH CHECK ADD FOREIGN KEY([AcceptedByUserId])
REFERENCES [ShopDb].[dbo][Users] ([Id])

ALTER TABLE [ShopDb].[dbo][InventoryInsHeaders]  WITH CHECK ADD FOREIGN KEY([DeleteByUserId])
REFERENCES [ShopDb].[dbo][Users] ([Id])

ALTER TABLE [ShopDb].[dbo][InventoryInsHeaders]  WITH CHECK ADD FOREIGN KEY([InventoryId])
REFERENCES [ShopDb].[dbo][Inventories] ([Id])

ALTER TABLE [ShopDb].[dbo][InventoryInsHeaders]  WITH CHECK ADD FOREIGN KEY([TypeId])
REFERENCES [ShopDb].[dbo][InventoryInsType] ([Id])

ALTER TABLE [ShopDb].[dbo][InventoryInsType]  WITH CHECK ADD FOREIGN KEY([DeleteByUserId])
REFERENCES [ShopDb].[dbo][Users] ([Id])

ALTER TABLE [ShopDb].[dbo][InventoryOutsDetails]  WITH CHECK ADD FOREIGN KEY([InventoryOutsHeaderId])
REFERENCES [ShopDb].[dbo][InventoryOutsHeaders] ([Id])

ALTER TABLE [ShopDb].[dbo][InventoryOutsDetails]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [ShopDb].[dbo][Products] ([Id])

ALTER TABLE [ShopDb].[dbo][InventoryOutsHeaders]  WITH CHECK ADD FOREIGN KEY([AcceptedByUserId])
REFERENCES [ShopDb].[dbo][Users] ([Id])

ALTER TABLE [ShopDb].[dbo][InventoryOutsHeaders]  WITH CHECK ADD FOREIGN KEY([DeleteByUserId])
REFERENCES [ShopDb].[dbo][Users] ([Id])

ALTER TABLE [ShopDb].[dbo][InventoryOutsHeaders]  WITH CHECK ADD FOREIGN KEY([InventoryId])
REFERENCES [ShopDb].[dbo][Inventories] ([Id])

ALTER TABLE [ShopDb].[dbo][InventoryOutsHeaders]  WITH CHECK ADD FOREIGN KEY([TypeId])
REFERENCES [ShopDb].[dbo][InventoryOutsType] ([Id])

ALTER TABLE [ShopDb].[dbo][InventoryOutsType]  WITH CHECK ADD FOREIGN KEY([DeleteByUserId])
REFERENCES [ShopDb].[dbo][Users] ([Id])

ALTER TABLE [ShopDb].[dbo][ProductCateries]  WITH CHECK ADD FOREIGN KEY([DeleteByUserId])
REFERENCES [ShopDb].[dbo][Users] ([Id])

ALTER TABLE [ShopDb].[dbo][ProductCateries]  WITH CHECK ADD FOREIGN KEY([InventoryId])
REFERENCES [ShopDb].[dbo][Inventories] ([Id])

ALTER TABLE [ShopDb].[dbo][ProductCateries]  WITH CHECK ADD FOREIGN KEY([ParentCateryId])
REFERENCES [ShopDb].[dbo][ProductCateries] ([Id])

ALTER TABLE [ShopDb].[dbo][ProductParameters]  WITH CHECK ADD FOREIGN KEY([DeleteByUserId])
REFERENCES [ShopDb].[dbo][Users] ([Id])

ALTER TABLE [ShopDb].[dbo][ProductParameters]  WITH CHECK ADD FOREIGN KEY([ProductCateryId])
REFERENCES [ShopDb].[dbo][ProductCateries] ([Id])

ALTER TABLE [ShopDb].[dbo][ProductParameterValues]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [ShopDb].[dbo][Products] ([Id])

ALTER TABLE [ShopDb].[dbo][ProductParameterValues]  WITH CHECK ADD FOREIGN KEY([ProductParameterId])
REFERENCES [ShopDb].[dbo][ProductParameters] ([Id])

ALTER TABLE [ShopDb].[dbo][ProductPrices]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [ShopDb].[dbo][Products] ([Id])

ALTER TABLE [ShopDb].[dbo][Products]  WITH CHECK ADD FOREIGN KEY([DeleteByUserId])
REFERENCES [ShopDb].[dbo][Users] ([Id])

ALTER TABLE [ShopDb].[dbo][Products]  WITH CHECK ADD FOREIGN KEY([ProductCateryId])
REFERENCES [ShopDb].[dbo][ProductCateries] ([Id])

ALTER TABLE [ShopDb].[dbo][Products]  WITH CHECK ADD FOREIGN KEY([ProductUnitId])
REFERENCES [ShopDb].[dbo][ProductUnits] ([Id])

ALTER TABLE [ShopDb].[dbo][ProductUnits]  WITH CHECK ADD FOREIGN KEY([DeleteByUserId])
REFERENCES [ShopDb].[dbo][Users] ([Id])

ALTER TABLE [ShopDb].[dbo][Users]  WITH CHECK ADD FOREIGN KEY([DeleteByUserId])
REFERENCES [ShopDb].[dbo][Users] ([Id])

