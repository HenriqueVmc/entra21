Create Database BDAutomotiva;
go
use BDAutomotiva;

create table TBFabricante(
	CodFabricante int Primary Key Identity,
	Nome varchar(10) not null
);

create table TBVeiculo(
	CodVeiculo int Primary Key Identity,
	Modelo varchar(50) not null,
	AnoFab datetime,
	AnoMod datetime,
	CodFabricante int foreign key references TBFabricante(CodFabricante),
	ValorFipe money
);


insert into TBFabricante(Nome) values ('Kia');
insert into TBFabricante(Nome) values ('Ford');
insert into TBFabricante(Nome) values ('GM');
insert into TBFabricante(Nome) values ('Fiat');


insert into TBVeiculo(Modelo,AnoFab,AnoMod,CodFabricante,ValorFipe)
		values('Towner','1998','1999',1,25000);
insert into TBVeiculo(Modelo,AnoFab,AnoMod,CodFabricante,ValorFipe)
		values('Scort','1994','1995',2,7500);
insert into TBVeiculo(Modelo,AnoFab,AnoMod,CodFabricante,ValorFipe)
		values('Corsa Classic','2004','2005',3,13400);
insert into TBVeiculo(Modelo,AnoFab,AnoMod,CodFabricante,ValorFipe)
		values('Uno','2012','2013',4,29000);
		
-- Efetua a soma dos valores dos veículos
Select sum(ValorFipe) as Valor_dos_veiculos from TBVeiculo; 

-- Retorna a quantidade de registros
select count(*) as QuantidadeDeVeiculos from TBVeiculo; 

-- Calcula a média dos valores dos veículos
select sum(ValorFipe) / count(*) as Media_Dos_Valores from TBVeiculo; 

-- Efetua a média do valor dos veículos
Select avg(ValorFipe) as Media_Dos_Valores from TBVeiculo; 


-- Exemplo simples de Stored Procedure
CREATE PROCEDURE CadastraFabricante
	@nomeFab varchar (30)
AS
	INSERT INTO TBFabricante(Nome) VALUES (@nomeFab)
GO

-- Maneira de executar a sua Stored Procedure
EXEC CadastraFabricante @nomeFab = 'asd';
GO
SELECT * FROM TBFabricante;


-- Exemplo de Stored Procedure sekecionar varias tabelas
CREATE PROCEDURE SelecionarVeiculosPeloNomeDoFabricante
	@NomeFabricante VARCHAR (30)
AS
	SELECT * FROM TBVeiculo WHERE CodFabricante
	IN (
		SELECT TBFabricante.CodFabricante
		FROM TBFabricante
		WHERE
		TBFabricante.Nome like @NomeFabricante
	 )
 GO
 EXEC SelecionarVeiculosPeloNomeDoFabricante 'Ford';



 -- Exemplo de Stored Procedure p/ Excluir en cascata
 CREATE PROCEDURE ExcluirFabricanteEVeiculos
	@codFabricante INT
AS
	DELETE FROM TBVeiculo WHERE CodFabricante = @codFabricante;
	DELETE FROM TBFabricante WHERE CodFabricante = @codFabricante;
GO

EXEC ExcluirFabricanteEVeiculos 20;
GO
