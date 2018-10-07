-- SCRIPT DE INSERÇÃO:

USE OficinaMecanica;
GO

-- INSERIR DADOS EM CLIENTE
INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Henrique Venancio', 'Rua Guaruja, 30 - Vila Suiça', 1144881234, 12345678910);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Braulio Souza','Rua Aguai, 100 - Parque Paulista', 1144882345, 12345678911);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Felipe Ferreira', 'Rua Itupeva, 87 - Jardim Rosa', 1144883456, 12345678912);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Thiago Tromps', 'Rua das Laranjeiras, 1050 - Jardim Eliza', 1144884567, 12345678913);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Lucas Dionizio', 'Rua Lins, 65 - Jardim Paulista', 1144884567, 12345678914);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Leonardo Pereira', 'Rua Itapevi, 66 - Vila Chaves', 1144885678, 12345678915);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Angela dos Anjos', 'Rua Sete, 7 - Vila Sé', 1144441234, 12345678916);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Melissa Mendes', 'Rua Oito, 8 - Vila José', 1144442345, 12345678917);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Irani Mendes', 'Rua Nove, 9 - Vila Clemente', 1144443456, 12345678918);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Aparecido Venancio', 'Rua Leme, 189 - Vila Capoa', 1144444567, 12345678919);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Suelen Mendes', 'Rua Dez, 10 - Jardim Peri', 1144445678, 12345678920);
GO
INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Douglas Costa','Rua Onze, 11 - Parque Caieiras', 1144446789, 12345678921);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Cassio Fernandez', 'Rua Doze, 12 - Jardim Franco da Rocha', 1144441011, 12345678922);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Yago dos Santos', 'Rua Treze, 13 - Jardim Santista', 1144441112, 12345678923);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Fagner de Oliveira', 'Rua Quatorze, 14 - Jardim Romano', 1144441213, 12345678924);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Uendel Lira', 'Rua Quinze, 15 - Vila Nove', 1144441314, 12345678925);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Bruno Henrique Neto', 'Rua Dezeseis, 16 - Mato Dentro', 1144441415, 12345678926);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Elias Barbosa', 'Rua Dezesete, 17 - Agua Branca', 1144441516, 12345678927);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Ninalva Cohene', 'Rua Dezoito, 18 - Vila das Rosas', 1144441617, 12345678928);
GO

INSERT INTO Cliente(Nome, Endereco, Telefone, CNH)
	VALUES('Joaquim Francisco', 'Rua Dezenove, 19 - Lago Azul', 1144441718, 12345678929);
GO

-- INSERIR DADOS EM VEICULO
INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('ABC1234', 1, 'Chevrolet', 'Celta', 2000, 123456789);
GO

INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('BCD2345', 2, 'BMW', 'Sl206', 2012, 934567810);
GO

INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('CDE3456', 3, 'Hiunday', 'Hb20', 2015, 234567811);
GO

INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('DEF4567', 4, 'Honda', 'Civic', 2005, 234567812);
GO

INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('EFG5678', 5, 'Mercedes Bens', 'Classic', 2016, 234567813);
GO

INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('FGH6789', 6, 'Volvo', 'Truck', 2013, 234567814);
GO

INSERT INTO Veiculo(Placa,CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('GHI7890',7,'Volkswagen', 'Gol', 1999, 234567815);
GO

INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('IJK1112', 8, 'Volkswagen', 'Jetta', 2000, 234567816);
GO

INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('KLM1213', 9, 'Nissam', 'Versa', 2012, 234567817);
GO

INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('MNO1314', 10, 'Hiunday', 'Ix35', 2015, 234567818);
GO

INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('OPQ1415', 11, 'Honda', 'City', 2005, 234567819);
GO

INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('QRS1516', 12, 'Volkswagen', 'Fusca', 1900, 234567820);
GO

INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('STU1617', 13, 'Volkswagen', 'Fox', 2003, 234567821);
GO

INSERT INTO Veiculo(Placa,CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('VXY1718',14,'Volkswagen', 'Amarok', 2015, 234567822);
GO

INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('AAA1213', 15, 'Fiat', 'Siena', 2012, 234567823);
GO

INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('BBB1314', 16, 'Fiat', 'Punto', 2015, 234567824);
GO

INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('CCC1415', 17, 'Fiat', 'Bravo', 2015, 234567825);
GO

INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('DDD1516', 18, 'Volkswagen', 'Golf', 2016, 234567826);
GO

INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('EEE1718', 19, 'Volkswagen', 'UP', 2016, 234567827);
GO

INSERT INTO Veiculo(Placa, CodCliente, Marca, Modelo, Ano, Renavam)
	VALUES('FFF1819', 20, 'Volkswagen', 'Voyage', 2016, 234567828);
GO


-- INSERIR DADOS EM MECANICO
INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(12345, 'Maycon Silvestre', 'Rua Santo Antonio, 50', 11991234567,12345678910);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(56789, 'Jadso de Figueiredo', 'Rua São Bernado, 12', 11997891011, 12345678911);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(10112, 'Renato Augusto', 'Rua das Flores, 37', 11991121314,12345678912);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(13145, 'Andre de Jesus', 'Rua Dez, 89',11991151617, 12345678913);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(16178, 'Ronaldo Fenomeno', 'Rua da Luz, 660', 11991161718,12345678914);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(19201, 'Lucca Guimaraes', 'Rua Dois, 2', 11991192021,12345678915);
GO
INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(21223, 'Carlos Drummond', 'Rua Drummond, 120', 11991212223, 12345678916);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(24256, 'Vinicius de Moraes', 'Rua das Rosas, 37', 11991242526,12345678917);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(27289, 'Cecilia Meireles', 'Rua Tres, 809',11991272829, 12345678918);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(30312, 'Manuel Bandeira', 'Rua da Quatro, 680', 11991303132,12345678919);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(33345, 'Jose Lins do Rego', 'Rua do Cafe, 500', 11991333435,12345678920);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(36378, 'Guimaraes Rosa', 'Rua Quatorze, 112', 11991363738, 12345678921);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(39401, 'Renato Pereira', 'Rua do Eucalipto, 327', 11991394041,12345678922);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(41423, 'Gabriel de Jesus', 'Rua Dezeseis, 891',11991424344, 12345678923);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(44456, 'Matheus Henrique', 'Rua Quinze, 610', 11991454647,12345678924);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(47489, 'Felipe Gabriel', 'Rua Jorge, 150', 11991484950,12345678925);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(50512, 'Manuel Pereira', 'Rua Vinte, 129', 11991515253, 12345678926);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(52534, 'Cristiano Ronaldo', 'Rua dos Craques, 237', 11991545556,12345678927);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(55567, 'Neymar Junior dos Anjos', 'Rua Santista, 222',11991575859, 12345678928);
GO

INSERT INTO Mecanico(CREA, Nome, Endereco, Celular, CPF)
	VALUES(58591, 'Ricardo Oliveira', 'Rua Manuel Andrade, 291', 11991606162,12345678929);
GO

-- INSERIE DADOS EM REVISÃO
INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('AAA1213', '10112', '12-04-2016 12:15', 300.25, 'Revisão geral do Veiculo, Troca de óleo', 0);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('ABC1234', '12345', '11-05-2016 08:30', 200.25, 'Alinhamento e balanceamento', 0);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('BBB1314', '13145', '12-05-2016 09:45',1500.55, 'Troca de Para-Choque , Revisão Geral e Balanciamento',1);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('BCD2345', '16178', '11-01-2016 17:25',150.20,'Troca de Par de Pneus',1);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('CCC1415', '19201', '10-10-2016 14:15', 200.25, 'Revisão geral do Veiculo', 0);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('CDE3456', '21223', '08-10-2016 08:28', 200.25, 'Alinhamento e balanceamento', 0);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('DDD1516', '24256', '09-09-2016 10:42',1900.75, 'Troca de Amortecerores Alinhamento, Revisão Geral e Balanciamento',1);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('DEF4567', '27289', '01-08-2016 20:25',500.20,'Troca de Jogo de Molas',1);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('EEE1718', '30312', '07-02-2016 10:15', 300.25, 'Revisão geral do auto, Troca de óleo', 0);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('EFG5678', '33345', '09-12-2016 08:28', 200.25, 'Alinhamento e balanceamento', 0);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('FFF1819', '36378', '05-02-2016 09:42',1579.85, 'Troca de Carburador, Revisão Geral e Balanciamento',1);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('FGH6789', '39401', '06-01-2016 15:25',340.20,'Troca de Par Velas',1);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('GHI7890', '41423', '07-09-2016 10:15', 300.25, 'Revisão geral do auto, Troca de óleo', 0);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('IJK1112', '44456', '10-04-2016 08:28', 200.25, 'Alinhamento e balanceamento', 0);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('KLM1213', '47489', '10-04-2016 09:42',500.55, 'Troca de Pastilha de Freio, Revisão Geral e Balanciamento',1);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('MNO1314', '50512', '10-02-2016 15:25',257.29,'Troca de Correia dentada',1);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('OPQ1415', '52534', '10-04-2016 10:15', 315.25, 'Revisão geral do auto, Troca de óleo', 0);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('QRS1516', '55567', '11-01-2016 08:28', 200.25, 'Alinhamento e balanceamento', 0);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('STU1617', '58591', '04-02-2016 09:42',1535.55, 'Troca de Correia do Alternador, Revisão Geral e Balanciamento',1);
GO

INSERT INTO Revisao(Placa, CREA, DataHoraRevisao, ValorRevisao, Relatorio, TrocaPecas)VALUES('VXY1718', '12345', '10-04-2016 15:25',950.67,'Troca de Disco de freio',1);
GO

-- INSERIR DADOS EM VEICULO PESADO

INSERT INTO VeiculoPesado(PesoToneladas, NumEixos, Comprimento,Placa) VALUES(7.75, 6, 10.70,'ABC1234');
GO

INSERT INTO VeiculoPesado(PesoToneladas, NumEixos, Comprimento,Placa) VALUES(8.60, 7, 11.00,'AAA1213');
GO

INSERT INTO VeiculoPesado(PesoToneladas, NumEixos, Comprimento,Placa) VALUES(9.95, 9,16.75,'BBB1314');
GO

INSERT INTO VeiculoPesado(PesoToneladas, NumEixos, Comprimento,Placa) VALUES(3.13, 3, 07.50,'BCD2345');
GO

INSERT INTO VeiculoPesado(PesoToneladas, NumEixos, Comprimento,Placa) VALUES(4.13, 4, 08.50,'MNO1314');
GO

INSERT INTO VeiculoPesado(PesoToneladas, NumEixos, Comprimento,Placa) VALUES(5.22, 5, 09.22,'CCC1415');
GO

INSERT INTO VeiculoPesado(PesoToneladas, NumEixos, Comprimento,Placa) VALUES(6.75, 6, 10.00,'CDE3456');
GO

INSERT INTO VeiculoPesado(PesoToneladas, NumEixos, Comprimento,Placa) VALUES(7.60, 7, 11.00,'DDD1516');
GO

INSERT INTO VeiculoPesado(PesoToneladas, NumEixos, Comprimento,Placa) VALUES(8.05, 8,12.75,'DEF4567');
GO

INSERT INTO VeiculoPesado(PesoToneladas, NumEixos, Comprimento,Placa) VALUES(9.13, 9, 13.50,'EEE1718');
GO

SELECT * FROM Cliente;
GO
SELECT * FROM Mecanico;
GO
SELECT * FROM Veiculo ORDER BY CodCliente ASC;
GO
SELECT * FROM Revisao;
GO
SELECT * FROM VeiculoPesado;
GO

USE Desconecta;
GO