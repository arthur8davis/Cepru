use master
go
if exists (select * from sysdatabases where name ='dbCepru')
begin
	drop database dbCepru
end
go

create database dbCepru

use dbCepru

create table TEscuelas (
	codigo varchar(3) not null,
	nombre varchar(50) not null,
	grupo varchar(1) not null,

	primary key (codigo)
)
go

use dbCepru
create table TPostulante (
	codigo varchar(8) not null,
	nombre varchar(50) not null,
	carrera varchar(3) not null,
	ciclo varchar(7) not null,
	aula varchar(4) not null,
	carpeta varchar(3) not null,
	sexo varchar(10) not null,
	grupo varchar(1) not null

	primary key (codigo), foreign key (carrera) references TEscuelas
)
go

create table TIdentidad
(--Atributos
	CodTarjeta varchar (6),
	CodAlumno varchar (8),

	--Definimos claves
	primary key(CodTarjeta),
	foreign key(CodAlumno) references TPostulante
)
go

create table TRespuesta
(--Atributos
	CodTarjeta varchar (6),
	Tema varchar (1),
	Respuestas varchar (50),

	--Definicion claves
	primary key(CodTarjeta,Tema),
	foreign key (CodTarjeta) references TIdentidad,
	foreign key (Tema) references TClaveRespuesta
)
go

create table TClaveRespuesta (
	tema varchar(1) not null,
	clave varchar(50) not null,

	primary key (tema)
)
go

--create table TTarjeta (
--	idTarjeta varchar(8) not null,
--	postulante varchar(8) not null,
--	respuesta varchar(50) not null,
--	tema varchar(1) not null,

--	primary key (idTarjeta), foreign key (postulante) references TPostulante
--)
--go

--create table TCalificacion (
--	codigoPostulante varchar(8) not null,
--	nota int not null,
--	nroCorrectas int,
--	nroIncorrectas int,
--	nroBlancas int

--	primary key (codigoPostulante)
--)
--go

create table TFaltantes (
	cod varchar(8)
	
	primary key(cod)
)

-- Procesos almacenados para ESCUELAS
create procedure sp_listarEscuelas
as
select * from TEscuelas
go

create procedure sp_editarEscuelas(
	@codEsc varchar(3),
	@nomEsc varchar(50),
	@grupEsc varchar(1))
	as
	update TEscuelas set nombre=@nomEsc, grupo=@grupEsc where codigo=@codEsc
go

create procedure sp_eliminarEscuelas (
	@cod varchar(3))
	as
	delete from TEscuelas where codigo=@cod
go

create procedure sp_insertarEscuelas(
	@codEscuela varchar(3),
	@nomEscuela varchar(50),
	@grpEscuela varchar(1))
	as
	insert into TEscuelas values(@codEscuela, @nomEscuela, @grpEscuela)
go

-- Procesos almacenados para ESCUELAS
create procedure sp_listarPostulante
as
select * from TEscuelas
go

create procedure sp_insertarPostulante(
	@codPost varchar(8),
	@nomPost varchar(50),
	@carrPost varchar(3),
	@cicloPost varchar(7),
	@aulaPost varchar(4),
	@carpPost varchar(3),
	@sexPost varchar(10),
	@grpPost varchar(1),
	@falPost varchar(3))
	as
	insert into TPostulante values(@codPost, @nomPost, @carpPost, @cicloPost, @aulaPost, @carpPost, @sexPost, @grpPost, @falPost)
go

create procedure sp_editarPostulante(
	@codPost varchar(8),
	@nomPost varchar(50),
	@carrPost varchar(3),
	@cicloPost varchar(7),
	@aulaPost varchar(4),
	@carpPost varchar(3),
	@sexPost varchar(10),
	@grpPost varchar(1),
	@falPost varchar(3))
	as
	update TPostulante set nombre=@nomPost, carrera=@carrPost, ciclo=@cicloPost, aula=@aulaPost, carpeta=@carpPost, sexo=@sexPost, grupo=@grpPost, falto=@falPost where codigo=@codPost
go

create procedure sp_eliminarPostulante(
	@cod varchar(8))
	as
	delete from TPostulante where codigo=@cod
go

-- Procesos alamacenados para CALIFICACIONES
create procedure sp_listarCalificacion
as
select * from TCalificacion
go

create procedure sp_insertarCalificacion(
	@codPost varchar(8),
	@nomPost varchar(50),
	@carrPost varchar(3),
	@cicloPost varchar(7),
	@aulaPost varchar(4),
	@carpPost varchar(3),
	@sexPost varchar(10),
	@grpPost varchar(1),
	@falPost varchar(3))
	as
	insert into TPostulante values(@codPost, @nomPost, @carpPost, @cicloPost, @aulaPost, @carpPost, @sexPost, @grpPost, @falPost)
go

create procedure sp_editarPostulante(
	@codPost varchar(8),
	@nomPost varchar(50),
	@carrPost varchar(3),
	@cicloPost varchar(7),
	@aulaPost varchar(4),
	@carpPost varchar(3),
	@sexPost varchar(10),
	@grpPost varchar(1),
	@falPost varchar(3))
	as
	update TPostulante set nombre=@nomPost, carrera=@carrPost, ciclo=@cicloPost, aula=@aulaPost, carpeta=@carpPost, sexo=@sexPost, grupo=@grpPost, falto=@falPost where codigo=@codPost
go

create procedure sp_eliminarPostulante(
	@cod varchar(8))
	as
	delete from TPostulante where codigo=@cod
go



use dbCepru
insert into TEscuelas values('999', 'Bioquimica', 'B')
go

use dbCepru
delete from TEscuelas
go

use dbCepru
delete from TPostulante
go

use dbCepru
select * from TEscuelas
go


select * from TPostulante

select * from TFaltantes

select * from TIdentidad

select * from TRespuesta

select * from TClaveRespuesta