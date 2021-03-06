use ferreteria_s;
/*Creacion de la tabla Usuarios.*/
create table Usuario
(
  Id_User int auto_increment,
  Nombre_Usuario varchar(30),
  Contraseña varchar(10),
  primary key(Id_User)
)engine=innoDB;

/*Creacion de la tabla categorias.*/
Create Table Categoria
(
Id_Categoria Int auto_increment,
Descripcion Varchar(50) Not Null,
Primary Key(Id_Categoria)
)engine=innoDB;

select*from categoria;
insert into categoria values(1,'Carpinteria');
insert into categoria (Descripcion) values('Construccion');



/*Creacion de la tabla Unidades de medidas.*/
Create table Unidad_Medida
(
Id_Unidad int auto_increment 
,Nombre varchar(40) not null
,primary key(Id_Unidad)
)engine=innoDB;
insert into unidad_medida (Nombre) values ('Libras');
insert into unidad_medida (Nombre) values ('Individual');
insert into unidad_medida (Nombre) values ('LLardas');
/*Creacion de la tabla Articulos.*/
Create Table Articulo
(Id_Articulo Int auto_increment,
Id_Categoria Int Not Null ,
Nombre Varchar(50) Not Null,
Marca Varchar(50),
Id_Unidad int not null,
Cantidad Int Not Null,
PrecioCompra Decimal(6,2) Not Null,
PrecioVenta Decimal(6,2) Not Null,
Imagen blob,
 Primary Key(Id_Articulo)
)engine=innoDB;
alter table Articulo add lugar varchar(20);
/*Creacion de la tabla Empleados.*/
Create Table Empleado
(Id_Empleado Int auto_increment,
Cedula Char(16) Not Null,
Apellidos Varchar(30) Not Null,
Nombres Varchar(30) Not Null,
Sexo Char(1) Not Null,
Ciudad Varchar(20)Not Null,
Barrio Varchar(30)Not Null,
Direccion Varchar(100) Not Null,
Primary Key(ID_Empleado)
)engine=innoDB;
alter table Empleado drop column Barrio;
alter table Empleado add Telefono varchar(15);

/*Creacion de la tabla Clientes.*/
Create Table Cliente
(Id_Cliente Int auto_increment ,
Cedula Char(16) Not Null,
Apellidos Varchar(50) Not Null,
Nombres Varchar(50) Not Null,
Sexo Char(1) Not Null,
Ciudad Varchar(20)Not Null,
Barrio Varchar(30)Not Null,
Direccion Varchar(100),
Telefono Varchar(8),
Primary Key(Id_Cliente)
)engine=innoDB;
select*from articulo;
/*Creacion de la tabla Ventas*/
Create Table Venta
(Id_Venta Int auto_increment,
Id_Empleado int not null References Empleado,
Id_Cliente Int Not Null References Cliente,
FechaVenta Date Not Null,
Total Decimal(6,2) Not Null,
Primary Key (Id_Venta)
)engine=innoDB;


/*Creacion de la tabla Detalle de las ventas.*/
Create Table DetalleVenta
(Id_DetalleVenta Int auto_increment,
Id_Producto Int Not Null,
Id_Venta Int Not Null,
Cantidad Int Not Null,
Igv Decimal(6,2) Not Null,
SubTotal Decimal(6,2) Not Null,
primary key(Id_DetalleVenta)
)engine=innoDB;

/*Creacion de la tabla Proveedores*/
Create table Proveedores
(
  Id_Proveedor int auto_increment,
  Nombre_Proveedor varchar(30) not null,
  Pais_Proveedor varchar(20) not null,
  Telefono varchar(8) not null,
  Correo varchar(30),
  primary key(Id_Proveedor)
)engine=innoDB;

/*Creacion de la tabla Entrada de articulos.*/
create table Entrada_Articulos
(
Id_Entrada_A Int auto_increment,
Id_Proveedor Int Not Null ,
Fecha Date Not Null,
Total Decimal(6,2) Not Null,
Primary Key (Id_Entrada_A)
)engine=innoDB;

/*Creacion de la tabla Detalle_Entrada_Articulos.*/
Create Table Detalle_Entrada_A
(Id_Detalle_Entrada Int auto_increment,
Id_Producto Int Not Null References Producto,
Id_Entrada_A Int Not Null References Entrada_Articulos,
Cantidad Int Not Null,
Igv Decimal(6,2) Not Null,
SubTotal Decimal(6,2) Not Null,
primary key(Id_Detalle_Entrada)
)engine=innoDB;

/*Creacion de las llaves foraneas*/
alter table Articulo
add constraint fk_AC
foreign key (Id_Categoria)
references Categoria(Id_Categoria) on delete cascade on update cascade;

alter table Articulo
add constraint fk_AUM
foreign key (Id_Unidad)
references Unidad_Medida(Id_Unidad) on delete cascade on update cascade;

alter table Venta
add constraint fk_VC
foreign key (Id_Cliente)
references Cliente(Id_Cliente) on delete cascade on update cascade;

alter table Venta
add constraint fk_VE
foreign key (Id_Empleado)
references Empleado(Id_Empleado) on delete cascade on update cascade;

alter table DetalleVenta
add constraint fk_DVV
foreign key (Id_Venta)
references Venta(Id_Venta) on delete cascade on update cascade;

alter table DetalleVenta
add constraint fk_DVA
foreign key (Id_Producto)
references Articulo(Id_Articulo) on delete cascade on update cascade;

alter table Entrada_Articulos
add constraint fk_EAP
foreign key (Id_Proveedor)
references Proveedores(Id_Proveedor) on delete cascade on update cascade;



Create Procedure ListarCategoria
()	
Select * from Categoria;

Create Procedure ListarUnidad
()	
Select * from unidad_medida;

call ListarCategoria;
drop procedure ListarProductos;

Create Procedure ListarProductos
()	
Select a.Id_Articulo,c.Descripcion,a.Nombre,a.Marca,u.Nombre,a.Cantidad,a.PrecioCompra,a.PrecioVenta from articulo a,Categoria c,unidad_medida u 
where c.Id_Categoria=a.Id_Categoria and u.Id_Unidad=a.Id_Unidad;

call ListarProductos;

alter table Detalle_Entrada_A
add constraint fk_EAEA
foreign key (Id_Entrada_A)
references Entrada_Articulos(Id_Entrada_A) on delete cascade on update cascade;

alter table Detalle_Entrada_A
add constraint fk_EAA
foreign key (Id_Producto)
references Articulo(Id_Articulo) on delete cascade on update cascade;

/*Procedimiento almacenado para insertar productos*/
Create Procedure RegistrarArticulo
(
Id_Categoria Int,
Nombre Varchar(50),
Marca Varchar(50),
Unidad int,
Cantidad Int,
PrecioCompra Decimal(6,2),
PrecioVenta Decimal(6,2),
Imagen blob,
lugar varchar(20)
)
Insert Articulo(Id_Categoria,Nombre,Marca,Id_Unidad,Cantidad,PrecioCompra,PrecioVenta,Imagen,lugar)
 Values(Id_Categoria,Nombre,Marca,Unidad,Cantidad,PrecioCompra,PrecioVenta,Imagen,lugar);
drop procedure ActualizarArticulo;
Create Procedure ActualizarArticulo
(
Id_A int,
Id_Categoria Int,
Nombre Varchar(50),
Marca Varchar(50),
Unidad int,
Cantidad Int,
PrecioCompra Decimal(6,2),
PrecioVenta Decimal(6,2),
Imagen blob,
lugar varchar(30)
)
update articulo set Id_Categoria=Id_Categoria ,Nombre=Nombre,Marca=Marca,Id_Unidad=Unidad,Cantidad=Cantidad,
PrecioCompra=PrecioCompra,PrecioVenta=PrecioVenta,Imagen=Imagen,lugar=lugar
where Id_Articulo=Id_A;


create procedure EliminarArticulo
(
Id_A int
)
delete from articulo where Id_Articulo= Id_A;
drop procedure EliminarArticulo;
select*from articulo;

create procedure IngresarVenta
(
 Id_Empleado int,
 Id_C int,
 Fecha date,
 Total Decimal(6,2)
)
insert venta(Id_Empleado,Id_Cliente,FechaVenta,Total) 
values (Id_V,Id_Empleado,Id_C,Fecha,Total);

create procedure IngresarDetalleVenta
(
 Id_A int,
 Id_V int,
 cantidad int,
 Ivg Decimal(6,2),
 SubTotal Decimal(6,2),
 Stock Int
)
set Stock=(Select Cantidad From articulo Where Id_Articulo=Id_A);
insert DetalleVenta(Id_Producto,Id_Venta,Cantidad,Igv,SubTotal) 
values (Id_A,Id_V,cantidad,Ivg,SubTotal);
update Articulo set Cantidad=Stock-cantidad where Id_Articulo=Id_A;

drop procedure IngresarDetalleVenta;

create procedure AgregarCategoria
(
 Nombrecategoria varchar(40)
)
insert Categoria(Descripcion) value(NombreCategoria);
create procedure ActualizarCategoria
(
id int,
 Nombrecategoria varchar(40)
)
update Categoria set Descripcion=Nombrecategoria where Id_Categoria=id;
create procedure EliminarCategoria
(
in id int
)
delete from Categoria where Id_Categoria=id;
drop procedure EliminarCategoria

DELIMITER //
Create procedure Buscar_Articulo (
IN dato varchar(50)
, in ind integer
)
begin
if (ind = 0)
then Select a.Id_Articulo,c.Descripcion,a.Nombre,a.Marca,u.Nombre,a.Cantidad,a.PrecioCompra,a.PrecioVenta from articulo a,Categoria c,unidad_medida u 
where c.Id_Categoria=a.Id_Categoria and u.Id_Unidad=a.Id_Unidad  and a.Nombre like CONCAT('%',dato,'%');
else if (ind = 1)
then Select a.Id_Articulo,c.Descripcion,a.Nombre,a.Marca,u.Nombre,a.Cantidad,a.PrecioCompra,a.PrecioVenta from articulo a,Categoria c,unidad_medida u 
where c.Id_Categoria=a.Id_Categoria and u.Id_Unidad=a.Id_Unidad and a.Marca like  CONCAT('%',dato,'%');
else if (ind = 2)
then Select a.Id_Articulo,c.Descripcion,a.Nombre,a.Marca,u.Nombre,a.Cantidad,a.PrecioCompra,a.PrecioVenta from articulo a,Categoria c,unidad_medida u 
where c.Id_Categoria=a.Id_Categoria and u.Id_Unidad=a.Id_Unidad  and c.Descripcion like CONCAT('%',dato,'%');
end if;
end if;
end if;
end //
DELIMITER ;

select*from articulo;

create procedure IngresarEmpleado
(
cedula varchar(20),
nombres varchar(40),
apellidos varchar(40),
sexo char(1),
direccion varchar(50),
telefono varchar(50)
)
insert Empleado(Cedula,Apellidos,Nombres,Sexo,Direccion,Telefono)
value (cedula,apellidos,nombres,sexo,direccion,telefono);


create procedure ActualizarEmpleado
(
id_e int,
cedula varchar(20),
nombres varchar(40),
apellidos varchar(40),
sexo char(1),
direccion varchar(50),
telefono varchar(50)
)
update Empleado set Cedula=cedula,Apellidos=apellidos,Nombres=nombres,Sexo=sexo,Direccion=direccion,
Telefono=telefono where Id_Empleado=id_e;

create procedure eliminarempleado
(
id int
)
delete from Empleado where Id_Empleado=id;

create procedure MostrarEmpleado
(
)
select*From Empleado;
select Id_Articulo,Nombre,Cantidad from Articulo where Cantidad<6;
select*from Articulo;
create procedure MostrarProFerreteria
(
)
select a.Id_Articulo,c.Descripcion,a.Nombre,a.Marca,u.Nombre,a.Cantidad,a.PrecioCompra,a.PrecioVenta from articulo a,Categoria c,unidad_medida u 
where c.Id_Categoria=a.Id_Categoria and u.Id_Unidad=a.Id_Unidad  and lugar="Ferreteria";

create procedure MostrarProAlmacen
(
)
select a.Id_Articulo,c.Descripcion,a.Nombre,a.Marca,u.Nombre,a.Cantidad,a.PrecioCompra,a.PrecioVenta from articulo a,Categoria c,unidad_medida u 
where c.Id_Categoria=a.Id_Categoria and u.Id_Unidad=a.Id_Unidad  and lugar="Almacen";


DELIMITER //
Create procedure Buscar_ArticuloF(
IN dato varchar(50)
, in ind integer
)
begin
if (ind = 0)
then Select a.Id_Articulo,c.Descripcion,a.Nombre,a.Marca,u.Nombre,a.Cantidad,a.PrecioCompra,a.PrecioVenta from articulo a,Categoria c,unidad_medida u 
where c.Id_Categoria=a.Id_Categoria and u.Id_Unidad=a.Id_Unidad and a.lugar="Ferreteria"  and a.Nombre like CONCAT('%',dato,'%');
else if (ind = 1)
then Select a.Id_Articulo,c.Descripcion,a.Nombre,a.Marca,u.Nombre,a.Cantidad,a.PrecioCompra,a.PrecioVenta from articulo a,Categoria c,unidad_medida u 
where c.Id_Categoria=a.Id_Categoria and u.Id_Unidad=a.Id_Unidad and a.lugar="Ferreteria"  and a.Marca like  CONCAT('%',dato,'%');
else if (ind = 2)
then Select a.Id_Articulo,c.Descripcion,a.Nombre,a.Marca,u.Nombre,a.Cantidad,a.PrecioCompra,a.PrecioVenta from articulo a,Categoria c,unidad_medida u 
where c.Id_Categoria=a.Id_Categoria and u.Id_Unidad=a.Id_Unidad and a.lugar="Ferreteria"  and  c.Descripcion like CONCAT('%',dato,'%');
end if;
end if;
end if;
end //
DELIMITER ;
insert into Unidad_Medida(Nombre)value(Individual)
DELIMITER //
Create procedure Buscar_ArticuloA(
IN dato varchar(50)
, in ind integer
)
begin
if (ind = 0)
then Select a.Id_Articulo,c.Descripcion,a.Nombre,a.Marca,u.Nombre,a.Cantidad,a.PrecioCompra,a.PrecioVenta from articulo a,Categoria c,unidad_medida u 
where c.Id_Categoria=a.Id_Categoria and u.Id_Unidad=a.Id_Unidad and a.lugar="Almacen"  and a.Nombre like CONCAT('%',dato,'%');
else if (ind = 1)
then Select a.Id_Articulo,c.Descripcion,a.Nombre,a.Marca,u.Nombre,a.Cantidad,a.PrecioCompra,a.PrecioVenta from articulo a,Categoria c,unidad_medida u 
where c.Id_Categoria=a.Id_Categoria and u.Id_Unidad=a.Id_Unidad and a.lugar="Almacen"  and a.Marca like  CONCAT('%',dato,'%');
else if (ind = 2)
then Select a.Id_Articulo,c.Descripcion,a.Nombre,a.Marca,u.Nombre,a.Cantidad,a.PrecioCompra,a.PrecioVenta from articulo a,Categoria c,unidad_medida u 
where c.Id_Categoria=a.Id_Categoria and u.Id_Unidad=a.Id_Unidad and a.lugar="Almacen"  and  c.Descripcion like CONCAT('%',dato,'%');
end if;
end if;
end if;
end //
DELIMITER ;