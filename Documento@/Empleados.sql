create table Empleados (
Ced integer(8) not null,
Pnom varchar(20) not null,
Snom varchar(20),
Pape varchar(20) not null,
Sape varchar(20) not null,
Cargo varchar(20) not null,
direccion varchar(30) not null,
tel integer not null,
sueldoPagar double not null,

constraint pk_ci primary key (Ced)
							);


insert into empleados(Ced,Pnom,Snom,Pape,Sape,Cargo,direccion,tel,sueldoPagar) 
values ("53393343","Mateo",null,"Vargas","Girino","Gerente","Robertosky 1234",11111111,450);

select sum(sueldoPagar) As Total_A_Pagar from empleados;

select * from empleados;

select count(*) FROM EMPLEADOS WHERE ced=53393343