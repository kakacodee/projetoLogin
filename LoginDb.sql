drop database LoginLoja;
create database LoginLoja;

-- USANDO O BANCO DE DADOS

use LoginLoja;

-- CRIANDO AS TABELAS DO BANCO DE DADOS

create table cliente(
	Id int primary key auto_increment,
    Nome varchar(50) not null,
    Nascimento datetime not null,
    CPF decimal(10,2)not null,
    Telefone varchar(50) not null,
	Email varchar(50) not null,
    Sexo char(1) not null,
    Situacao varchar(50) not null,
    Senha varchar(50) not null
    
);

create table colaborador(
	Id int primary key auto_increment,
    Nome varchar(50) not null,
    CPF decimal(10,2) not null,
	Email varchar(50) not null,
    Senha int not null ,
    TipoColaborador varchar(50) not null
    
);
