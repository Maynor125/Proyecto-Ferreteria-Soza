create database Ferreteria
go

use Ferreteria
go

Create Table Categoria
(
Id_Categoria Int Identity Primary Key,
Descripcion Varchar(50) Not Null
)
Go
select*from Articulo
insert into Categoria values('Carpinteria')
insert into Categoria values('Construccion')
select*from Categoria

Create table Unidad_Medida
(
Id_Unidad int identity primary key
,Nombre varchar(40) not null
)
Go

insert into Unidad_Medida values ('Unidades')
insert into Unidad_Medida values ('Libras')


Create Table Articulo
(Id_Articulo Int Identity Primary Key,
Id_Categoria Int Not Null References Categoria,
Nombre Varchar(50) Not Null,
Marca Varchar(50),
Id_Unidad int not null References Unidad_Medida,
Cantidad Int Not Null,
PrecioCompra Decimal(6,2) Not Null,
PrecioVenta Decimal(6,2) Not Null,
Imagen image
)
Go
Select Id_Articulo,Nombre,PrecioVenta,Marca,Imagen from Articulo
select*from Unidad_Medida
drop table Articulo

--Procedimiento almacenado.
Create Proc ListarProductos
As Begin
	Select a.Id_Articulo,b.Descripcion,a.Nombre,a.Marca,c.Nombre,a.Cantidad,a.PrecioCompra,a.PrecioVenta
	From Articulo a,Categoria b,Unidad_Medida c where a.Id_Categoria=b.Id_Categoria and 
	a.Id_Unidad=c.Id_Unidad
End
go

Create procedure Mostrarproductos
as
Select Nombre,PrecioVenta,Marca,Imagen from Articulo
go
MostrarProductos

drop procedure ListarProductos

Create Proc ListarCategoria
As Begin
	Select Descripcion from Categoria
End
go
 ListarCategoria

Create Proc RegistrarArticulo
@Id_Categoria Int,
@Nombre Varchar(50),
@Marca Varchar(50),
@Unidad int,
@Cantidad Int,
@PrecioCompra Decimal(6,2),
@PrecioVenta Decimal(6,2),
@Imagen image,
@Mensaje varchar(50) Out
As Begin
	If(Exists(Select * From Articulo Where Nombre=@Nombre And Marca=@Marca))
		Set @Mensaje='Este Producto ya ha sido Registrado.'
		else if ( Exists( select * from Articulo where Id_Categoria != @Id_Categoria))
		Set @Mensaje='La categoria no existe.'
		else if( Exists( select * from Articulo where Id_Unidad != @Unidad))
		set @Mensaje='La unidad de medida no existe.'
	Else Begin
		Insert Articulo Values(@Id_Categoria,@Nombre,@Marca,@Unidad,@Cantidad,@PrecioCompra,@PrecioVenta,@Imagen)
		Set @Mensaje='Registrado Correctamente.'
	End
End
Go

insert into Articulo values( 1,'Martillo 30','Truper',1,30,200,260, (select *from openrowset (bulk 'C:\Users\maynor\OneDrive\Escritorio\OIP.jfif' ,single_blob)as Imagen)  )
insert into Articulo values( 1,'Serrucho','',1,30,200,260,'')
insert into Articulo values( 1,'Tenazas','',1,56,70,140)
ListarProductos

select*from Articulo 
Select*from Categoria


create procedure Listar_Categorias
as
 select Descripcion from Categoria
go

Listar_Categorias