USE [GYM]
GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 8/31/2018 3:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cargo](
	[IDCargo] [int] IDENTITY(1,1) NOT NULL,
	[NombreCargo] [varchar](20) NULL,
 CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED 
(
	[IDCargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Login]    Script Date: 8/31/2018 3:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Login](
	[IDLogin] [int] IDENTITY(1,1) NOT NULL,
	[IDUsuario] [int] NULL,
	[UserName] [varchar](50) NULL,
	[Pwd] [varchar](100) NULL,
	[Cargo] [int] NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[IDLogin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Membrecia]    Script Date: 8/31/2018 3:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Membrecia](
	[IDMembrecia] [int] IDENTITY(1,1) NOT NULL,
	[NombreMembrecia] [varchar](50) NULL,
	[Duracion] [int] NULL,
	[IDTipo] [int] NULL,
	[Precio] [money] NULL,
 CONSTRAINT [PK_Membrecia] PRIMARY KEY CLUSTERED 
(
	[IDMembrecia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Provedor]    Script Date: 8/31/2018 3:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provedor](
	[IDProvedor] [int] IDENTITY(1,1) NOT NULL,
	[NombreProvedor] [varchar](50) NULL,
 CONSTRAINT [PK_Provedor] PRIMARY KEY CLUSTERED 
(
	[IDProvedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Recibo]    Script Date: 8/31/2018 3:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recibo](
	[IDRecibo] [int] IDENTITY(1,1) NOT NULL,
	[IDEmpleado] [int] NULL,
	[IDCliente] [int] NULL,
	[Pago] [int] NULL,
	[Fecha] [date] NULL,
 CONSTRAINT [PK_Recibo] PRIMARY KEY CLUSTERED 
(
	[IDRecibo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Registros]    Script Date: 8/31/2018 3:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registros](
	[IDRegistro] [int] IDENTITY(1,1) NOT NULL,
	[IDMembrecia] [int] NULL,
	[Entrada] [date] NULL,
	[Salida] [date] NULL,
 CONSTRAINT [PK_Registros] PRIMARY KEY CLUSTERED 
(
	[IDRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Suscripciones]    Script Date: 8/31/2018 3:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suscripciones](
	[IDSuscripcion] [int] IDENTITY(1,1) NOT NULL,
	[IDCliente] [int] NULL,
	[IDMembrecia] [int] NULL,
	[FechaInicio] [date] NULL,
	[FechaFin] [date] NULL,
 CONSTRAINT [PK_Suscripciones] PRIMARY KEY CLUSTERED 
(
	[IDSuscripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tipo]    Script Date: 8/31/2018 3:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tipo](
	[IDTipo] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](20) NULL,
 CONSTRAINT [PK_Tipo] PRIMARY KEY CLUSTERED 
(
	[IDTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 8/31/2018 3:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[IDUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[ApellidoP] [varchar](50) NOT NULL,
	[ApellidoM] [varchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Cargo] ON 

INSERT [dbo].[Cargo] ([IDCargo], [NombreCargo]) VALUES (1, N'Administrador')
INSERT [dbo].[Cargo] ([IDCargo], [NombreCargo]) VALUES (2, N'Cajero')
SET IDENTITY_INSERT [dbo].[Cargo] OFF
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([IDLogin], [IDUsuario], [UserName], [Pwd], [Cargo]) VALUES (1, 1, N'Admin', N'MTIzNDU2', 1)
INSERT [dbo].[Login] ([IDLogin], [IDUsuario], [UserName], [Pwd], [Cargo]) VALUES (5, 4, N'Tunki', N'MTIzNDU2Nzg5', 2)
SET IDENTITY_INSERT [dbo].[Login] OFF
SET IDENTITY_INSERT [dbo].[Membrecia] ON 

INSERT [dbo].[Membrecia] ([IDMembrecia], [NombreMembrecia], [Duracion], [IDTipo], [Precio]) VALUES (1, N'XCale', 1, 1, 50.0000)
INSERT [dbo].[Membrecia] ([IDMembrecia], [NombreMembrecia], [Duracion], [IDTipo], [Precio]) VALUES (2, N'XRegular', 1, 2, 120.0000)
INSERT [dbo].[Membrecia] ([IDMembrecia], [NombreMembrecia], [Duracion], [IDTipo], [Precio]) VALUES (3, N'XTreme', 1, 3, 1200.0000)
INSERT [dbo].[Membrecia] ([IDMembrecia], [NombreMembrecia], [Duracion], [IDTipo], [Precio]) VALUES (4, N'XXTreme', 2, 3, 2000.0000)
SET IDENTITY_INSERT [dbo].[Membrecia] OFF
SET IDENTITY_INSERT [dbo].[Suscripciones] ON 

INSERT [dbo].[Suscripciones] ([IDSuscripcion], [IDCliente], [IDMembrecia], [FechaInicio], [FechaFin]) VALUES (1, 3, 2, CAST(N'2018-08-31' AS Date), CAST(N'2018-09-30' AS Date))
SET IDENTITY_INSERT [dbo].[Suscripciones] OFF
SET IDENTITY_INSERT [dbo].[Tipo] ON 

INSERT [dbo].[Tipo] ([IDTipo], [Tipo]) VALUES (1, N'Dia')
INSERT [dbo].[Tipo] ([IDTipo], [Tipo]) VALUES (2, N'Mes')
INSERT [dbo].[Tipo] ([IDTipo], [Tipo]) VALUES (3, N'Año')
SET IDENTITY_INSERT [dbo].[Tipo] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([IDUsuario], [Nombre], [ApellidoP], [ApellidoM]) VALUES (1, N'Admin', N'Administrador', N'Administrador')
INSERT [dbo].[Usuario] ([IDUsuario], [Nombre], [ApellidoP], [ApellidoM]) VALUES (2, N'Jose Angel', N'Monroy', N'Rueda')
INSERT [dbo].[Usuario] ([IDUsuario], [Nombre], [ApellidoP], [ApellidoM]) VALUES (3, N'Viridiana', N'Tarazon', N'Alatorre')
INSERT [dbo].[Usuario] ([IDUsuario], [Nombre], [ApellidoP], [ApellidoM]) VALUES (4, N'Juan Carlos', N'Caciano', N'Hernandez')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [FK_Login_Usuario] FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK_Login_Usuario]
GO
ALTER TABLE [dbo].[Membrecia]  WITH CHECK ADD  CONSTRAINT [FK_Membrecia_Tipo] FOREIGN KEY([IDTipo])
REFERENCES [dbo].[Tipo] ([IDTipo])
GO
ALTER TABLE [dbo].[Membrecia] CHECK CONSTRAINT [FK_Membrecia_Tipo]
GO
ALTER TABLE [dbo].[Recibo]  WITH CHECK ADD  CONSTRAINT [FK_Recibo_Usuario] FOREIGN KEY([IDEmpleado])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Recibo] CHECK CONSTRAINT [FK_Recibo_Usuario]
GO
ALTER TABLE [dbo].[Recibo]  WITH CHECK ADD  CONSTRAINT [FK_Recibo_Usuario1] FOREIGN KEY([IDCliente])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Recibo] CHECK CONSTRAINT [FK_Recibo_Usuario1]
GO
ALTER TABLE [dbo].[Registros]  WITH CHECK ADD  CONSTRAINT [FK_Registros_Membrecia] FOREIGN KEY([IDMembrecia])
REFERENCES [dbo].[Membrecia] ([IDMembrecia])
GO
ALTER TABLE [dbo].[Registros] CHECK CONSTRAINT [FK_Registros_Membrecia]
GO
ALTER TABLE [dbo].[Suscripciones]  WITH CHECK ADD  CONSTRAINT [FK_Suscripciones_Membrecia] FOREIGN KEY([IDMembrecia])
REFERENCES [dbo].[Membrecia] ([IDMembrecia])
GO
ALTER TABLE [dbo].[Suscripciones] CHECK CONSTRAINT [FK_Suscripciones_Membrecia]
GO
ALTER TABLE [dbo].[Suscripciones]  WITH CHECK ADD  CONSTRAINT [FK_Suscripciones_Usuario] FOREIGN KEY([IDCliente])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Suscripciones] CHECK CONSTRAINT [FK_Suscripciones_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[ListaDeCargos]    Script Date: 8/31/2018 3:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ListaDeCargos]
as 
select * from Cargo

GO
/****** Object:  StoredProcedure [dbo].[ListaDeUsuarios]    Script Date: 8/31/2018 3:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ListaDeUsuarios]
as
select Usuario.IDUsuario,Nombre + ' '+ ApellidoP + ' '+ ApellidoM as Nombre 
from Usuario
inner join Login on Login.IDUsuario != Usuario.IDUsuario
where Usuario.IDUsuario != Login.IDUsuario

GO
/****** Object:  StoredProcedure [dbo].[MostrarClientes]    Script Date: 8/31/2018 3:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[MostrarClientes]
as
select IDUsuario,S.IDSuscripcion,Nombre +' '+ Usuario.ApellidoP as Nombre,M.NombreMembrecia as Membrecia,S.FechaFin as Expiracion
from Usuario
left join Suscripciones S on S.IDCliente = Usuario.IDUsuario
left join Membrecia M on M.IDMembrecia= S.IDMembrecia

GO
/****** Object:  StoredProcedure [dbo].[MostrarEmpleados]    Script Date: 8/31/2018 3:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MostrarEmpleados]
as
select IDLogin,Login.IDUsuario,C.Nombre + ' '+ C.ApellidoP as Nombre, UserName as Usuario, Cargo
 from Login
 inner join Usuario C on C.IDUsuario = Login.IDUsuario

GO
/****** Object:  StoredProcedure [dbo].[NuevoLogin]    Script Date: 8/31/2018 3:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[NuevoLogin]
@IDUsuario int,
@UserName varchar(50),
@Pass varchar(100),
@Cargo int
as
insert into Login VALUES(@IDUsuario,@UserName,@Pass,@Cargo)

GO
/****** Object:  StoredProcedure [dbo].[NuevoUsuario]    Script Date: 8/31/2018 3:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NuevoUsuario]
@Nombre varchar(50),
@ApellidoP varchar(50),
@ApellidoM varchar(50)
as
insert into Usuario VALUES(@Nombre,@ApellidoP,@ApellidoM)

GO
/****** Object:  StoredProcedure [dbo].[SPIniciarSesion]    Script Date: 8/31/2018 3:08:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPIniciarSesion]
@Usuario varchar(50),
@Pass varchar(50)
as
select * from Login
where UserName = @Usuario AND Pwd = @Pass;

GO
