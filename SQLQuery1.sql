﻿Databases  RentACar

CREATE TABLE [dbo].[Cars] (
    [CarId]       INT           IDENTITY (1, 1) NOT NULL,
    [BrandId]     INT           NOT NULL,
    [ColorId]     INT           NOT NULL,
    [ModelYear]   NVARCHAR (50) NULL,
    [DailyPrice]  DECIMAL (8)   NULL,
    [Description] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([CarId] ASC),
    CONSTRAINT [FK_BrandId] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([BrandId]),
    CONSTRAINT [FK_ColorId] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Colors] ([ColorId])
);


CREATE TABLE [dbo].[Brands] (
    [BrandId]   INT           IDENTITY (1, 1) NOT NULL,
    [BrandName] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([BrandId] ASC)
);

CREATE TABLE [dbo].[Colors] (
    [ColorId]   INT           IDENTITY (1, 1) NOT NULL,
    [ColorName] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([ColorId] ASC)
);

Cars Table View Data

1	1	1	2020	250	E-Serisi Coupe
2	1	2	2019	449	CLA Shooting Brake
3	2	3	2012	200	458 Spider
4	3	4	2020	175	Sienna IV 2.5
5	4	5	2021	300	Arteon
6	5	6	1970	100	
7	6	7	2009	130	Flex


Brands Table View Data

1	Mercedes-Benz
2	Ferrari
3	Toyota
4	Volkswagen
5	Renault
6	Opel
7	Ford


Colors Table View Data


1	Siyah
2	Sarı
3	Kırmızı
4	Beyaz
5	Mavi
6	Turuncu
7	Gri