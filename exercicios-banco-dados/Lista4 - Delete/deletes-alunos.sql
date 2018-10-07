-- 1. Apagar o(s) aluno(s) que o nome contenha ‘Francisco’.
DELETE FROM alunos WHERE nome = '%Francisco%';

-- 2. Apagar o(s) aluno(s) que nasceram no ano de 1994.
DELETE FROM alunos WHERE YEAR(data_nascimento) = 1994;

-- 3. Apagar o(s) aluno(s) que contém o signo de ‘Gêmeos’.
DELETE FROM alunos WHERE signo = 'Gêmeos';

-- 4. Apagar o(s) aluno(s) que o nome contenha ‘Reinaldo’ no começo.
DELETE FROM alunos WHERE nome LIKE 'Reinaldo%';

-- 5. Apagar o(s) aluno(s) que o nome acabe com ‘Carvalho’.
DELETE FROM alunos WHERE nome LIKE '%Carvalho';

-- 6. Apagar o(s) aluno(s) que que nasceram no mês de julho.
DELETE FROM alunos WHERE MONTH(data_nascimento) = 7;

-- 7. Apagar o(s) aluno(s) que nota1 for maior que a nota 2 e a nota 4 for menor que a nota 3.
DELETE FROM alunos WHERE (nota_1 > nota_2) AND (nota_4 < nota_3);

-- 8. Apagar o(s) aluno(s) que o cpf comece com ‘145.’
DELETE FROM alunos WHERE cpf LIKE '145%'

-- 9. Apagar o(s) aluno(s) que a cor preferida seja ‘Bordo’ e o signo seja ‘Capricórnio’ ou a cor preferida ‘Cinza-claro’ e o signo seja ‘Aquários’.
DELETE FROM alunos WHERE (cor_preferida = 'Bordo' AND signo = 'Capricórnio') OR (cor_preferida = 'Cinza-claro' AND signo = 'Aquários');

-- 10. Apagar o(s) aluno(s) que a média seja menor que 4.
DELETE FROM alunos WHERE ((nota_1+nota_2+nota_3+nota_4)/4) < 4;

-- 11. Apagar o(s) aluno(s) que o dia de nascimento seja 28.
DELETE FROM alunos WHERE DAY(data_nascimento) = 28;
