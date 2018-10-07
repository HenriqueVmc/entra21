--- BAKUP POKEMONS ---

-- CONSULTAS SIMPLES
SELECT COUNT(*) FROM pokemons; -- Qtdade de registros da table

SELECT nome, categoria FROM pokemons;

SELECT nome as NOME, 
	   ataque as ATAQUE, 
	   especial_ataque as 'ATAQUE ESPECIAL', -- alias
	   defesa as DEFESA, 
	   especial_defesa as 'DEFESA ESPECIAL' 
FROM pokemons;

-- ORDER BY
SELECT * FROM pokemons ORDER BY Nome;

SELECT categoria, nome FROM pokemons ORDER BY categoria, Nome;-- ordenando mais de uma coluna

SELECT nome FROM pokemons ORDER BY Nome DESC; -- ordenação decrescente

SELECT ataque, nome FROM pokemons ORDER BY ataque DESC, Nome; -- ordenando em decrescente, e segunda coluna crescente

SELECT nome, ataque, especial_ataque,
	   defesa, especial_defesa, descricao, 
	   altura, peso, velocidade
FROM pokemons ORDER BY Nome;

-- WHERE
SELECT nome, ataque FROM pokemons WHERE ataque = 4;
SELECT COUNT(nome) FROM pokemons WHERE ataque = 4;

-- WHERE COM ORDER BY
SELECT nome, categoria FROM pokemons WHERE categoria = 'dragon' ORDER BY nome;
SELECT nome, ataque FROM pokemons WHERE ataque != 4 ORDER BY ataque;
SELECT nome, ataque FROM pokemons WHERE ataque != 3 AND ataque != 4 AND ataque != 5 AND ataque != 6 AND ataque != 7 ORDER BY ataque;
SELECT nome, ataque FROM pokemons WHERE ataque IN(1,2,8) ORDER BY ataque;
SELECT nome, ataque FROM pokemons WHERE ataque < 3 OR ataque > 7 ORDER BY ataque;
SELECT COUNT(ataque) FROM pokemons WHERE ataque < 3 OR ataque > 7;
SELECT nome, defesa FROM pokemons WHERE defesa >= 2 ORDER BY defesa, nome;
SELECT categoria, nome, hp FROM pokemons WHERE hp%2 = 0 ORDER BY hp, categoria, nome;-- MOD

/*CURIOSIDADE: SELECT EM INSERT

INSERT INTO pokemons(nome, categoria, ataque)
VALUES ('Teste', 'Dragon', (SELECT ataque FROM pokemons WHERE categoria = 'Dragon' AND nome = 'Kingdra'));--PARA LIMIT X, USAR SELECT TOP X

*/
	