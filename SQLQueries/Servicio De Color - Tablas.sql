--create database DB_SERVICIO_DE_COLOR;
--use DB_SERVICIO_DE_COLOR;

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