USE [xtreamgymBD]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 08/21/2018 22:15:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[IDusuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](30) NULL,
	[ApellidoUno] [varchar](15) NULL,
	[ApellidoDos] [varchar](15) NULL,
	[Contra] [varchar](8) NULL,
	[Activo] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IDusuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Provedor]    Script Date: 08/21/2018 22:15:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provedor](
	[IdProvedor] [int] NOT NULL,
	[NombreProv] [varchar](20) NULL,
 CONSTRAINT [PK_Provedor] PRIMARY KEY CLUSTERED 
(
	[IdProvedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Membrecia]    Script Date: 08/21/2018 22:15:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Membrecia](
	[IdMembresia] [int] NOT NULL,
	[Nombre] [varchar](20) NULL,
	[Duracion] [int] NULL,
	[precio] [money] NULL,
 CONSTRAINT [PK_Membrecia] PRIMARY KEY CLUSTERED 
(
	[IdMembresia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gastos]    Script Date: 08/21/2018 22:15:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gastos](
	[IdGasto] [int] NOT NULL,
	[IdProvedor] [int] NULL,
	[DineroGasto] [money] NULL,
	[fechaGasto] [datetime] NULL,
 CONSTRAINT [PK_Gastos] PRIMARY KEY CLUSTERED 
(
	[IdGasto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 08/21/2018 22:15:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](30) NULL,
	[ApellidoUno] [varchar](15) NULL,
	[ApellidoDos] [varchar](15) NULL,
	[IdMembresia] [int] NULL,
	[FechaIni] [datetime] NULL,
	[FechaFinal] [datetime] NULL,
	[Huella] [varchar](50) NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Asistencia]    Script Date: 08/21/2018 22:15:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asistencia](
	[IdCliente] [int] NULL,
	[HoraEntrada] [time](7) NULL,
	[HoraSalida] [time](7) NULL,
	[IdUser] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pagos]    Script Date: 08/21/2018 22:15:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pagos](
	[IdCliente] [int] NOT NULL,
	[fechaPago] [datetime] NULL,
	[diner] [money] NULL,
	[IdPago] [int] NOT NULL,
	[IdUser] [int] NULL,
 CONSTRAINT [PK_pagos] PRIMARY KEY CLUSTERED 
(
	[IdPago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reportes]    Script Date: 08/21/2018 22:15:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reportes](
	[IdPago] [int] NULL,
	[IdGasto] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Asistencia_clientes]    Script Date: 08/21/2018 22:15:58 ******/
ALTER TABLE [dbo].[Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_Asistencia_clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[clientes] ([IdCliente])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Asistencia] CHECK CONSTRAINT [FK_Asistencia_clientes]
GO
/****** Object:  ForeignKey [FK_clientes_Membrecia]    Script Date: 08/21/2018 22:15:58 ******/
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_clientes_Membrecia] FOREIGN KEY([IdMembresia])
REFERENCES [dbo].[Membrecia] ([IdMembresia])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [FK_clientes_Membrecia]
GO
/****** Object:  ForeignKey [FK_Gastos_Provedor]    Script Date: 08/21/2018 22:15:58 ******/
ALTER TABLE [dbo].[Gastos]  WITH CHECK ADD  CONSTRAINT [FK_Gastos_Provedor] FOREIGN KEY([IdProvedor])
REFERENCES [dbo].[Provedor] ([IdProvedor])
GO
ALTER TABLE [dbo].[Gastos] CHECK CONSTRAINT [FK_Gastos_Provedor]
GO
/****** Object:  ForeignKey [FK_pagos_clientes]    Script Date: 08/21/2018 22:15:58 ******/
ALTER TABLE [dbo].[pagos]  WITH CHECK ADD  CONSTRAINT [FK_pagos_clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[clientes] ([IdCliente])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[pagos] CHECK CONSTRAINT [FK_pagos_clientes]
GO
/****** Object:  ForeignKey [FK_pagos_Usuario]    Script Date: 08/21/2018 22:15:58 ******/
ALTER TABLE [dbo].[pagos]  WITH CHECK ADD  CONSTRAINT [FK_pagos_Usuario] FOREIGN KEY([IdUser])
REFERENCES [dbo].[Usuario] ([IDusuario])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[pagos] CHECK CONSTRAINT [FK_pagos_Usuario]
GO
/****** Object:  ForeignKey [FK_Reportes_Gastos]    Script Date: 08/21/2018 22:15:58 ******/
ALTER TABLE [dbo].[Reportes]  WITH CHECK ADD  CONSTRAINT [FK_Reportes_Gastos] FOREIGN KEY([IdGasto])
REFERENCES [dbo].[Gastos] ([IdGasto])
GO
ALTER TABLE [dbo].[Reportes] CHECK CONSTRAINT [FK_Reportes_Gastos]
GO
/****** Object:  ForeignKey [FK_Reportes_pagos]    Script Date: 08/21/2018 22:15:58 ******/
ALTER TABLE [dbo].[Reportes]  WITH CHECK ADD  CONSTRAINT [FK_Reportes_pagos] FOREIGN KEY([IdPago])
REFERENCES [dbo].[pagos] ([IdPago])
GO
ALTER TABLE [dbo].[Reportes] CHECK CONSTRAINT [FK_Reportes_pagos]
GO
