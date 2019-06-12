create table usuario(
	id int identity not null primary key,
	nome varchar(50) not null,
	senha varchar(100) not null,
	usuario varchar(20) not null
)

create table cliente(
	id int identity not null primary key,
	nome varchar(50) not null,
	telefone varchar(50) not null
)

create table funcionario(
	id int identity not null primary key,
	nome varchar(50) not null,
	telefone varchar(50) not null
)

create table procedimento(
	id int identity not null primary key,
	descricao varchar(100) not null,
	valor float not null
)

create table adicional(
	id int identity not null primary key,
	descricao varchar(100) not null,
	valor float not null
)

create table forma_pgto(
	id int identity not null primary key,
	descricao varchar(100) not null
)