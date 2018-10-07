CREATE TABLE Produtos(Nome VARCHAR(100));

INSERT INTO Produtos
VALUES('Calabresa'),('X-Calabresa'),('Pizza de Calabresa'),
	  ('Calabresa com Miojo'),('Milk Shake de Calabresa'),
	  ('Paçoca de Calabresa com açai'),('Polenta com paçoca');

SELECT * FROM Produtos;

-- LIKE
SELECT * FROM Produtos WHERE Nome LIKE 'Cala%'; -- Consulta Filtrata por Cadeia de Caracteres que inicaim com Cala
SELECT * FROM Produtos WHERE Nome LIKE '%bresa'; -- "  "  "  "  "  "  "  "  "  "  "  "  "  "  "   termina com bresa
SELECT * FROM Produtos WHERE Nome LIKE '%Calabresa%'; --- "  "  "  "  "  "  "  "  "  "  "  "  "   contenha Calabresa

