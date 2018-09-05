Lista de membresia

ALTER procedure [dbo].[ListaMembresia]
as
select NombreMembrecia,Duracion,Precio from Membrecia

Lista de tipo

ALTER procedure [dbo].[ListaTipoMembresia]
as 
Select * FROM Tipo


Insertar Membresia

ALTER procedure [dbo].[NuevaMembresia]
@NombreM varchar(50),
@Duracioon int,
@IdT int,
@precio money
as
insert into Membrecia values(@NombreM,@Duracioon,@IdT,@precio)
