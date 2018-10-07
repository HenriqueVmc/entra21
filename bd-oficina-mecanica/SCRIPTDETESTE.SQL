-- SCRIPT DE TESTE:

USE OficinaMecanica;
GO

-- Apagar chave primaria
ALTER TABLE Revisao DROP CONSTRAINT PK_Revisao;
GO

--Apagar Coluna de tabela
ALTER TABLE Mecanico DROP COLUMN Celular;
GO

--Apagar Tabela Inteira
DROP TABLE VeiculoPesado;
GO

--De INT para VARCHAR
ALTER TABLE Veiculo ALTER COLUMN Ano VARCHAR(4);
GO

--Adicionar Coluna
ALTER TABLE Mecanico ADD Celular CHAR(11);
GO

-- Excluir chave estrangeira
ALTER TABLE Revisao DROP CONSTRAINT FK_Mecanico_Revisao;
GO

-- add chave estrangeira
ALTER TABLE Revisao ADD CONSTRAINT FK_Mecanico_Revisao FOREIGN KEY (CREA) REFERENCES Mecanico;
GO

--add UNIQUE
ALTER TABLE Veiculo ADD CONSTRAINT UqPlaca UNIQUE(Placa);
GO

-- DESCONECTAR BANCO ATUAL
USE Desconecta;
GO

-- APAGAR BANCO OFICINAMECANICA
DROP DATABASE OficinaMecanica;
GO