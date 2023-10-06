-------------------------------------------------------------------------------- VIDEO 1 --------------------------------------------------------------------------------
select * from USUARIO;

select * from ROL;

select * from PERMISO;

--insert into ROL (descripcion)
--	values('ADMINISTRADOR');

--insert into ROL (descripcion)
--	values('EMPLEADO');

--insert into USUARIO(documento,	nombreCompleto, correo, clave, idRol)
--	values('101010', 'ADMIN', '@GMAIL.COM', '123', 1);

--insert into USUARIO(documento,	nombreCompleto, correo, clave, idRol)
--	values('202020', 'EMPLEADO', '@GMAIL.COM', '456', 2);


-------------------------------------------------------------------------------- VIDEO 3 --------------------------------------------------------------------------------
select * from ROL;

select p.IdRol, p.NombreMenu from PERMISO p
	inner join ROL r on r.IdRol = p.IdRol
	inner join USUARIO u on u.IdRol = r.IdRol
	where u.IdUsuario = 2

--insert into PERMISO(idRol, nombreMenu) values 
--	(1, 'menuUsuarios'),
--	(1, 'menuMantenedor'),
--	(1, 'menuVentas'),
--	(1, 'menuCompras'),
--	(1, 'menuClientes'),
--	(1, 'menuProveedores'),
--	(1, 'menuReportes'),
--	(1, 'menuAcercaDe');

--insert into PERMISO(idRol, nombreMenu) values 
--	(2, 'menuVentas'),
--	(2, 'menuCompras'),
--	(2, 'menuClientes'),
--	(2, 'menuProveedores'),
--	(2, 'menuAcercaDe');


--DELETE FROM PERMISO; --Elimina los registros de la tabla
--DBCC CHECKIDENT ('PERMISO', RESEED, 0); --Reinicia los atributos identity a 0, por loq ue el primer registro sera 1

select * from PERMISO;

-------------------------------------------------------------------------------- VIDEO 5 --------------------------------------------------------------------------------
select u.IdUsuario, u.Documento, u.NombreCompleto, u.Correo, u.Clave, u.Estado, r.IdRol, r.Descripcion from USUARIO u
inner join	 rol r on r.IdRol = u.IdRol

--update USUARIO set estado = 0 where IdUsuario = 2;

---------- PROCEDIMIENTO ALMACENADO REGISTRAR USUARIO----------
CREATE PROC SP_REGISTRARUSUARIO (
	@Documento nvarchar(50),
	@NombreCompleto nvarchar(100),
	@Correo nvarchar(100),
	@Clave nvarchar(100),
	@IdRol int,
	@Estado bit,
	@IdUsuarioResultado int output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @IdUsuarioResultado = 0
	set @Mensaje = ''

	if not exists(select * from USUARIO where Documento = @Documento)
	begin
		insert into USUARIO(Documento, NombreCompleto, Correo, Clave, IdRol, Estado) values
			(@Documento, @NombreCompleto, @Correo, @Clave, @IdRol, @Estado)

			set @IdUsuarioResultado = SCOPE_IDENTITY()

	end
	else 
		set @Mensaje = 'No se puede repetir el documento para más de un usuario'
end

--DROP PROCEDURE SP_REGISTRARUSUARIO; -- Elimina el procedimiento almacenado

---------- AGREGAR UN USUARIO ----------
declare @IdUsuarioGenerado int
declare @Mensaje nvarchar(500)

exec SP_REGISTRARUSUARIO '123', 'pruebas', 'test@gmail.com', '456', 2, 1, @IdUsuarioGenerado output, @Mensaje output

select @IdUsuarioGenerado
select @Mensaje

go

---------- PROCEDIMIENTO ALMACENADO EDITAR USUARIO----------
CREATE PROC SP_EDITARUSUARIO (
	@IdUsuario int,
	@Documento nvarchar(50),
	@NombreCompleto nvarchar(100),
	@Correo nvarchar(100),
	@Clave nvarchar(100),
	@IdRol int,
	@Estado bit,
	@Respuesta bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	if not exists(select * from USUARIO where Documento = @Documento and IdUsuario != @IdUsuario)
	begin
		update USUARIO set
			Documento = @Documento,
			NombreCompleto = @NombreCompleto,
			Correo = @Correo, 
			Clave = @Clave, 
			IdRol = @IdRol, 
			Estado = @Estado
			where IdUsuario = @IdUsuario

			set @Respuesta = 1
	end
	else 
		set @Mensaje = 'No se puede repetir el documento para más de un usuario'
end

--DROP PROCEDURE SP_EDITARUSUARIO; -- Elimina el procedimiento almacenado

---------- EDITAR UN USUARIO ----------
select * from USUARIO --Me lo agrego anteriormente con el ID "1002"

declare @Respuesta bit
declare @Mensaje nvarchar(500)

exec SP_EDITARUSUARIO 2,'123', 'pruebas 2', 'test@gmail.com', '456', 2, 1, @Respuesta output, @Mensaje output

select @Respuesta
select @Mensaje

-------------------------------------------------------------------------------- VIDEO 6 --------------------------------------------------------------------------------
---------- PROCEDIMIENTO ALMACENADO ELIMINAR USUARIO----------
CREATE PROC SP_ELIMINARUSUARIO (
	@IdUsuario int,
	@Respuesta bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	if not exists (select * from COMPRA c
	inner join USUARIO u on u.IdRol = c.IdUsuario
	where u.IdUsuario = @IdUsuario)
	begin
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porue el usuario se encuentra relacionado a una COMPRA\n'
	end

	if not exists (select * from VENTA v
	inner join USUARIO u on u.IdRol = v.IdUsuario
	where v.IdUsuario = @IdUsuario)
	begin
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porue el usuario se encuentra relacionado a una VENTA\n'
	end

	if (@pasoreglas = 1)
	begin
		delete from USUARIO where IdUsuario = @IdUsuario
		set @Respuesta = 1
	end
end