CREATE TABLE Alunos(Id INT IDENTITY,
					Nome VARCHAR(100) NOT NULL,								  
					CodMatricula VARCHAR(10) NOT NULL,
					Nota1 FLOAT,
					Nota2 FLOAT,
					Nota3 FLOAT,
					Frequencia TINYINT);

ALTER TABLE Alunos ADD CONSTRAINT PKAlunos PRIMARY KEY(Id);
--

INSERT INTO Alunos (Nome, CodMatricula, Nota1, Nota2, Nota3, Frequencia) VALUES ('Henrique', '171004544', 10, 9, 10, 70);

SELECT * FROM Alunos;

/*SELECT Id, Nome, CodMatricula, Nota1, Nota2, Nota3, Frequencia, ((Nota1 + Nota2 + Nota3)/3),
IIF(Frequencia < 50, 'Reprovado por frequencia', IIF(((Nota1 + Nota2 + Nota3)/3) < 5, 'Reprovado por média', IIF(((Nota1 + Nota2 + Nota3)/3) < 7, 'Em exame', 'Aprovado'))) FROM Alunos;
*/
