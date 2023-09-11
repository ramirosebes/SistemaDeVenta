select * from USUARIO;

select * from ROL;

select * from PERMISO;

--insert into ROL (descripcion)
--	values('ADMINISTRADOR');

--insert into ROL (descripcion)
--	values('EMPLEADO');

--insert into USUARIO(documento,	nombreCompleto, correo, clave, idRol)
--	values('101010', 'ADMIN', '@GMAIL.COM', '123', 1);

insert into USUARIO(documento,	nombreCompleto, correo, clave, idRol)
	values('20', 'EMPLEADO', '@GMAIL.COM', '123', 2);

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