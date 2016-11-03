create database sistemaDeVentas

use sistemaDeVentas

create table producto
	(SKU					int not null check (SKU >= 0 and SKU <= 999999),
	descripcion				char(60),
	unidEnInventario		int not null check (unidEnInventario > 0 and unidEnInventario <= 999999),
	costoUnit				numeric(4,2),
	impuesto				numeric(4,2),
	precioVtaUnit			numeric(4,2),
	primary key(SKU))
	
create table condicionPago
	(nombreCondicion		char(40),
	primary key(nombreCondicion))

create table cliente
	(codigoCliente			int not null check (codigoCliente > 0 and codigoCliente <= 9999),
	nombre					char(60),
	direccion				char(180),
	codigoPostal			char(12),
	paisUbic				char(3),
	telefono				int not null check (telefono > 0 and telefono <= 99999999),
	email					char(60),
	fechaInicioR			date,
	limiteCred				numeric(7,0),
	dirEntregaProd			char(180),
	nombreCondicion			char (40),
	primary key(codigoCliente),
	foreign key (nombreCondicion) references condicionPago(nombreCondicion))

create table facturas
	(numFact				int  check (numFact > 0 and numFact <= 99999999),
	fechaFact				date,
	codigoCliente			int not null check (codigoCliente > 0 and codigoCliente <= 9999),
	fechaVencim				date,
	dirEntrega				char (180),
	primary key (numFact),
	foreign key (codigoCliente) references cliente(codigoCliente))

create table personal
	(IDPersonal				int not null check (IDPersonal > 0 and IDPersonal <= 9999),
	puestoTrab				char (4),
	nombre					char (20),
	apellido1				char (20),
	apellido2				char (20),
	fechaNacim				date,
	telefono				int not null check (telefono > 0 and telefono <= 99999999),
	lugarResid				char (60),
	email					char(60),
	IDJefe					int  check (IDJefe > 0 and IDJefe <= 9999),
	fechaIngreso			date,
	fechaRetiro				date,
	primary key (IDPersonal),
	foreign key (IDJefe) references personal(IDPersonal))

create table ctaPorCobrar
	(numFact				int not null check (numFact > 0 and numFact <= 99999999), 
	codigoCliente			int not null check (codigoCliente > 0 and codigoCliente <= 9999),
	totalFactura			numeric(8,2),
	totalPagado				numeric(8,2),
	impTotal				numeric(6,2),
	fechaVencim				date,				
	primary key (numFact,codigoCliente),
	foreign key (numFact) references facturas(numFact),
	foreign key (codigoCliente) references cliente(codigoCliente))


create table pedidos 
	(numPedido				int check (numPedido > 0 and numPedido <= 999999999),
	numFact					int not null check (numFact > 0 and numFact <= 99999999),
	codigoCliente			int not null check (codigoCliente > 0 and codigoCliente <= 9999),
	fechaPedido				date,
	fechaEstimEntrega		date,
	IDPersonal				int not null check (IDPersonal > 0 and IDPersonal <= 9999),
	estado					char (12),
	motivoDescripcion		char (120),
	primary key (numPedido),
	foreign key (codigoCliente) references cliente(codigoCliente),
	foreign key (numFact) references facturas (numFact),
	foreign key (IDPersonal) references personal(IDPersonal))


create table seLeVende
	(codigoCliente			int not null check (codigoCliente > 0 and codigoCliente <= 9999),
	SKU						int not null check (SKU >= 0 and SKU <= 999999),
	primary key (codigoCliente, SKU),
	foreign key (codigoCliente) references cliente(codigoCliente),
	foreign key (SKU) references producto(SKU))


create table adquiere
	(numFact				int not null check (numFact > 0 and numFact <= 99999999),
	SKU						int not null check (SKU >= 0 and SKU <= 999999),
	primary key (numFact, SKU),
	foreign key (numFact) references facturas(numFact),
	foreign key (SKU) references producto(SKU))


create table seObtieneUn
	(numPedido				int check (numPedido > 0 and numPedido <= 999999999),
	SKU						int not null check (SKU >= 0 and SKU <= 999999),
	primary key (numPedido, SKU),
	foreign key (numPedido) references pedidos(numPedido),
	foreign key (SKU) references producto(SKU))

create table detalleProducto_facturas
	(numFact				int not null check (numFact > 0 and numFact <= 99999999),
	numPedido				int check (numPedido > 0 and numPedido <= 999999999),
	SKU						int not null check (SKU >= 0 and SKU <= 999999),
	descripcion				char (60),
	unidFacturadas			int  check (unidFacturadas > 0 and unidFacturadas <= 9999),
	precioUnitVta			numeric(4,2),
	subtotal				numeric(8,2),
	descuento				numeric(7,2),
	impTotal				numeric(6,2),
	precioTotal				numeric(8,2),
	primary key (numFact, numPedido,SKU, unidFacturadas ),
	foreign key (numFact) references facturas(numFact))

create table detalleProducto_pedidos
	(numPedido				int check (numPedido > 0 and numPedido <= 999999999),
	cantPedido				int check (cantPedido > 0 and cantPedido <= 9999),
	precioUnitVta			numeric(4,2),
	descuento				numeric(7,2),
	impVta					numeric(6,2),
	precioTotal				numeric(8,2)
	primary key (numPedido, cantPedido),
	foreign key (numPedido) references pedidos(numPedido))

create table factura_ctaPorCobrar
	(numFact				int not null check (numFact > 0 and numFact <= 99999999),
	codigoCliente			int not null check (codigoCliente > 0 and codigoCliente <= 9999),
	primary key (numFact, codigoCliente),
	foreign key (numFact) references facturas(numFact),
	foreign key (codigoCliente) references cliente (codigoCliente))

	insert into producto  values
	(1,'taladro', 100, 35, 5,39)

	insert into condicionPago values	
	('Pago a 8 dias'),
	('Pago a 30 dias'),
	('Pago a 45 dias'),
	('Pago a 15 dias')

insert into cliente values	
	(1,'Jorge', 'Cartago', '1234','CR',87300510,'jor@gmail.com','2013-01-11',1234567, 'Cartago,','Pago a 15 dias')

insert into facturas values
	(1, '2013-03-11', 1, '2013-03-11','Cartago')

insert into personal values
	(1,'v1','Andres','Mora','Mata','2000-01-11',26891271,'CartagoCR','jorgmail.com',null,'2009-01-11','2012-01-11'),
	(2,'v2','pato','Mora','Mata','2000-01-11',12345,'CartagoCR','cosa@gmail.com',1,'2009-01-11','2012-01-11')

insert into pedidos values
	(1, 1, 1, '2013-03-11', '2013-04-11', 1,'activo','nose')

insert into ctaPorCobrar values
	(1, 1, 23000, 1000, 13,'2013-03-11')