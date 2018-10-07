SELECT p.name 'Pokemons', c.name 'Categorias' FROM pokemons p
JOIN categories c
ON c.id = p.id_categoryI 
WHERE p.name = 'Bulbasaur';

SELECT c.name 'Categorias', p.name 'Pokemons' FROM categories c
JOIN pokemons p
ON c.id = p.id_categoryI ORDER BY c.name, p.name;

SELECT COUNT(p.id) 'Quantidade de Pokemons BUG' FROM categories c 
JOIN pokemons p ON p.id_categoryI = c.id
WHERE c.name = 'Bug';

SELECT c.name 'Categoria', COUNT(p.id) 'Quantidade de Pokemons' FROM categories c 
JOIN pokemons p ON p.id_categoryI = c.id
GROUP BY c.name ORDER BY COUNT(p.id) DESC;