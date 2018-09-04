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

create table TClaveRespuesta (
	tema varchar(1) not null,
	clave varchar(50) not null,

	primary key (tema)
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

create table TCalificada
(
	CodTarjeta varchar(6),
	nota numeric(5,2),
	Tema varchar(1),
	Correctas varchar(50),
	Incorrectas varchar(50),
	Blancas varchar(50),

	primary key (CodTarjeta, Tema)
)
go

create table TFaltantes (
	cod varchar(8)
	primary key(cod)
)
go

create table TErrores(
	Codigo int identity(1,1),
	codigoEsc varchar(3) not null,
	nombreEsc varchar(50) not null,
	grupoEsc varchar(1) not null,
	codigoPost varchar(8) not null,
	nombrePost varchar(50) not null,
	carreraPost varchar(3) not null,
	cicloPost varchar(7) not null,
	aulaPost varchar(4) not null,
	carpetaPost varchar(3) not null,
	sexoPost varchar(10) not null,
	grupoPost varchar(1) not null,
	CodTarjetaIden varchar (6),
	CodAlumnoIden varchar (8),
	CodTarjetaT varchar (6),
	TemaT varchar (1),
	RespuestasT varchar (50),
	temaRes varchar(1) not null,
	claveRes varchar(50) not null,
	codFal varchar(8),
	obs varchar(50),

	primary key (Codigo)
)
go