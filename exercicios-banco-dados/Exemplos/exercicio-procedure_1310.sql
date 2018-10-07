USE Loja_Roupa;
GO
/*
	O Procedure serve para agilizar os seguintes procedimentos
*/

--Insert por PROCEDURE 
/*CREATE PROCEDURE ConsutaCliente
SELECT * FROM TbCliente;
GO*/


CREATE PROCEDURE InsereCliente
@Nome VARCHAR(85),
@end VARCHAR(200),
@Cpf CHAR(11) 
AS
INSERT INTO TbCliente VALUES(@Nome,@Cpf,@end);
GO

EXEC InsereCliente 'Ana', '2365161654','Rua Ipiranga, 34';
GO
EXEC InsereCliente 'Mario', 'Rua Itupeva, 44','2352161654';
GO
/*PEGAR COM ALGUEM O CONSULTA CLIENTE
EXEC ConsultaCliente;
GO
*/

--Atualizar por procedure

CREATE PROCEDURE AtualizaQtdadeProduto @CodProd INT,@NovaQtdade INT
AS
UPDATE TbProduto SET QTESTOQUE =@NovaQtdade
WHERE CodProduto = @CodProd;
GO

EXEC AtualizaQtdadeProduto 1, 123;
GO

--PROCEDIMENTO COM CALCULO

CREATE PROCEDURE AtQtdadeProduto @CodProd INT, @NovaQtdade INT
AS
UPDATE TbProduto SET QTESTOQUE = (QTESTOQUE+@NovaQtdade)
WHERE CodProduto = @CodProd;
GO

EXEC AtQtdadeProduto 3,10;

--Procedure que retorna a consulta com o total de vendas em dia(RELATÒRIO)

CREATE PROCEDURE VendasPorDataVariavel @DtVenda DATE
AS SELECT TbVenda.DtVenda AS 'Data da Venda',
SUM(TbVendaItem.QtdadeComprada * TbProduto.ValorUnit)
AS 'Total Vendido por Dia'
FROM TbVenda INNER JOIN TbVendaItem
ON TbVendaItem.CodVenda = TbVenda.CodVenda
INNER JOIN TbProduto
ON TbVendaItem.CodProduto = TbProduto.CodProduto
WHERE TbVenda.DtVenda = '26/03/2016'
GROUP BY TbVenda.DtVenda;
GO

EXEC VendasPorDataVariavel '03/10/2016';
GO

