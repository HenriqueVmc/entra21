-- 1. Selecione o estado e cidade.
SELECT estado, cidade FROM cidades;

-- 2. Selecione as cidades que começam com a letra A.
SELECT cidade FROM cidades WHERE cidade LIKE 'A%';

-- 3. Selecione as cidades que contenham no ‘apar’ em qualquer parte do nome
SELECT cidade FROM cidades WHERE cidade LIKE '%apar%'

-- 4. Selecione as cidades que começam com a letra W.
SELECT cidade FROM cidades WHERE cidade LIKE 'W%'

-- 5. Selecione o estado e a cidade que a cidade termina com ‘tuba’ ordenando pelo estado em ordem decrescente.
SELECT estado, cidade FROM cidades WHERE cidade LIKE '%tuba%' ORDER BY estado DESC;

-- 6. Selecione a cidade que o nome da cidade contenha mais que 15 caracteres, ordenando pelo quantidade de caracteres.
SELECT cidade, LEN(cidade) AS 'Tamanho do Nome' FROM cidades WHERE LEN(cidade) > 15 ORDER BY 'Tamanho do Nome';

-- 7. Contabilize a quantidade de cidades do estado de SC.
SELECT COUNT(cidade) 'Quantidade de Cidades de SC' FROM cidades WHERE estado = 'SC';

-- 8. Contabilize a quantidade de cidades do estado de SP.
SELECT COUNT(cidade) 'Quantidade de Cidades de SP' FROM cidades WHERE estado = 'SP';

-- 9. Selecione o nome da cidade com a quantidade de caracteres, quando o nome da cidade conter 10 caracteres.
SELECT cidade, LEN(cidade) AS 'Tamanho do Nome'  FROM cidades WHERE LEN(cidade) > 10;

-- BÔNUS --
SELECT cidade FROM cidades WHERE cidade LIKE 'Franco da Rocha%';

-- Quantidade de Cidades por estados
SELECT estado, COUNT(cidade) AS 'Quantidade de Cidades' FROM cidades GROUP BY estado;

-- Quantidade de Cidades por estados em ordem decrescente
SELECT estado, COUNT(cidade) AS 'Quantidade de Cidades' FROM cidades GROUP BY estado ORDER BY 'Quantidade de Cidades' DESC;

-- Cidade com maior nome
SELECT cidade, LEN(cidade) AS 'Tamanho do Nome' FROM cidades ORDER BY 'Tamanho do Nome' DESC;