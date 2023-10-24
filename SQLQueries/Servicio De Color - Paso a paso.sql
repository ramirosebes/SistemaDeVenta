-------------------------------------------------------------------------------- VIDEO 1 --------------------------------------------------------------------------------
select * from USUARIO;

select * from ROL;

select * from PERMISO;

insert into ROL (descripcion)
	values('ADMINISTRADOR');

insert into ROL (descripcion)
	values('EMPLEADO');

insert into USUARIO(documento,	nombreCompleto, correo, clave, idRol)
	values('101010', 'ADMIN', '@GMAIL.COM', '123', 1);

insert into USUARIO(documento,	nombreCompleto, correo, clave, idRol)
	values('202020', 'EMPLEADO', '@GMAIL.COM', '456', 2);


-------------------------------------------------------------------------------- VIDEO 3 --------------------------------------------------------------------------------
select * from ROL;

select p.IdRol, p.NombreMenu from PERMISO p
	inner join ROL r on r.IdRol = p.IdRol
	inner join USUARIO u on u.IdRol = r.IdRol
	where u.IdUsuario = 2

insert into PERMISO(idRol, nombreMenu) values 
	(1, 'menuUsuarios'),
	(1, 'menuMantenedor'),
	(1, 'menuVentas'),
	(1, 'menuCompras'),
	(1, 'menuClientes'),
	(1, 'menuProveedores'),
	(1, 'menuReportes'),
	(1, 'menuAcercaDe');

insert into PERMISO(idRol, nombreMenu) values 
	(2, 'menuVentas'),
	(2, 'menuCompras'),
	(2, 'menuClientes'),
	(2, 'menuProveedores'),
	(2, 'menuAcercaDe');


--DELETE FROM PERMISO; --Elimina los registros de la tabla
--DBCC CHECKIDENT ('PERMISO', RESEED, 0); --Reinicia los atributos identity a 0, por loq ue el primer registro sera 1

select * from PERMISO;

-------------------------------------------------------------------------------- VIDEO 5 --------------------------------------------------------------------------------
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

------------ AGREGAR UN USUARIO ----------
--declare @IdUsuarioGenerado int
--declare @Mensaje nvarchar(500)

--exec SP_REGISTRARUSUARIO '123', 'pruebas', 'test@gmail.com', '456', 2, 1, @IdUsuarioGenerado output, @Mensaje output

--select @IdUsuarioGenerado
--select @Mensaje

go

---------- PROCEDIMIENTO ALMACENADO EDITAR USUARIO----------
CREATE PROC SP_MODIFICARUSUARIO (
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

go

--DROP PROCEDURE SP_EDITARUSUARIO; -- Elimina el procedimiento almacenado

---------- EDITAR UN USUARIO ----------
--select * from USUARIO --Me lo agrego anteriormente con el ID "1002"

--declare @Respuesta bit
--declare @Mensaje nvarchar(500)

--exec SP_EDITARUSUARIO 2,'123', 'pruebas 2', 'test@gmail.com', '456', 2, 1, @Respuesta output, @Mensaje output

--select @Respuesta
--select @Mensaje

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

	--Si el usuario esta involucrado en una compra no se puede eliminar
	if exists (select * from COMPRA c
	inner join USUARIO u on u.IdUsuario = c.IdUsuario
	where u.IdUsuario = @IdUsuario)
	begin
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porue el usuario se encuentra relacionado a una COMPRA\n'
	end

	--Si el usuario esta involucrado en una venta no se puede eliminar
	if exists (select * from VENTA v
	inner join USUARIO u on u.IdUsuario = v.IdUsuario
	where u.IdUsuario = @IdUsuario)
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

go

-------------------------------------------------------------------------------- VIDEO 8 --------------------------------------------------------------------------------

---------- PROCEDIMIENTO ALMACENADO GUARDAR CATEGORIA----------
create proc SP_REGISTRARCATEGORIA (
	@Descripcion nvarchar(50),
	@Estado bit,
	@Resultado int output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 0
	--set @Mensaje = ''
	if not exists (select * from CATEGORIA where Descripcion = @Descripcion)
	begin
		insert into CATEGORIA(Descripcion, Estado) values (@Descripcion, @Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set	@Mensaje = 'No se puede repetir la descripcion de una caterogria'
end

go

---------- PROCEDIMIENTO ALMACENADO EDITAR CATEGORIA----------
create procedure SP_EDITARCATEGORIA (
	@IdCategoria int,
	@Descripcion nvarchar(50),
	@Estado bit,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 1
	--set @Mensaje = ''
	if not exists (select * from CATEGORIA where Descripcion = @Descripcion and IdCategoria != @IdCategoria)
		update CATEGORIA set
		Descripcion = @Descripcion,
		Estado = @Estado
		where IdCategoria = @IdCategoria
	else
	begin
		set @Resultado = 0
		set	@Mensaje = 'No se puede repetir la descripcion de una caterogria'
	end
end

go

---------- PROCEDIMIENTO ALMACENADO ELIMINAR CATEGORIA----------
create procedure SP_ELIMINARCATEGORIA (
	@IdCategoria int,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 1
	if not exists (
		select * from CATEGORIA c
		inner join PRODUCTO p on p.IdCategoria = c.IdCategoria
		where c.IdCategoria = @IdCategoria
	)
	begin
		delete top(1) from CATEGORIA where IdCategoria = @IdCategoria
	end
	else
	begin
		set @Resultado = 0
		set @Mensaje = 'La categoria se encuentra relacionada a un producto'
	end
end

--Para guardar un cambio en el procedimiento almacenado se coloca ALTER PROC.... y los cambios hechos dentro del procedimiento almacenado

---------- INSERTS ----------
insert into CATEGORIA (Descripcion, Estado) values ('Colores', 1);
insert into CATEGORIA (Descripcion, Estado) values ('Masillas', 1);
insert into CATEGORIA (Descripcion, Estado) values ('Colores', 1);

-------------------------------------------------------------------------------- VIDEO 9 --------------------------------------------------------------------------------
create proc SP_REGISTRARPRODUCTO (
@Codigo nvarchar(20),
@Nombre nvarchar(30),
@Descripcion nvarchar(30),
@IdCategoria int,
@Estado bit,
@Resultado int output,
@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 0
	if not exists (select * from PRODUCTO where Codigo = @Codigo)
	begin
		insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria, Estado) values (@Codigo, @Nombre, @Descripcion, @IdCategoria, @Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'Ya existe un producto con el mismo codigo'
end

go

create procedure SP_MODIFICARPRODUCTO (
	@IdProducto int,
	@Codigo nvarchar(20),
	@Nombre nvarchar(30),
	@Descripcion nvarchar(30),
	@IdCategoria int,
	@Estado bit,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 1
	if not exists (select * from PRODUCTO where Codigo = @Codigo and IdProducto != @IdProducto)
		update PRODUCTO set
		Codigo = @Codigo,
		Nombre = @Nombre,
		Descripcion = @Descripcion,
		IdCategoria = @IdCategoria,
		Estado = @Estado
		where IdProducto = @IdProducto
	else
	begin
		set @Resultado = 0
		set @Mensaje = 'Ya existe un producto con el mismo codigo'
	end
end

go

create proc SP_ELIMINARPRODUCTO (
@IdProducto int,
@Respuesta bit output,
@Mensaje nvarchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	if exists (select * from DETALLE_COMPRA dc
	inner join PRODUCTO p on p.IdProducto = dc.IdProducto
	where p.IdProducto = @IdProducto
	)
	begin
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una COMPRA\n'
	end

	if exists (select * from DETALLE_VENTA dv
	inner join PRODUCTO p on p.IdProducto = dv.IdProducto
	where p.IdProducto = @IdProducto
	)
	begin
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacioado a una VENTA\n'
	end

	if (@pasoreglas = 1)
	begin
		delete from PRODUCTO where IdProducto = @IdProducto
		set @Respuesta = 1
	end
end

select IdProducto, Codigo, Nombre, p.Descripcion, c.IdCategoria, c.Descripcion[DescripcionCategoria], Stock, PrecioCompra, PrecioVenta, p.Estado from PRODUCTO p
inner join CATEGORIA c on c.IdCategoria = p.IdCategoria

select * from PRODUCTO;

select * from CATEGORIA;

insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('101010', 'Wanda 800 Clear VHS', '1L', 3);

-------------------------------------------------------------------------------- VIDEO 11 --------------------------------------------------------------------------------
create proc SP_REGISTRARCLIENTE (
	@Documento nvarchar(50),
	@NombreCompleto nvarchar(50),
	@Correo nvarchar(50),
	@Telefono nvarchar(50),
	@Estado bit,
	@Resultado int output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 0
	declare @IDPERSONA int
	if not exists (select * from CLIENTE where Documento = @Documento)
	begin
		insert into CLIENTE(Documento, NombreCompleto, Correo, Telefono, Estado)
		values (@Documento, @NombreCompleto, @Correo, @Telefono, @Estado)

		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'El numero de documento ya existe'
end

go

create proc SP_MODIFICARCLIENTE (
	@IdCliente int,
	@Documento nvarchar(50),
	@NombreCompleto nvarchar(50),
	@Correo nvarchar(50),
	@Telefono nvarchar(50),
	@Estado bit,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 1
	declare @IDPERSONA int
	if not exists (select * from CLIENTE where Documento = @Documento and IdCliente != @IdCliente)
	begin
		update CLIENTE set
		Documento = @Documento,
		NombreCompleto = @NombreCompleto,
		Correo = @Correo,
		Telefono = @Telefono,
		Estado = @Estado
		where IdCliente = @IdCliente
	end
	else
	begin
		set @Resultado = 0
		set @Mensaje = 'El numero de documento ya existe'
	end
end

select IdCliente, Documento, NombreCompleto, Correo, Telefono, Estado from CLIENTE;

-------------------------------------------------------------------------------- VIDEO 12 --------------------------------------------------------------------------------
create proc SP_REGISTRARPROVEEDOR (
	@Documento nvarchar(50),
	@RazonSocial nvarchar(50),
	@Correo nvarchar(50),
	@Telefono nvarchar(50),
	@Estado bit,
	@Resultado int output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 0
	declare @IDPERSONA int
	if not exists (select * from PROVEEDOR where Documento = @Documento)
	begin
		insert into PROVEEDOR (Documento, RazonSocial, Correo, Telefono, Estado)
		values (@Documento, @RazonSocial, @Correo, @Telefono, @Estado)

		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'El numero de documento ya existe'
end

go

create proc SP_MODIFICARPROVEEDOR (
	@IdProveedor int,
	@Documento nvarchar(50),
	@RazonSocial nvarchar(50),
	@Correo nvarchar(50),
	@Telefono nvarchar(50),
	@Estado bit,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 1
	declare @IDPERSONA int
	if not exists (select * from PROVEEDOR where Documento = @Documento and IdProveedor != @IdProveedor)
	begin
		update PROVEEDOR set
		Documento = @Documento,
		RazonSocial = @RazonSocial,
		Correo = @Correo,
		Telefono = @Telefono,
		Estado = @Estado
		where IdProveedor = @IdProveedor
	end
	else
	begin
		set @Resultado = 0
		set @Mensaje = 'El numero de documento ya existe'
	end
end

go

create proc SP_ELIMINARPROVEEDOR (
	@IdProveedor int,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 1
	if not exists (
	select * from PROVEEDOR p
	inner join COMPRA c on p.IdProveedor = c.IdProveedor
	where p.IdProveedor = @IdProveedor
	)
	begin
		delete top(1) from PROVEEDOR where IdProveedor = @IdProveedor
	end
	else
	begin
		set @Resultado = 0
		set @Mensaje = 'El proveedor se encuentra relacionado a una compra'
	end
end

-------------------------------------------------------------------------------- VIDEO 13 --------------------------------------------------------------------------------
create table NEGOCIO (
	IdNegocio int primary key,
	Nombre nvarchar(60),
	RUC nvarchar(60),
	Direccion nvarchar(60),
	Logo varbinary(max) NULL,
);

insert into NEGOCIO (IdNegocio, Nombre, RUC, Direccion) values (1, 'Servicio De Color', '101010', 'Gaboto 2060');

select IdNegocio, Nombre, RUC, Direccion from NEGOCIO where IdNegocio = 1;

select Logo from NEGOCIO where IdNegocio = 1;

select * from NEGOCIO;

select Logo from NEGOCIO where IdNegocio = 1;

-------------------------------------------------------------------------------- VIDEO 15 --------------------------------------------------------------------------------
create type [dbo].[EDetalle_Compra] as table (
	[IdProducto] int NULL,
	[PrecioCompra] decimal(18,2) NULL,
	[PrecioVenta] decimal(18,2) NULL,
	[Cantidad] int NULL,
	[MontoTotal] decimal(18,2) NULL
);

--Codigo estudiandote lo definio originalmente como EDetalle_Compra
EXEC sp_rename '[dbo].[EDetalle_Compra]', 'EDETALLE_COMPRA'; --Permite cambiarle el nombre

go

create procedure SP_REGISTRARCOMPRA (
	@IdUsuario int,
	@IdProveedor int,
	@TipoDocumento nvarchar(500),
	@NumeroDocumento nvarchar(500),
	@MontoTotal decimal(18,2),
	@DetalleCompra [EDETALLE_COMPRA] readonly,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	begin try

		declare @IdCompra int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro

			insert into COMPRA(IdUsuario, IdProveedor, TipoDocumento,NumeroDocumento,MontoTotal)
			values (@IdUsuario, @IdProveedor, @TipoDocumento, @NumeroDocumento, @MontoTotal)

			set @IdCompra = SCOPE_IDENTITY()

			insert into DETALLE_COMPRA(IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal)
			select @IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal from @DetalleCompra

			update p set p.Stock = p.Stock + dc.Cantidad,
			p.PrecioCompra = dc.PrecioCompra,
			p.PrecioVenta = dc.PrecioVenta
			from PRODUCTO p
			inner join @DetalleCompra dc on dc.IdProducto = p.IdProducto

		commit transaction registro

	end try
	begin catch

		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()

		rollback transaction registro

	end catch

end

-------------------------------------------------------------------------------- VIDEO 16 --------------------------------------------------------------------------------
select count(*) + 1 from COMPRA;

select * from COMPRA where NumeroDocumento = '00001';
select * from DETALLE_COMPRA where IdCompra = 1;

-------------------------------------------------------------------------------- VIDEO 17 --------------------------------------------------------------------------------
select c.IdCompra,
u.NombreCompleto,
pr.Documento, pr.RazonSocial,
c.TipoDocumento, c.NumeroDocumento, c.MontoTotal, convert(char(10),c.FechaRegistro,103)[FechaRegistro]
from COMPRA c
inner join USUARIO u on u.IdUsuario = c.IdUsuario
inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
where c.NumeroDocumento = '00001'

select p.Nombre,
dc.PrecioCompra, dc.Cantidad, dc.MontoTotal
from DETALLE_COMPRA dc
inner join PRODUCTO p on p.IdProducto = dc.IdProducto
where dc.IdCompra = 1

-------------------------------------------------------------------------------- VIDEO 19 --------------------------------------------------------------------------------
create type [dbo].[EDETALLE_VENTA] as table (
	[IdProducto] int NULL,
	[PrecioVenta] decimal(18,2) NULL,
	[Cantidad] int NULL,
	[SubTotal] decimal(18,2) NULL
);

create procedure SP_REGISTRARVENTA (
	@IdUsuario int,
	@TipoDocumento nvarchar(500),
	@NumeroDocumento nvarchar(500),
	@DocumentoCliente nvarchar(500),
	@NombreCliente nvarchar(500),
	@MontoPago decimal(18,2),
	@MontoCambio decimal(18,2),
	@MontoTotal decimal(18,2),
	@DetalleVenta [EDETALLE_VENTA] readonly,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	begin try
		declare @IdVenta int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro

			insert into VENTA(IdUsuario, TipoDocumento, NumeroDocumento, DocumentoCliente, NombreCliente, MontoPago, MontoCambio, MontoTotal)
			values (@IdUsuario, @TipoDocumento, @NumeroDocumento, @DocumentoCliente, @NombreCliente, @MontoPago, @MontoCambio, @MontoTotal)

			set @IdVenta = SCOPE_IDENTITY()

			insert into DETALLE_VENTA(IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal)
			select @IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal from @DetalleVenta

		commit transaction registro
		
	end try
	begin catch
			set @Resultado = 0
			set @Mensaje = ERROR_MESSAGE()
			rollback transaction registro
	end catch
end

select count(*) + 1 from VENTA

select * from VENTA where NumeroDocumento = '00001';
select * from DETALLE_VENTA where IdVenta = 1;

-------------------------------------------------------------------------------- VIDEO 20 --------------------------------------------------------------------------------
select v.IdVenta, u.NombreCompleto,
v.DocumentoCliente, v.NombreCliente,
v.TipoDocumento, v.NumeroDocumento,
v.MontoPago, v.MontoCambio, v.MontoTotal,
convert(char(10),v.FechaRegistro,103)[FechaRegistro]
from VENTA v
inner join USUARIO u on u.IdUsuario = v.IdUsuario
where v.NumeroDocumento = '00001'

select p.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal from DETALLE_VENTA dv
inner join PRODUCTO p on p.IdProducto = dv.IdProducto
where dv.IdVenta = 1