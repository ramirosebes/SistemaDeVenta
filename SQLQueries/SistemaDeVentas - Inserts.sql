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
--	values('20', 'EMPLEADO', '@GMAIL.COM', '123', 2);

select * from ROL;

select p.idRol, p.nombreMenu from PERMISO p
	inner join ROL r on r.idRol = p.idRol
	inner join USUARIO u on u.idRol = r.idRol
	where u.idUsuario = 1

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


--Video 5
select u.idUsuario, u.documento, u.nombreCompleto, u.correo, u.clave, u.estado, r.idRol, r.descripcion from USUARIO u
inner join	 rol r on r.idRol = u.idRol

--update USUARIO set estado = 0 where idUsuario = 2;



----------CREACION DEL PROCEDIMIENTO ALMACENADO DE AGREGAR USUARIO----------
--CREATE PROC SP_REGISTRARUSUARIO (
--	@documento nvarchar(50),
--	@nombreCompleto nvarchar(100),
--	@correo nvarchar(50),
--	@clave nvarchar(50),
--	@idRol int,
--	@estado bit,
--	@idUsuarioResultado int output,
--	@mensaje nvarchar(500) output
--)
--as
--begin
--	set @idUsuarioResultado = 0
--	set @mensaje = ''

--	if not exists(select * from USUARIO where documento = @documento)
--	begin
--		insert into USUARIO(documento, nombreCompleto, correo, clave, idRol, estado) values
--			(@documento, @nombreCompleto, @correo, @clave, @idRol, @estado)

--			set @idUsuarioResultado = SCOPE_IDENTITY()

--	end
--	else 
--		set @mensaje = 'No se puede repetir el documento para más de un usuario'
--end

---------- AGREGANDO UN USUARIO ----------
--declare @idUsuarioGenerado int
--declare @mensaje nvarchar(500)

--exec SP_REGISTRARUSUARIO '123', 'pruebas', 'test@gmail.com', '456', 2, 1, @idUsuarioGenerado output, @mensaje output

--select @idUsuarioGenerado
--select @mensaje

--go


----------CREACION DEL PROCEDIMIENTO ALMACENADO DE MOFIDICAR USUARIO----------
--CREATE PROC SP_EDITARUSUARIO (
--	@idUsuario int,
--	@documento nvarchar(50),
--	@nombreCompleto nvarchar(100),
--	@correo nvarchar(50),
--	@clave nvarchar(50),
--	@idRol int,
--	@estado bit,
--	@respuesta bit output,
--	@mensaje nvarchar(500) output
--)
--as
--begin
--	set @respuesta = 0
--	set @mensaje = ''

--	if not exists(select * from USUARIO where documento = @documento and idUsuario != @idUsuario)
--	begin
--		update USUARIO set
--			documento = @documento,
--			nombreCompleto = @nombreCompleto,
--			correo = @correo, 
--			clave = @clave, 
--			idRol = @idRol, 
--			estado = @estado
--			where idUsuario = @idUsuario

--			set @respuesta = 1

--	end
--	else 
--		set @mensaje = 'No se puede repetir el documento para más de un usuario'
--end

---------- MOFIDICAR UN USUARIO ----------
select * from USUARIO --Me lo agrego anteriormente con el ID "1002"

declare @respuesta bit
declare @mensaje nvarchar(500)

exec SP_EDITARUSUARIO 2,'123', 'pruebas 2', 'test@gmail.com', '456', 2, 1, @respuesta output, @mensaje output

select @respuesta
select @mensaje