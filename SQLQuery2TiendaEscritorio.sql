CREATE TABLE Cliente
(
 ClienteCodigoId INT PRIMARY KEY,
  NombreCliente Nvarchar (50),
  ApellidoCliente Nvarchar(50),
  CedulaCliente INT,
  DireccionCliente Nvarchar(50),
  TelefonoCliente int
)
GO

CREATE TABLE Empleado
(
  EmpleadoCodigoId INT PRIMARY KEY,
  NombreEmpleado Nvarchar (50),
  ApellidoEmpleado Nvarchar(50),
  CedulaEmpleado INT,
  TelefonoEmpleado int
)
GO


CREATE TABLE Producto
(
  CodigoPId int PRIMARY KEY,
  NombreProducto Nvarchar(50),
  ValorProducto int,
  cantidad int
)
GO


CREATE TABLE Venta
(
 VentaProductoId Nvarchar(50) PRIMARY KEY,
 CantidadVenta int,
 TotalVenta int,
 FechaVenta DATETIME,
 ClienteCoId int,
 EmpleadoId int,
  CodigoPId int,
 CONSTRAINT  ClienteCoId_FK FOREIGN KEY (ClienteCoId) REFERENCES Cliente (ClienteCodigoId),
  CONSTRAINT  EmpleadoId_FK FOREIGN KEY (EmpleadoId) REFERENCES Empleado (EmpleadoCodigoId),
  CONSTRAINT  FK_producto_Venta FOREIGN KEY ( CodigoPId) REFERENCES Producto (CodigoPId)
)
GO


CREATE TABLE Provedor
(
ProvedorCodigoId int PRIMARY KEY,
NombreProvedor Nvarchar(50),
ApellidoProvedor Nvarchar(50),
CedulaProvedor int,
)
GO

CREATE TABLE Compra
(
 CompraId int PRIMARY KEY,
 NombreDelProducto Nvarchar(50),
 CantidadCompra int,
 TotalCompraId int,
 FechaCompra DATETIME,
 CodigoPId int,
 ProvedorCodigoId int,
  CONSTRAINT CodigoPId_FK FOREIGN KEY (CodigoPId) REFERENCES Producto (CodigoPId),
  CONSTRAINT ProvedorCodigoId_FK FOREIGN KEY (ProvedorCodigoId) REFERENCES Provedor(ProvedorCodigoId),
 )
GO




use TiendaEscritorio
go
select*from producto
select*from Compra
select*from Cliente
select*from Venta

delete from producto where NombreProducto='a';
delete from producto where NombreProducto='ad';

