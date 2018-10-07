-- BACKUP JOGOS
CREATE TABLE jogos (
	id INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(100) DEFAULT 'Neymar',
	quedas SMALLINT
 );

 INSERT INTO jogos (quedas)VALUES(20);
 INSERT INTO jogos (nome, quedas) VALUES('TITE',2);

 SELECT * FROM jogos;