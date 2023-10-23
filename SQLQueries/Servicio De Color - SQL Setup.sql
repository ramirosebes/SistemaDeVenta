create database DB_SERVICIO_DE_COLOR;
use DB_SERVICIO_DE_COLOR;

create table ROL (
	IdRol int primary key identity,
	Descripcion nvarchar(60),
	FechaRegistro datetime default getdate(),
);

create table PERMISO (
	IdPermiso int primary key identity,
	IdRol int references ROL(IdRol),
	NombreMenu nvarchar(100),
	FechaRegistro datetime default getdate(),
);

create table PROVEEDOR (
	IdProveedor int primary key identity,
	Documento nvarchar(50),
	RazonSocial nvarchar(50),
	Correo nvarchar(50),
	Telefono nvarchar(50),
	Estado bit not null default 1,
	FechaRegistro datetime default getdate(),
);

create table CLIENTE (
	IdCliente int primary key identity,
	Documento nvarchar(50),
	NombreCompleto nvarchar(50),
	Correo nvarchar(50),
	Telefono nvarchar(50),
	Estado bit not null default 1,
	FechaRegistro datetime default getdate(),
);

create table USUARIO (
	IdUsuario int primary key identity,
	Documento nvarchar(50),
	NombreCompleto nvarchar(50),
	Correo nvarchar(50),
	Clave nvarchar(50),
	IdRol int references ROL(IdRol),
	Estado bit not null default 1,
	FechaRegistro datetime default getdate(),
);

create table CATEGORIA (
	IdCategoria int primary key identity,
	Descripcion nvarchar(100),
	Estado bit not null default 1,
	FechaRegistro datetime default getdate(),
);

create table PRODUCTO (
	IdProducto int primary key identity,
	Codigo nvarchar(50),
	Nombre nvarchar(50),
	Descripcion nvarchar(50),
	IdCategoria int references CATEGORIA(IdCategoria),
	Stock int not null default 0,
	PrecioCompra decimal(10,2) default 0,
	PrecioVenta decimal(10,2) default 0,
	Estado bit not null default 1,
	FechaRegistro datetime default getdate(),
);

create table COMPRA (
	IdCompra int primary key identity,
	IdUsuario int references USUARIO(IdUsuario),
	IdProveedor int references PROVEEDOR(idProveedor),
	TipoDocumento nvarchar(50),
	NumeroDocumento nvarchar(50),
	MontoTotal decimal (10,2),
	FechaRegistro datetime default getdate(),
);

create table DETALLE_COMPRA (
	IdDetalleCompra int primary key identity,
	IdCompra int references COMPRA(idCompra),
	IdProducto int references PRODUCTO(idProducto),
	PrecioCompra decimal(10,2) default 0,
	PrecioVenta decimal(10,2) default 0,
	Cantidad int,
	MontoTotal decimal(10,2),
	FechaRegistro datetime default getdate(),
);

create table VENTA (
	IdVenta int primary key identity,
	IdUsuario int references USUARIO(IdUsuario),
	TipoDocumento nvarchar(50),
	NumeroDocumento nvarchar(50),
	DocumentoCliente nvarchar(50),
	NombreCliente nvarchar(100),
	MontoPago decimal(10,2),
	MontoCambio decimal (10,2),
	MontoTotal decimal (10,2),
	FechaRegistro datetime default getdate(),
);

create table DETALLE_VENTA (
	IdDetalleVenta int primary key identity,
	IdVenta int references VENTA(idVenta),
	IdProducto int references PRODUCTO(idProducto),
	PrecioVenta decimal(10,2) default 0,
	Cantidad int,
	SubTotal decimal(10,2),
	FechaRegistro datetime default getdate(),
);

create table NEGOCIO (
	IdNegocio int primary key,
	Nombre nvarchar(60),
	RUC nvarchar(60),
	Direccion nvarchar(60),
	Logo varbinary(max) NULL,
);

insert into ROL (descripcion) values('ADMINISTRADOR');
insert into ROL (descripcion) values('EMPLEADO');
insert into USUARIO(documento,	nombreCompleto, correo, clave, idRol) values('101010', 'ADMIN', '@GMAIL.COM', '123', 1);
insert into USUARIO(documento,	nombreCompleto, correo, clave, idRol) values('202020', 'EMPLEADO', '@GMAIL.COM', '456', 2);

go

insert into PERMISO(idRol, nombreMenu) values 
	(1, 'menuUsuarios'),
	(1, 'menuMantenedor'),
	(1, 'menuVentas'),
	(1, 'menuCompras'),
	(1, 'menuClientes'),
	(1, 'menuProveedores'),
	(1, 'menuReportes'),
	(1, 'menuAcercaDe');

go

insert into PERMISO(idRol, nombreMenu) values 
	(2, 'menuVentas'),
	(2, 'menuCompras'),
	(2, 'menuClientes'),
	(2, 'menuProveedores'),
	(2, 'menuAcercaDe');

go

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

go

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

go

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

go

insert into CATEGORIA (Descripcion, Estado) values ('Colores', 1);
insert into CATEGORIA (Descripcion, Estado) values ('Masillas', 1);
insert into CATEGORIA (Descripcion, Estado) values ('Colores', 1);

go

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

go

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

go

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

go

create type [dbo].[EDETALLE_COMPRA] as table (
	[IdProducto] int NULL,
	[PrecioCompra] decimal(18,2) NULL,
	[PrecioVenta] decimal(18,2) NULL,
	[Cantidad] int NULL,
	[MontoTotal] decimal(18,2) NULL
);

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