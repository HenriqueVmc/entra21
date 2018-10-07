CREATE TABLE Outfit(Marca VARCHAR(100), 
					Valor DECIMAL(8, 2), 
					Tamanho CHAR(3),
					Cor VARCHAR(20), 
					Tecido VARCHAR(40));

INSERT INTO Outfit VALUES ('Supreme', 700, 'M', 'Cinza especial', 'TNT'),
						  ('Gucci', 15000, 'P', 'Preto com Vermelho', 'Laicra'),
						  ('Lalis Blanc', 15, '', 'Rosa Xoque', 'Seda'),
						  ('Nike', 400, 'M', 'Indefinido', 'Malha'),
						  ('Gucci', 2500, 'M', 'Verde', '150% Malha'),
						  ('Okle', 500, 'PP', 'Fogo', 'Lona'),
						  ('Chili Bians', 14999, 'GGG', 'Branco', 'Diamante');

SELECT * FROM Outfit;

UPDATE Outfit SET Tamanho = 'XGG' WHERE Marca LIKE '%Lalis Blanc%';
UPDATE Outfit SET Marca = 'Oakley' WHERE Marca LIKE 'Okle%';
UPDATE Outfit SET Cor = 'Azul Espacial' WHERE Tecido LIKE '%malha%';
DELETE FROM Outfit WHERE Cor = 'Azul Espacial';
UPDATE Outfit SET Marca = 'Chilli Beans', Valor = 15000 WHERE Tamanho = 'GGG' AND Cor = 'Branco' AND Tecido = 'Diamante';
