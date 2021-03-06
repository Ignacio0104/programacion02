USE EMPRESA_DB_DOS

CREATE TABLE PUESTOS
(
	ID_PUESTO int primary key,
	NOMBRE varchar(200),
	NIVEL_AUTORIZACION int,
)

CREATE TABLE EMPLEADOS
(
	ID_EMPLEADO int primary key identity,	
	NOMBRE varchar(100),
	APELLIDO varchar(100),
	ID_PUESTO int,
	SALARIO float,
	ESTA_ACTIVO bit,
	FECHA_ALTA date,
	FECHA_BAJA date,
	MAIL varchar(150)
	FOREIGN KEY (ID_PUESTO) REFERENCES PUESTOS(ID_PUESTO)
)

INSERT INTO EMPLEADOS (NOMBRE,APELLIDO,ID_PUESTO,SALARIO,ESTA_ACTIVO,FECHA_ALTA,FECHA_BAJA,MAIL) VALUES
('Leilani','Kinney',1,383946.80, 1,'1996-03-21',NULL, 'lkinney@gmail.com')

INSERT INTO EMPLEADOS (NOMBRE,APELLIDO,ID_PUESTO,SALARIO,ESTA_ACTIVO,FECHA_ALTA,FECHA_BAJA,MAIL) VALUES
('Igor','England',5,283558.85, 1,'2013-03-28',NULL, 'iengland@hotmail.com')

INSERT INTO EMPLEADOS (NOMBRE,APELLIDO,ID_PUESTO,SALARIO,ESTA_ACTIVO,FECHA_ALTA,FECHA_BAJA,MAIL) VALUES
('Maya','Brock',3,164546.09,1,'1993-10-24',NULL, NULL)

INSERT INTO EMPLEADOS (NOMBRE,APELLIDO,ID_PUESTO,SALARIO,ESTA_ACTIVO,FECHA_ALTA,FECHA_BAJA,MAIL) VALUES
('Hayden','Moss',4,211695.50, 0,'2012-06-07','2015-02-19', 'hmoss@gmail.com')

INSERT INTO EMPLEADOS (NOMBRE,APELLIDO,ID_PUESTO,SALARIO,ESTA_ACTIVO,FECHA_ALTA,FECHA_BAJA,MAIL) VALUES
('Amal','Colon',2,388933.60,1,'2019-09-23',NULL, NULL)

INSERT INTO PUESTOS (ID_PUESTO,NOMBRE,NIVEL_AUTORIZACION) VALUES(1,'Director',3);
INSERT INTO PUESTOS (ID_PUESTO,NOMBRE,NIVEL_AUTORIZACION) VALUES(2,'Gerente',3);
INSERT INTO PUESTOS (ID_PUESTO,NOMBRE,NIVEL_AUTORIZACION) VALUES(5,'Jefe de sector',2);
INSERT INTO PUESTOS (ID_PUESTO,NOMBRE,NIVEL_AUTORIZACION) VALUES(4,'Administrativo',1);
INSERT INTO PUESTOS (ID_PUESTO,NOMBRE,NIVEL_AUTORIZACION) VALUES(3,'Vendedor',0);
INSERT INTO PUESTOS (ID_PUESTO,NOMBRE,NIVEL_AUTORIZACION) VALUES(6,'Secretario',2);