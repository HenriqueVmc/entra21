CREATE TABLE Herois(Id INT IDENTITY, 
					Nome VARCHAR(100) NOT NULL,
					Escuridao BIT,
					NomePessoa VARCHAR(150) NOT NULL,
					Raca VARCHAR(200) NOT NULL,
					ContaBancaria DECIMAL(17,2) NOT NULL,
					DataNascimento DATE,
					Sexo CHAR(1),
					QtdFilmes TINYINT,
					Descricao TEXT);

SELECT * FROM Herois;

/*
-- TOTAL CONTA BANÁRIA
SELECT SUM(ContaBancaria) FROM Herois;

-- QTD DE MULHERES
SELECT COUNT(Sexo) FROM Herois WHERE Sexo = 'm';

-- QTD DE HEROIS POR RACA
SELECT raca, COUNT(Id) FROM Herois GROUP BY Raca;

-- HEROI MAIS VELHO
SELECT Nome, YEAR(GETDATE())-YEAR(DataNascimento) FROM Herois WHERE DataNascimento = (SELECT MAX(DataNascimento) FROM Herois);
*/