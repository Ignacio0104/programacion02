SELECT * FROM EMPLEADOS;
SELECT * FROM EMPLEADOS WHERE ESTA_ACTIVO = 1 ORDER BY APELLIDO;
SELECT TOP(3) FECHA_ALTA FROM EMPLEADOS;
SELECT TOP(3) SALARIO FROM EMPLEADOS;
SELECT * FROM EMPLEADOS ORDER BY SALARIO DESC;
SELECT DISTINCT NIVEL_AUTORIZACION FROM PUESTOS;