 --DROP TABLE vendas;
 CREATE TABLE vendas (
	id INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(100),
	preco DECIMAL(7,2),
	quantidade SMALLINT
 );


INSERT INTO vendas (nome, preco, quantidade)
VALUES('Café', 4, 27.13),
	  ('Leite', 35, 4.15),
	  ('Açucar', 52, 24.67),
	  ('Biscoito', 3, 1.71),
      ('Miojo', 9, 45.23),
      ('Calabresa', 17, 1.72),
	  ('Bacoon', 18, 19.52),
      ('Feijão', 18, 7.87),
	  ('Sazon', 47, 4.11),
	  ('Qboa', 50, 22.39);
	  
SELECT * FROM vendas;
-- FUNCOES
SELECT nome, quantidade, preco, (quantidade*preco) AS total FROM vendas ORDER BY total DESC;
SELECT SUM(preco) AS 'Preço Total' FROM vendas; -- soma todos os registros por coluna
SELECT SUM((preco*quantidade)) AS 'Preço Total de Geral' FROM vendas;
SELECT AVG(preco) AS 'Média dos Preços' FROM vendas; -- Média dos valores da coluna
SELECT MIN(preco)as 'Menor Preço' FROM vendas;
SELECT MAX(preco)as 'Maior Preço' FROM vendas;
SELECT Nome, LEN(nome) 'Caracteres na Coluna Nome' FROM vendas; -- Quantidade de carateres da coluna
SELECT Nome, LEN(nome) 'Caracteres na Coluna Nome' FROM vendas WHERE LEN(nome) > 4 ORDER BY nome DESC;

/*

CURIOSIDADE: Subconsulta

SELECT Nome FROM vendas WHERE LEN(nome) = (SELECT MAX(LEN(nome)) FROM Vendas);-- Coluna com maior quantidade de caracteres
SELECT Nome FROM vendas WHERE LEN(nome) = (SELECT MIN(LEN(nome)) FROM Vendas);-- Coluna com menor quantidade de caracteres
SELECT Nome FROM vendas WHERE LEN(nome) = (SELECT MIN(LEN(nome)) FROM Vendas) AND nome LIKE 'c%'

*/
