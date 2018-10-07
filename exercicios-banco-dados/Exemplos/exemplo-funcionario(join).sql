CREATE DATABASE BDJoin;
GO

/* JOIN = JUNÇÃO DE DUAS TABELAS*/

USE BDJoin;
GO

CREATE TABLE  TBCargo(CodCargo INT PRIMARY KEY IDENTITY, NomeCargo VARCHAR (30) NOT NULL);
GO

CREATE TABLE TBFuncionario(
	CodFuncionario INT PRIMARY KEY IDENTITY, NomeFuncionario VARCHAR (30) NOT NULL, Salario MONEY NOT NULL, 
	CodCargo INT, CONSTRAINT FK_Cargo FOREIGN KEY (CodCargo) REFERENCES TBCargo (CodCargo)
);
GO

INSERT INTO TBCargo(NomeCargo) VALUES ('Gerente');
GO
INSERT INTO TBCargo(NomeCargo) VALUES ('Vendedor');
GO
INSERT INTO TBCargo(NomeCargo) VALUES ('Telefonista');
GO
INSERT INTO TBCargo(NomeCargo) VALUES ('Segurança');
GO

INSERT INTO TBFuncionario(NomeFuncionario,Salario,CodCargo ) VALUES ('Laura', 7000.00,1);
GO
INSERT INTO TBFuncionario(NomeFuncionario,Salario,CodCargo ) VALUES ('Donizete', 3000.00,2);
GO
INSERT INTO TBFuncionario(NomeFuncionario,Salario,CodCargo ) VALUES ('Kelly', 1500.00,3) 
GO
INSERT INTO TBFuncionario(NomeFuncionario,Salario ) VALUES ('Evaristo Costa', 2500.00)
GO

--exemplo de consulta anterior utillizando join

SELECT TBFuncionario.NomeFuncionario, TBCargo.NomeCargo FROM TBFuncionario
	JOIN TBCargo ON TBFuncionario.CodCargo = TBCargo.CodCargo;  

-- perceba que o cargo segurança não apareceu na pois não existe funcionario contratado com este cargo

-- caso deseje exibir os cargos mesmo que não existem funcionarios contratados a coluna nomeFuncionario retornará o valor null

-- observe que a tabela que possui dados que queremos exibir está a direita do join 
-- por este motivo utiliza-se right join

SELECT TBFuncionario.NomeFuncionario, TBCargo.NomeCargo
FROM TBFuncionario RIGHT JOIN TBCargo ON TBFuncionario.CodCargo = TBCargo.CodCargo; 

SELECT TBFuncionario.NomeFuncionario, TBCargo.NomeCargo
FROM TBFuncionario LEFT JOIN TBCargo ON TBFuncionario.CodCargo = TBCargo.CodCargo; 


--para retornar todos os registros independente de possuirem relacionamento, ou seja left + right join
SELECT TBFuncionario.NomeFuncionario, TBCargo.NomeCargo
FROM TBFuncionario 
FULL OUTER JOIN TBCargo ON TBFuncionario.CodCargo = TBCargo.CodCargo; 


-- quando precisar de combinações usar cross join
SELECT TBFuncionario.NomeFuncionario, TBCargo.NomeCargo
FROM TBFuncionario 
CROSS JOIN TBCargo -- ON TBFuncionario.CodCargo = TBCargo.CodCargo; 
