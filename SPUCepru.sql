create function dbo.Calificacion(@YourString VARCHAR(50),@YourString1 VARCHAR(50)) returns numeric(5,2)
 
AS

BEGIN
declare @lnu int--CONTADOR PARA EL WHILE
declare @count int--CONTADOR PARA EL SUBSTRING PARA LA POSICION
declare @lstdato varchar(1)--CHAR DE  LA RESPUESTA DEL ALUMNO
declare @Respuesta varchar(1)--CHAR DE LA CLAVE DE RESPUESTAS
DECLARE @valor FLOAT
declare @coincidencias numeric(5,2)--VALOR DE LAS COINCIDENCIAS DE LA RESPUESTA ALUMNO YCLAVE DE RESPUESTAS
declare @RespuestasBlanco numeric(5,2)--VALOR DE LAS RESPUESTAS EN BLANCO
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
				set @RespuestasBlanco=@RespuestasBlanco+0.08
				--print @lstdato+'    '+@Respuesta+'     '+ltrim(0.1)
			end
			
	end
	set @count=@count+1
	set @lnu=@lnu+1	
	
end

 return cast((@RespuestasBlanco+@coincidencias-0.4) as varchar(6))
	
END
go

create function dbo.Calificacion(@YourString VARCHAR(50),@YourString1 VARCHAR(50)) returns numeric(5,2)
 
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

go
drop function dbo.Calificacion
GO

create function dbo.Correctas(@YourString VARCHAR(50),@YourString1 VARCHAR(50)) returns int
 
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
		set @coincidencias=@coincidencias+1
	end
	else
	begin
		if(@lstdato=' ')
			begin
				set @RespuestasBlanco=@RespuestasBlanco+0
				--print @lstdato+'    '+@Respuesta+'     '+ltrim(0.1)
			end
			
	end

	set @count=@count+1
	set @lnu=@lnu+1	
	
end

 return (@coincidencias + @RespuestasBlanco)
	
END
go

create function dbo.Incorrectas(@YourString VARCHAR(50),@YourString1 VARCHAR(50)) returns int
 
AS

BEGIN
declare @lnu int--CONTADOR PARA EL WHILE
declare @count int--CONTADOR PARA EL SUBSTRING PARA LA POSICION
declare @lstdato varchar(1)--CHAR DE  LA RESPUESTA DEL ALUMNO
declare @Respuesta varchar(1)--CHAR DE LA CLAVE DE RESPUESTAS
DECLARE @valor FLOAT
declare @incorrectas float--VALOR DE LAS COINCIDENCIAS DE LA RESPUESTA ALUMNO YCLAVE DE RESPUESTAS
declare @RespuestasBlanco float--VALOR DE LAS RESPUESTAS EN BLANCO
set @lnu=0--INICIALIZAMOS EL CONTADOR DEL WHILE
set @count=0--INICIALIZAMOS EL VALOR DE LA POSICION DE LAS RESPUESTAS
set @incorrectas=50
set @RespuestasBlanco=0
while LEN(@YourString)!=@lnu
begin
	set @lstdato=SUBSTRING(@YourString,@count,1)
	set @Respuesta=SUBSTRING(@YourString1,@count,1)
	if(@lstdato=@Respuesta)
	begin
		set @incorrectas=@incorrectas-1
	end
	else
	begin
		if(@lstdato=' ')
			begin
				set @incorrectas=@incorrectas-1
				--print @lstdato+'    '+@Respuesta+'     '+ltrim(0.1)
			end
			
	end
	set @count=@count+1
	set @lnu=@lnu+1	
	
end

 return (@incorrectas)
	
END
go

create function dbo.Blancas(@YourString VARCHAR(50),@YourString1 VARCHAR(50)) returns int
 
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
	if(@lstdato=' ')
	begin
		--set @valor=0.4
		--print @lstdato+'    '+@Respuesta+'  0.4'
		set @RespuestasBlanco=@RespuestasBlanco+1
	end
	set @count=@count+1
	set @lnu=@lnu+1	
	
end

 return (@RespuestasBlanco-1)
	
END
go

create procedure spuCalificar
as
begin
	select R.CodTarjeta, R.Tema, R.Respuestas, C.clave
	into #T1
	from TRespuesta R inner join TClaveRespuesta C
	on R.Tema = C.tema

	select T.CodTarjeta,dbo.Correctas(T.Respuestas, T.clave) as Correctas, dbo.Incorrectas(T.Respuestas, T.clave) as Incorrectas, dbo.Blancas(T.Respuestas, T.clave) as Blancas, dbo.Calificacion(T.Respuestas, T.clave) as Nota
	into #T2
	from #T1 T

	select A.CodTarjeta, A.Nota, B.Tema, A.Correctas, A.Incorrectas, A.Blancas
	into #T3
	from #T2 A inner join #T1 B
	on A.CodTarjeta = B.CodTarjeta
	select *
	from #T3

	insert into TCalificada (CodTarjeta, Nota, Tema, Correctas, Incorrectas, Blancas)
	select C.CodTarjeta, C.Nota, C.Tema, C.Correctas, C.Incorrectas, C.Blancas
	from #T3 C
end
go

drop table #T3
select *
from TRespuesta

exec spuCalificar
go

select *
from TCalificada

drop procedure spuCalificar
go

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
