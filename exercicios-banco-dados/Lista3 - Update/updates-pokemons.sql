-- Lista 3 Tabela Pokemons

UPDATE pokemons SET categoria = 'Seed' WHERE codigo < 100 AND codigo > 50;

UPDATE pokemons SET ataque = 29 WHERE nome LIKE '%inj%';

UPDATE pokemons SET velocidade = 2 WHERE velocidade = 5;

UPDATE pokemons SET categoria = 'Manipulate' WHERE codigo > 100;

UPDATE pokemons SET nome = 'trocar primeira letra por C' WHERE nome LIKE 'R%';

UPDATE pokemons SET altura = 0.51, peso = 0.70 WHERE altura = 0.5;

UPDATE pokemons SET codigo = 1, defesa = 1, ataque = 1, especial_ataque = 3, especial_defesa = 4 WHERE especial_defesa = 3 AND especial_ataque = 4;

/*UPDATE pokemons SET nome = 'obter somente os dez caracteres do nome' WHERE LEN(nome) > 10;*/

UPDATE pokemons SET categoria = 'water' WHERE descricao LIKE '%flames%';

UPDATE pokemons SET codigo = 151 WHERE codigo = 155;

UPDATE pokemons SET nome = 'Naruto', ataque = 1 WHERE nome = 'Kabuto';

UPDATE pokemons SET nome = 'Sasuke', especial_ataque = 8002, ataque = 8001 WHERE nome = 'Mew' OR nome = 'Mewtwo';

UPDATE pokemons SET descricao = 'Lorem ipsum', nome = 'Tyranitar', categoria = 'Wood Gecko' WHERE codigo%2 = 0;
