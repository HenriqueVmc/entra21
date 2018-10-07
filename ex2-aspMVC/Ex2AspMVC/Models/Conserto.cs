using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ex2AspMVC.Models
{
    public class Conserto
    {
        [Key]
        public int Id { get; set; }
        public string DonoVeiculo { get; set; }
        public string ModeloVeiculo { get; set; }
        public string CorVeiculo { get; set; }
        public string Situacao { get; set; }
        //public DateTime DataOrcamento { get; set; }
        //public double ValorOrcamento { get; set; }
        //public double ValorServico { get; set; }
        //public double ValorDesconto { get; set; }
        //public double ValorTotal { get; set; }
        //public DateTime DataConclusao { get; set; }
        //public Colaboradores Colaborador { get; set; }

    }
}