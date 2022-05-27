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

/*Creacion de la tabla Unidades de medidas.*/
Create table Unidad_Medida
(
Id_Unidad int auto_increment 
,Nombre varchar(40) not null
,primary key(Id_Unidad)
)engine=innoDB;

/*Creacion de la tabla Articulos.*/
Create Table Articulo
(Id_Articulo Int auto_increment,
Id_Categoria Int Not Null References Categoria,
Nombre Varchar(50) Not Null,
Marca Varchar(50),
Id_Unidad int not null References Unidad_Medida,
Cantidad Int Not Null,
PrecioCompra Decimal(6,2) Not Null,
PrecioVenta Decimal(6,2) Not Null,
Imagen blob,
 Primary Key(Id_Articulo)
)engine=innoDB;

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
drop table  Empleado;
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


alter table Detalle_Entrada_A
add constraint fk_EAEA
foreign key (Id_Entrada_A)
references Entrada_Articulos(Id_Entrada_A) on delete cascade on update cascade;

alter table Detalle_Entrada_A
add constraint fk_EAA
foreign key (Id_Producto)
references Articulo(Id_Articulo) on delete cascade on update cascade;