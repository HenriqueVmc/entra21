-- Lista 3 Updates na Tabela Cidade
UPDATE cidades SET estado = 'SS' WHERE estado = 'SC';

UPDATE cidades SET cidade = 'Brumenau', estado = 'SC' WHERE cidade = 'Blumenau';

UPDATE cidades SET cidade = 'Batata' WHERE cidade LIKE 'Bata%';

UPDATE cidades SET cidade = 'trocar belo por Lindo' WHERE cidade LIKE '%Belo%';

UPDATE cidades SET estado = 'SC' WHERE cidade LIKE 'Indaia%';

UPDATE cidades SET estado = 'SC' WHERE cidade LIKE '%Timbó%'

UPDATE cidades SET cidade = 'trocar "José" por Josué' WHERE cidade LIKE '%José%';

UPDATE cidades SET estado = 'PS' WHERE estado LIKE '%SP%';

UPDATE cidades SET cidade = 'qualquer texto' WHERE LEN(cidade) = 10;

UPDATE cidades SET cidade = 'It' WHERE cidade LIKE 'It%';

UPDATE cidades SET estado = 'TO' WHERE cidade LIKE '%ã';
