USE BUFFET_UTN 

CREATE TABLE [BUFFET_UTN].dbo.PROVEEDORES
    (
    NUMERO_PROVEEDOR INT PRIMARY KEY NOT NULL,
    NOMBRE varchar(30),
    DOMICILIO varchar(50),
	LOCALIDAD varchar(80),
    );

CREATE TABLE [BUFFET_UTN].dbo.PRODUCTOS
(
CODIGO_PRODUCTO INT PRIMARY KEY NOT NULL,
NOMBRE varchar(30),
PRECIO float,
DIMENSIONES varchar(20),
);

CREATE TABLE [BUFFET_UTN].dbo.ENVIOS
	(
		NUMERO_PROVEEDOR INT NOT NULL,
		CODIGO_PRODUCTO INT NOT NULL,
		CANTIDAD int NOT NULL,
		FOREIGN KEY (NUMERO_PROVEEDOR) REFERENCES PROVEEDORES(NUMERO_PROVEEDOR),
		FOREIGN KEY (CODIGO_PRODUCTO) REFERENCES PRODUCTOS (CODIGO_PRODUCTO)
		
	);

INSERT INTO PROVEEDORES (NUMERO_PROVEEDOR,NOMBRE,DOMICILIO,LOCALIDAD) VALUES (100,'Perez','Per�n 876','Quilmes')
INSERT INTO PROVEEDORES (NUMERO_PROVEEDOR,NOMBRE,DOMICILIO,LOCALIDAD) VALUES (101,'Gimenez','Mitre 750','Avellaneda')
INSERT INTO PROVEEDORES (NUMERO_PROVEEDOR,NOMBRE,DOMICILIO,LOCALIDAD) VALUES (102,'Aguirre','Boedo 634','Bernal')

INSERT INTO PRODUCTOS (CODIGO_PRODUCTO,NOMBRE,PRECIO,DIMENSIONES) VALUES (1,'Caramelos',1.5,'Chico')
INSERT INTO PRODUCTOS (CODIGO_PRODUCTO,NOMBRE,PRECIO,DIMENSIONES) VALUES (2,'Alfajores',45.89,'Mediano')
INSERT INTO PRODUCTOS (CODIGO_PRODUCTO,NOMBRE,PRECIO,DIMENSIONES) VALUES (3,'Gaseosa',15.80,'Grande')

INSERT INTO ENVIOS (NUMERO_PROVEEDOR,CODIGO_PRODUCTO,CANTIDAD) VALUES (100,1,500)
INSERT INTO ENVIOS (NUMERO_PROVEEDOR,CODIGO_PRODUCTO,CANTIDAD) VALUES (100,2,1500)
INSERT INTO ENVIOS (NUMERO_PROVEEDOR,CODIGO_PRODUCTO,CANTIDAD) VALUES (100,3,100)
INSERT INTO ENVIOS (NUMERO_PROVEEDOR,CODIGO_PRODUCTO,CANTIDAD) VALUES (101,2,55)
INSERT INTO ENVIOS (NUMERO_PROVEEDOR,CODIGO_PRODUCTO,CANTIDAD) VALUES (101,3,225)
INSERT INTO ENVIOS (NUMERO_PROVEEDOR,CODIGO_PRODUCTO,CANTIDAD) VALUES (102,1,600)
INSERT INTO ENVIOS (NUMERO_PROVEEDOR,CODIGO_PRODUCTO,CANTIDAD) VALUES (102,3,300)




