Create database Abmclientes;
Use Abmclientes;

CREATE TABLE Clientes (
    ID INT PRIMARY KEY identity(1,1) ,
    Nombre NVARCHAR(50),
    Apellido NVARCHAR(50),
    Email NVARCHAR(100),
    Telefono NVARCHAR(15),
    Direccion NVARCHAR(100),
    Ciudad NVARCHAR(50),
    Pais NVARCHAR(50),
    CodigoPostal NVARCHAR(10),
    FechaRegistro DATE
);


select * from Clientes

