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
	grupo varchar(1) not null,

	primary key (codigo), foreign key (carrera) references TEscuelas
)
go


create procedure sp_listarEscuelas
as
select * from TEscuelas
go
create procedure sp_listarPostulante
as
select * from TEscuelas
go
create procedure sp_insertarEscuelas(
	@codEscuela varchar(3),
	@nomEscuela varchar(50),
	@grpEscuela varchar(1))
	as
	insert into TEscuelas values(@codEscuela, @nomEscuela, @grpEscuela)
go
create procedure sp_insertarPostulante(
	@codPost varchar(8),
	@nomPost varchar(50),
	@carrPost varchar(3),
	@cicloPost varchar(7),
	@aulaPost varchar(4),
	@carpPost varchar(3),
	@sexPost varchar(10),
	@grpPost varchar(1))
	as
	insert into TPostulante values(@codPost, @nomPost, @carpPost, @cicloPost, @aulaPost, @carpPost, @sexPost, @grpPost)
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