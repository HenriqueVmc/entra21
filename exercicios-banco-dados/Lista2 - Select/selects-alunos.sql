-- 1. Selecione todas as colunas da tabela.
SELECT nome, cpf, nick, signo, numero_favorito, cor_preferida, nota_1, nota_2, nota_3, nota_4, data_nascimento FROM alunos;

-- 2. Selecione o nome dos alunos que a nota 1 é maior que 9.0.
SELECT nome, nota_1 FROM alunos WHERE nota_1 > 9.0;

-- 3. Selecione o nome do aluno, nota 1, nota 2, nota 3, nota 4, e a média.
SELECT nome, nota_1, nota_2, nota_3, nota_4, ((nota_1+nota_2+nota_3+nota_4)/4) 'Média' FROM alunos;

-- 4. Contabilize a quantidade de alunos com o signo de Peixes
SELECT COUNT(signo)'Pessoas com Signo: Peixes' FROM alunos WHERE signo = 'Peixes';

-- 5. Selecione a soma da nota 1
SELECT SUM(nota_1) AS 'Soma das notas 1' FROM alunos;
SELECT nome, SUM(nota_1) AS 'Soma da nota 1' FROM alunos GROUP BY nome;

-- 6. Selecione a média da nota 2
SELECT AVG(nota_2) AS 'Média das notas 2' FROM alunos;
SELECT nome, SUM(nota_1) AS 'Média da nota 2' FROM alunos GROUP BY nome;

-- 7. Selecione o nome, menor nota 1.
SELECT nome, nota_1 FROM alunos WHERE nota_1 = (SELECT MIN(nota_1) FROM alunos);

-- 8. Selecione o nome, nota 1, nota 2, nota 3, nota 4 com o maior nome.
SELECT TOP 1 nome, nota_1, nota_2, nota_3, nota_4 FROM alunos ORDER BY LEN(nome) DESC;

-- 9. Selecione a cor e quantidade com a cor Gelo.
SELECT cor_preferida, COUNT(cor_preferida) 'Cor' FROM alunos WHERE cor_preferida = 'Gelo' GROUP BY cor_preferida;

-- 10. Selecione a quantidade de alunos que o nome contém Francisco no começo.
SELECT nome, COUNT(*)'Alunos com nome: Francisco' FROM alunos WHERE nome LIKE 'Francisco%';

-- 11. Selecione a quantidade de alunos que o nome contém Luc.
SELECT COUNT(*)'Alunos com "Luc" no nome' FROM alunos WHERE nome LIKE '%Luc%';

-- 12. Selecione o nome, signo e data de nascimento quando o signo Áries
SELECT nome, signo, data_nascimento FROM alunos WHERE signo = 'Áries';

-- 13. Selecione o nome, nota 1, nota 2, nota 3, nota 4 com o maior média.
SELECT TOP 1 nome, nota_1, nota_2, nota_3, nota_4, ((nota_1+nota_2+nota_3+nota_4)/4) AS 'Média' FROM alunos ORDER BY 'Média' DESC;

-- 14. Selecione o nome, média e caso a média for menor que 5 apresentar reprovado, 
-- caso for menor que 7 apresentar em exame senão apresentar aprovado. Dica: buscar como fazer IF em sql.

SELECT nome, ((nota_1+nota_2+nota_3+nota_4)/4) AS 'Média', IIF(((nota_1+nota_2+nota_3+nota_4)/4) < 5, 'REPROVADO', 'APROVADO') FROM alunos;

-- 15. Selecione o nome, nota 1, nota 2, nota 3, nota 4 com o menor média.
SELECT TOP 1 nome, nota_1, nota_2, nota_3, nota_4, ((nota_1+nota_2+nota_3+nota_4)/4) 'Média' FROM alunos ORDER BY 'Média';

-- 16. Selecione a quantidade de alunos em que a média foi maior que 7
SELECT COUNT(*) FROM alunos WHERE ((nota_1+nota_2+nota_3+nota_4)/4) > 7;

-- 17. Selecione o nome, nick do aluno que o nick contém 5 caracteres.
SELECT nome, nick FROM alunos WHERE LEN(nick) > 5;

-- 18. Selecione o nome do aluno quando a cor for ouro ou amarelo-torrado e a média for maior que seis e meio.
SELECT nome, cor_preferida FROM alunos WHERE (cor_preferida = 'ouro' OR cor_preferida = 'amarelo-torrado') AND ((nota_1+nota_2+nota_3+nota_4)/4) > 6.5;

-- 19. Selecione o nome e o ano da data de nascimento.
SELECT nome, YEAR(data_nascimento)'Ano de nascimento' FROM alunos;

-- 20. Selecione o nick e o mês de nascimento quando o mês de nascimento for maior que 6.
SELECT nick, MONTH(data_nascimento)'Mês de Nascimento' FROM alunos WHERE MONTH(data_nascimento) > 6;

-- 21. Selecione a quantidade de pessoas que nasceram no ano de 1996
SELECT COUNT(*)'Pessoas que nascram em 1996' FROM alunos WHERE YEAR(data_nascimento) = 1996;

-- 22. Selecione a quantidade de pessoas de pessoas que nasceram no dia dois do mês de fevereiro do ano 1964 ou 1994.
SELECT COUNT(*) 'Pessoas que nasceram em 02/02/1964 e 1994' FROM alunos WHERE (DAY(data_nascimento) = 2 AND MONTH(data_nascimento) = 2) AND YEAR(data_nascimento) = 1964 OR YEAR(data_nascimento) = 1994; 

-- 23. Selecione o nick e a nota 4 do aluno que a nota 2 está entre 5.0 e 5.99.
SELECT nick, nota_4 FROM alunos WHERE nota_2 >= 5 AND nota_4 < 6;

-- 24. Apresentar a média da aluna Josefina.
SELECT nome, ((nota_1+nota_2+nota_3+nota_4)/4) AS 'Média' FROM alunos WHERE nome LIKE '%Josefina%';

-- 25. Apresentar nome, nick, nota 1, nota 2, nota 3, nota 4, quando o nome conter Justino e o signo começar com ‘A’.
SELECT nome, nick, signo, nota_1, nota_2, nota_3, nota_4 FROM alunos WHERE nome LIKE '%Justino%' AND signo LIKE '‘A%';

-- 26. Apresentar a média das médias.
SELECT AVG((nota_1+nota_2+nota_3+nota_4)/4)'Média das Médias' FROM alunos;









