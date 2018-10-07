-- Lista 4 Deletes na tabela cidades

-- 1. Apagar a(s) cidade(s) do estado do Rio Grande do Sul.
DELETE FROM cidades WHERE estado = 'RS';

-- 2. Apagar a(s) cidade(s) do estado do Acre que a cidade comece com a letra ‘R’.
DELETE FROM cidades WHERE estado = 'AC' AND cidade LIKE 'R%';

-- 3. Apagar a(s) cidade(s) que o nome termine com ‘goas’.
DELETE FROM cidades WHERE cidade LIKE '%goas';

-- 4. Apagar a(s) cidade(s) que o nome contenha irmãos em qualquer parte
DELETE FROM cidades WHERE cidade LIKE '%irmãos%';

-- 5. Apagar a(s) cidade(s) do estado de Minas Gerais.
DELETE FROM cidades WHERE estado = 'MG';

-- 6. Apagar a(s) cidade(s) que o nome seja ‘Douradina’.
DELETE FROM cidades WHERE cidade = 'Douradina';
