select * from USUARIO;

select * from ROL;

select * from PERMISO;

insert into ROL (descripcion)
	values('ADMINISTRADOR');

insert into USUARIO(documento,	nombreCompleto, correo, clave, idRol)
	values('101010', 'ADMIN', '@GMAIL.COM', '123', 1);