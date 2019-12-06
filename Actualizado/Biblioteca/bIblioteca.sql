USE MASTER
GO

BEGIN 
CREATE DATABASE Biblioteca
END

BEGIN 
CREATE TABLE Editorial (
codEdi int IDENTITY (1,1) PRIMARY KEY, 
nomEdi varchar (40)not null)
END



CREATE TABLE Libro (
codLib int IDENTITY (1,1) PRIMARY KEY,
nomLib varchar (40)not null,
canPag int,
codE int foreign key (codE) references Editorial (codEdi))

INSERT INTO Editorial (nomEdi) values ('McGraw-Hill')
INSERT INTO Editorial (nomEdi) values ('Prentice Hall')
INSERT INTO Editorial (nomEdi) values ('Kimpres')
INSERT INTO Editorial (nomEdi) values ('Anagrama')




INSERT INTO Libro (nomLib,canPag,codE) values ('Los juegos',100,1)
INSERT INTO Libro (nomLib,canPag,codE) values ('Atena',120,1)
INSERT INTO Libro (nomLib,canPag,codE) values ('Niño',180,2)
INSERT INTO Libro (nomLib,canPag,codE) values ('Hp',300,2)
INSERT INTO Libro (nomLib,canPag,codE) values ('Sofia',500,3)
INSERT INTO Libro (nomLib,canPag,codE) values ('Lou',400,3)
INSERT INTO Libro (nomLib,canPag,codE) values ('Ellos',500,4)
INSERT INTO Libro (nomLib,canPag,codE) values ('San',400,4)
select*from Editorial
select*from Libro
DELETE Libro F
go
create procedure pa_Xml
@codigo int 
as
begin 
select *from Libro where codE=@codigo 
end
go

create procedure pa_Ceditorial
as
begin
select*from Editorial
end
go
create procedure pa_Clibro
as
begin
select*from Libro
end
go


CREATE PROCEDURE pa_Inicial
@nombre varchar (40)
AS
BEGIN
SELECT*FROM Libro where nomLib like @nombre+'%'
END
GO


CREATE PROCEDURE pa_Mlibro
AS
BEGIN
SELECT*FROM Libro
END
GO

CREATE PROCEDURE pa_Meditorial
AS
BEGIN
SELECT*FROM Editorial
END
GO

CREATE PROCEDURE pa_mostrarNombres
@nombre VARCHAR (30)
AS
BEGIN 
SELECT * FROM Editorial WHERE nomEdi=@nombre
END
GO

alter procedure pa_Seleccionarlibros
@nombre varchar (30)
as
begin
select *from Libro where nomLib=@nombre
end

create procedure pa_comboE
@numero int
as
begin 
select * from Editorial where codEdi=@numero
end
go 

	
	
alter procedure pa_Comact
@nombre varchar (40)
as
begin 
select nomEdi,codE from Editorial,Libro where nomEdi=@nombre and codE=codEdi
end
go
CREATE PROCEDURE pa_Eliminar
@nombre VARCHAR (30),
@codigo INT
AS
BEGIN
DELETE FROM Editorial WHERE nomEdi=@nombre AND codEdi=@codigo
END
GO

CREATE PROCEDURE pa_Eliminarl
@nombre VARCHAR (30),
@codigo INT
AS
BEGIN
DELETE FROM Libro WHERE nomLib=@nombre AND codLib=@codigo
END
GO


create procedure pa_Modificar
@nombre varchar (40),
@codigo int
as
begin 
update Editorial set nomEdi=@nombre where codEdi=@codigo
end
go

create procedure pa_ModificarL
@nombre varchar (40),
@codigo int
as
begin 
update Libro set nomLib=@nombre where codLib=@codigo
end
go


create procedure pa_Añadir
@nombre varchar (40)
as
begin
insert into Editorial(nomEdi)values (@nombre)
end
go

alter procedure pa_AñadirLibro
@nombre varchar (40),
@codigo int
as
begin
insert into  Libro (nomLib,codE)values (@nombre,@codigo)
end
go

create procedure pa_seleccion
as
begin 
select nomEdi,codEdi from Editorial
end
go
CREATE PROCEDURE pa_Editorialm
AS
BEGIN 
SELECT * FROM Editorial
END 
GO
create procedure pa_Nombres
AS
BEGIN 
SELECT nomEdi from Editorial
end
go

alter procedure pa_EditorialN
as
begin 
select nomEdi,codEdi  from Editorial
end
go

create procedure pa_McGraw
@codigo int
as
begin
select *from Libro where codEdi=@codigo
end
go

create procedure pa_Anagrama
@codigo int
as
begin
select *from Libro where codEdi=@codigo
end
go

create procedure pa_Prentice
@codigo int
as
begin
select *from Libro where codEdi=@codigo
end
go

create procedure pa_Kimpres
@codigo int
as
begin
select *from Libro where codEdi=@codigo
end
go

 

create procedure pa_DcodLib
as
begin
select *from Libro  order by codLib desc;
end
go

create procedure pa_DnomLib 
as
begin
select *from Libro order by nomLib  desc;
end
go


CREATE PROCEDURE pa_NLibro
AS
BEGIN
SELECT * FROM Libro
END
GO

create procedure pa_DcodEdi
as
begin
select *from Libro  order by codEdi desc;
end 
go


create procedure pa_AcodLib
as
begin
select *from Libro  order by codLib asc;
end
go

create procedure pa_AnomLib 
as
begin
select *from Libro order by nomLib  asc;
end
go




create procedure pa_AodEdi
as
begin
select *from Libro  order by codEdi asc;
end 
go

create procedure pa_DcanPag
AS
BEGIN
SELECT *FROM Libro ORDER BY canPag DESC;
END
GO

CREATE PROCEDURE pa_AcanPag
AS
BEGIN
SELECT *FROM Libro ORDER BY canPag ASC;
END
GO