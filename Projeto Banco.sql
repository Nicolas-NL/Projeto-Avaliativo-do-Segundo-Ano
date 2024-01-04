create database ProjetoBD_DDS

create table Cliente(
cod_clie int identity (1,1) primary key,
email_clie varchar(22) unique,
nome_clie char (23),
senha_clie varchar(30),
sobrenome_clie char(23),
idade numeric(3),
sexo char(9)
);
select * from Cliente
drop table Cliente
create table Comanda(
cod_com int identity (1,1) primary key,
val_Gasta numeric(10,2),
qtd_Item numeric(10),
--cod_clie int foreign key references Cliente(cod_clie),
email_clie varchar(22)
);
