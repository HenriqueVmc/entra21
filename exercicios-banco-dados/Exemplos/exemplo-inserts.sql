--TESTE EM CASA
-- MUDANÇA PARA TESTE
-- TESTE DE (GIT DIFF)
﻿-- BACKUP PESSOAS

CREATE TABLE Pessoas(Nome VARCHAR(100), 
	         Sobrenome VARCHAR(170));

INSERT INTO Pessoas VALUES('João', 'da Silva');
INSERT INTO Pessoas VALUES('Pedro', 'Machado');
INSERT INTO Pessoas VALUES('Henrique', 'Venâncio');
INSERT INTO Pessoas VALUES('Beibe', 'do Biruleibe');
INSERT INTO Pessoas VALUES('Marcos', 'Oliveira');

EXEC sp_RENAME 'Pessoas.sobrenome', 'Sobrenome', 'COLUMN'; -- RENAME COLUMN

UPDATE Pessoas SET Nome = 'Henrique' WHERE Sobrenome = 'Venâncio';
DELETE Pessoas WHERE Nome = 'Marcos';

-- Limpa * Registros
TRUNCATE TABLE Pessoas;

----- BACKUP MANGAS
CREATE TABLE Mangas(Nome VARCHAR(100), 
					Volume INT, 
					Ano INT);

INSERT INTO Mangas VALUES('Naruto', 67, 2015);
INSERT INTO Mangas VALUES('Bleach', 70, 2015);
INSERT INTO Mangas VALUES('Nanatsu', 20, 2015);
INSERT INTO Mangas VALUES('Dragon Ball', 8001, 2004);

-- BACKUP PIZZAS
CREATE TABLE Pizzas(Cliente VARCHAR(100),
					Preco DECIMAL(5, 2), 
					Diametro SMALLINT, 
					Fatias TINYINT, 
					Sabor_1 VARCHAR(50), 
					Sabor_2 VARCHAR(50), 
					Sabor_3 VARCHAR(50), 
					Sabor_4 VARCHAR(50), 
					Sabor_5 VARCHAR(50), 
					ComBorda BIT, 
					ComBrinde BIT);

INSERT INTO Pizzas VALUES('João', 50.30, 25, 8, 'Quatro Queijos', 'Calabresa', 'Atum', 'Portuguesa','', 1, 0);

INSERT INTO Pizzas (Cliente, Preco, Diametro, Fatias, Sabor_1, Sabor_4, ComBorda, ComBrinde) 
VALUES('Ygor', 45, 20, 8, 'Pepino Com Tomate', 'Brócolis', 0, 0);

INSERT INTO Pizzas (Cliente, Preco, Diametro, Fatias, Sabor_1, Sabor_2, ComBorda, ComBrinde)
VALUES('Solfi JR', 40, 20, 16, 'Frango com Cebola', 'Frango sem Cebola', 0, 1);

INSERT INTO Pizzas (Cliente, Preco, Diametro, Fatias, Sabor_1, Sabor_2, Sabor_3, ComBorda, ComBrinde)
VALUES('Fadinha', 65, 35, 25, 'Italiana', 'Alemã', 'Britânica', 1, 0);

INSERT INTO Pizzas (Cliente, Preco, Diametro, Fatias, Sabor_1, Sabor_3, ComBorda, ComBrinde)
VALUES('Desenhista', 55, 35, 8, 'Kostelinha', 'Quatro Presuntos', 0, 0);

UPDATE Pizzas SET Preco = NULL WHERE Cliente = 'Ygor';




