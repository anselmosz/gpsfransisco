--drop database dbfrancisco;

create database dbfrancisco;
use dbfrancisco;

create table tbusuarios(
  codUsr int not null auto_increment,
  nome varchar(50) not null,
  senha varchar(12) not null,
  primary key(codUsr)                                                                                                                                                                                                                                                                                    
);

insert into tbusuarios(nome,senha) value('admin','admin');

select * from tbusuarios;

select nome, senha from tbusuarios where nome = 'senac' and senha = 'senac';

-- busca os dados da tabela utilizando o parametro de ordem alfabetica dos nomes;
select nome from tbusuarios order by nome asc;

update tbusuarios set nome = 'test', senha = 'test' where codUsr = 1;

-- Pesquisa por nome
select * from tbusuarios where nome like '%@nome%';
