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
	Tema varchar(1),
	Correctas varchar(50),
	Incorrectas varchar(50),
	Blancas varchar(50),

	primary key (CodTarjeta, Tema)
)



select R.CodTarjeta, R.Tema, R.Respuestas, C.clave
into #T1
from TRespuesta R inner join TClaveRespuesta C
on R.Tema = C.tema

select Respuestas, clave
from #T1

drop table #T1

SELECT C dbo.Calificacion(C.Respuestas,C) as Nota into #TCALIFICACION
from #T1 C

create function dbo.Calificacion(@YourString VARCHAR(50),@YourString1 VARCHAR(50)) returns int
 
AS

BEGIN
declare @lnu int--CONTADOR PARA EL WHILE
declare @count int--CONTADOR PARA EL SUBSTRING PARA LA POSICION
declare @lstdato varchar(1)--CHAR DE  LA RESPUESTA DEL ALUMNO
declare @Respuesta varchar(1)--CHAR DE LA CLAVE DE RESPUESTAS
DECLARE @valor FLOAT
declare @coincidencias float--VALOR DE LAS COINCIDENCIAS DE LA RESPUESTA ALUMNO YCLAVE DE RESPUESTAS
declare @RespuestasBlanco float--VALOR DE LAS RESPUESTAS EN BLANCO
set @lnu=0--INICIALIZAMOS EL CONTADOR DEL WHILE
set @count=0--INICIALIZAMOS EL VALOR DE LA POSICION DE LAS RESPUESTAS
set @coincidencias=0
set @RespuestasBlanco=0
while LEN(@YourString)!=@lnu
begin
	set @lstdato=SUBSTRING(@YourString,@count,1)
	set @Respuesta=SUBSTRING(@YourString1,@count,1)
	if(@lstdato=@Respuesta)
	begin
		--set @valor=0.4
		--print @lstdato+'    '+@Respuesta+'  0.4'
		set @coincidencias=@coincidencias+0.4
	end
	else
	begin
		if(@lstdato=' ')
			begin
				set @RespuestasBlanco=@RespuestasBlanco+0.1
				--print @lstdato+'    '+@Respuesta+'     '+ltrim(0.1)
			end
			
	end
	set @count=@count+1
	set @lnu=@lnu+1	
	
end

 return (@RespuestasBlanco+@coincidencias-0.4)
	
END

exec dbo.CalificacionAlumno;



create table TFaltantes (
	cod varchar(8)
	
	primary key(cod)
)


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
	@grpPost varchar(1))
	as
	insert into TPostulante values(@codPost, @nomPost, @carpPost, @cicloPost, @aulaPost, @carpPost, @sexPost, @grpPost)
go

create procedure sp_editarPostulante(
	@codPost varchar(8),
	@nomPost varchar(50),
	@carrPost varchar(3),
	@cicloPost varchar(7),
	@aulaPost varchar(4),
	@carpPost varchar(3),
	@sexPost varchar(10),
	@grpPost varchar(1))
	as
	update TPostulante set nombre=@nomPost, carrera=@carrPost, ciclo=@cicloPost, aula=@aulaPost, carpeta=@carpPost, sexo=@sexPost, grupo=@grpPost where codigo=@codPost
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
	@grpPost varchar(1))
	as
	insert into TPostulante values(@codPost, @nomPost, @carpPost, @cicloPost, @aulaPost, @carpPost, @sexPost, @grpPost)
go

create procedure sp_editarPostulante(
	@codPost varchar(8),
	@nomPost varchar(50),
	@carrPost varchar(3),
	@cicloPost varchar(7),
	@aulaPost varchar(4),
	@carpPost varchar(3),
	@sexPost varchar(10),
	@grpPost varchar(1))
	as
	update TPostulante set nombre=@nomPost, carrera=@carrPost, ciclo=@cicloPost, aula=@aulaPost, carpeta=@carpPost, sexo=@sexPost, grupo=@grpPost where codigo=@codPost
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
select * from TErrores

delete from TErrores

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
	obs varchar(100),

	primary key (Codigo)
)
go
drop table TErrores

Update TErrores set obs = 'Se realizo una Correccion a: 43123457 AMAT-SAMATA-MELANY SHIOMARA 301 2018-CI C-07 54 Femenino C' where Codigo = '1'
Insert into  TPostulante values ('43123457','AMAT-SAMATA-MELANY SHIOMARA','301','2018-CI','C-07','54','Femenino','C')