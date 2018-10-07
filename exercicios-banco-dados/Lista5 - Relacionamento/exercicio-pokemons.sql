CREATE TABLE Pokemons(Id INT IDENTITY, Nome VARCHAR(100) NOT NULL, IdCategoria INT, IdFraqueza1 INT, IdFraqueza2 INT);
CREATE TABLE Categorias(Id INT IDENTITY, Nome VARCHAR(100) NOT NULL);
CREATE TABLE Fraquezas(Id INT IDENTITY, Nome VARCHAR(100) NOT NULL);

ALTER TABLE Pokemons ADD CONSTRAINT PKPokemon PRIMARY KEY(Id);
ALTER TABLE Categorias ADD CONSTRAINT PKCategoria PRIMARY KEY(Id);
ALTER TABLE Fraquezas ADD CONSTRAINT PKFraqueza PRIMARY KEY(Id);

ALTER TABLE Pokemons ADD CONSTRAINT FKCategoria FOREIGN KEY(IdCategoria) REFERENCES Categorias(Id);
ALTER TABLE Pokemons ADD CONSTRAINT FKFraqueza1 FOREIGN KEY(IdFraqueza1) REFERENCES Fraquezas(Id);
ALTER TABLE Pokemons ADD CONSTRAINT FKFraqueza2 FOREIGN KEY(IdFraqueza2) REFERENCES Fraquezas(Id);

INSERT INTO Fraquezas VALUES('Steel'),
							('Poison'),
							('Eletric'),
							('Grass'),
							('Bug'),
							('Dark'),							
							('Fire'),
							('Rock'),							
							('Fighting'),
							('Ground'),
							('Ice'),
							('Water');

INSERT INTO Categorias VALUES('Balloon'),
						     ('Fish'),
							 ('Patient'),
							 ('Cocoon'),
							 ('Imitation'),
							 ('Duck'),
							 ('Trap'),
							 ('Fresh Snow'),
							 ('Transform'),
							 ('Sleeping');

INSERT INTO Pokemons (Nome, IdCategoria, IdFraqueza1, IdFraqueza2) VALUES
('Jigglypuff', 1, (SELECT Id FROM Fraquezas WHERE Nome = 'Steel'), (SELECT Id FROM Fraquezas WHERE Nome = 'Poison')),
('Magikarp', 2, (SELECT Id FROM Fraquezas WHERE Nome = 'Eletric'), (SELECT Id FROM Fraquezas WHERE Nome = 'Grass')),
('Wobbuffet', 3, (SELECT Id FROM Fraquezas WHERE Nome = 'Bug'), (SELECT Id FROM Fraquezas WHERE Nome = 'Dark')),
('Metapod', 4, (SELECT Id FROM Fraquezas WHERE Nome = 'Fire'), (SELECT Id FROM Fraquezas WHERE Nome = 'Rock')),
('Sudowoodo', 5, (SELECT Id FROM Fraquezas WHERE Nome = 'Fighting'), (SELECT Id FROM Fraquezas WHERE Nome = 'Ground')),
('Psyduck', 6, (SELECT Id FROM Fraquezas WHERE Nome = 'Eletric'), (SELECT Id FROM Fraquezas WHERE Nome = 'Grass')),
('Stunfisk', 7, (SELECT Id FROM Fraquezas WHERE Nome = 'Ice'), (SELECT Id FROM Fraquezas WHERE Nome = 'Water')),
('Vanillite', 8, (SELECT Id FROM Fraquezas WHERE Nome = 'Fire'), (SELECT Id FROM Fraquezas WHERE Nome = 'Fighting')),
('Ditto', 9, (SELECT Id FROM Fraquezas WHERE Nome = 'Fighting'), NULL),
('Snorlax', 10, (SELECT Id FROM Fraquezas WHERE Nome = 'Fighting'), NULL);


SELECT p.Nome, 
	   c.Nome AS Categoria, 
	   f.Nome AS 'Fraqueza 1', 
	   (SELECT f2.Nome FROM Fraquezas f2 WHERE p.IdFraqueza2 = f2.Id) AS 'Fraqueza 2' 
FROM Pokemons p
INNER JOIN Categorias c ON c.Id = p.IdCategoria
INNER JOIN Fraquezas f ON f.Id = p.IdFraqueza1;

