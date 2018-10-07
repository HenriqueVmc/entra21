CREATE TABLE Recrutadoras(Id INT IDENTITY,
						  Nome VARCHAR(100) NOT NULL,
						  Cpf CHAR(11) NOT NULL,
						  TempoEmpresa SMALLINT,
						  Salario DECIMAL(12,2));

INSERT INTO Recrutadoras (Nome, Cpf, TempoEmpresa, Salario) VALUES
('Dolfim', '12345678998', 2, 1000.00),
('Jopafim', '12543542698', 3, 2000.00),
('Cafim', '98453542698', 4, 1500.00);

SELECT * FROM Recrutadoras;