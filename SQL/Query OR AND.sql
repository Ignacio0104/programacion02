SELECT * FROM EMPLEADOS;
SELECT * FROM EMPLEADOS WHERE ESTA_ACTIVO = 1 AND SALARIO >300000;
SELECT * FROM EMPLEADOS WHERE MAIL IS NULL OR ESTA_ACTIVO =0;
SELECT * FROM EMPLEADOS WHERE MAIL LIKE '%a%' AND NOMBRE LIKE '%a%';
SELECT * FROM EMPLEADOS WHERE (SALARIO >= 250000 AND FECHA_ALTA >='2000-01-01') OR  (SALARIO<250000 AND FECHA_ALTA<'1999-12-31');
SELECT * FROM EMPLEADOS WHERE SALARIO BETWEEN 100000 AND 200000;
SELECT * FROM EMPLEADOS WHERE SALARIO NOT BETWEEN 100000 AND 250000;
SELECT * FROM PUESTOS WHERE NIVEL_AUTORIZACION IN (0,1,2);
SELECT * FROM PUESTOS WHERE NIVEL_AUTORIZACION NOT IN (0,1,2);
