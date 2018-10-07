
CREATE TABLE Consertos(Id INT IDENTITY NOT NULL,
					  DonoVeiculo VARCHAR(100) NOT NULL, 
                      ModeloVeiculo VARCHAR(50) NOT NULL,
                      CorVeiculo VARCHAR(50) NOT NULL,
                      Situacao VARCHAR(100),
                      DataOrcamento DATE,
                      ValorOrcamento FLOAT,
                      ValorServico FLOAT,
                      ValorDesconto FLOAT,
                      ValorTotal FLOAT,
                      DataConclusao DATE,
					  IdColaborador INT
);

CREATE TABLE Colaboradores(Id INT IDENTITY NOT NULL,
						   Nome VARCHAR(100) NOT NULL,
                           Funcao VARCHAR(50),
                           Turno VARCHAR(30)
);

ALTER TABLE Consertos ADD CONSTRAINT PKConserto PRIMARY KEY(Id);
ALTER TABLE Colaboradores ADD CONSTRAINT PKColaborador PRIMARY KEY(Id);
ALTER TABLE Consertos ADD CONSTRAINT FKColaborador FOREIGN KEY(IdColaborador) REFERENCES Colaboradores(Id);
