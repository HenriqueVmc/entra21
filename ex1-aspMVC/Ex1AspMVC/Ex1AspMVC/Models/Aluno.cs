using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ex1AspMVC.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CodMatricula { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public byte Frequencia { get; set; }
        public double Media { get; set; }
        public string Situacao { get; set; }
    }
}

/*
    [Required(ErrorMessage = "Nome não pode ser vazio")]
    [MinLength(5, ErrorMessage = "Nome deve conter no mínimo 5 caracteres")]
    [MaxLength(100, ErrorMessage = "Nome deve conter no máximo 100 caracteres")]
    [Range(1200.00, 100000.00, ErrorMessage = "Salário deve estar entre R$ 1.200,00 à R$ 100.000,00")]
 * 
Id INT IDENTITY,
Nome VARCHAR(100) NOT NULL,								  
CodMatricula VARCHAR(10) NOT NULL,
Nota1 FLOAT,
Nota2 FLOAT,
Nota3 FLOAT,
Frequencia TINYINT);
 
*/