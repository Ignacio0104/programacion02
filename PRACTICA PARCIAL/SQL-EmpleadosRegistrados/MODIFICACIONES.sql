UPDATE EMPLEADOS SET MAIL='mbrock@yahoo.com' WHERE ID_EMPLEADO=4
SELECT * FROM EMPLEADOS

UPDATE EMPLEADOS SET ID_PUESTO = 4, SALARIO=210000 WHERE ID_EMPLEADO=4
SELECT * FROM EMPLEADOS

UPDATE EMPLEADOS SET SALARIO=SALARIO+(SALARIO*25/100) WHERE SALARIO<250000
SELECT * FROM EMPLEADOS