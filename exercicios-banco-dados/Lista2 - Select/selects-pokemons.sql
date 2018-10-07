-- 1. Selecione todos as colunas.
SELECT id, nome, codigo, altura, peso, hp, ataque, defesa, especial_defesa, especial_ataque, velocidade, descricao  FROM pokemons;

-- 2. Selecione o ataque, ataque, defesa e defesa especial.
SELECT p.ataque, p.defesa, p.especial_defesa FROM pokemons p;

-- 3. Selecione nome, categoria e ataque ordenado pelo ataque em ordem crescente.
SELECT p.nome, p.categoria, p.ataque FROM pokemons p ORDER BY p.ataque;

-- 4. Selecione altura, peso, com o cálculo do imc.
SELECT p.altura, p.peso, (p.peso/(p.altura*p.altura)) as IMC FROM pokemons p;

-- 5. Selecione altura, peso, com o cálculo do imc ordenando o imc em ordem decrescente.
SELECT p.altura, p.peso, (p.peso/(p.altura*p.altura)) as IMC FROM pokemons p ORDER BY IMC DESC;

-- 6. Selecione nome e o tamanho do nome em ordem decrescente pelo nome.
SELECT p.nome, LEN(p.nome)'Tamanho do Nome' FROM pokemons p ORDER BY 'Tamanho do Nome' DESC;

-- 7. Selecione nome, descrição quando o nome contiver mais que 10 caracteres.
SELECT nome, descricao, LEN(nome) AS 'Tamanho do Nome' FROM pokemons WHERE LEN(nome) > 10;

-- 8. Selecione nome, categoria, e ataque do pokemon que contém o menor valor de ataque.
SELECT nome, categoria, ataque FROM pokemons WHERE ataque <= (SELECT MIN(ataque) FROM pokemons);

--9. Selecione o ataque, ataque, nome, defesa e defesa especial ordenando pelo ataque.
SELECT ataque, especial_ataque, nome, defesa, especial_defesa FROM pokemons ORDER BY ataque;

-- 10. Selecione a média dos ataques.
SELECT AVG(ataque) AS 'Média dos Ataques' FROM pokemons;

-- 11. Selecione a somatória dos ataques.
SELECT SUM(ataque) AS 'Somatória dos ataques' FROM pokemons;

-- 12. Selecione a média dos ataques especiais quando o nome do pokemon começar com ‘P’.
SELECT AVG(especial_ataque)'Média dos ataques especiais' FROM pokemons WHERE nome LIKE 'P%';