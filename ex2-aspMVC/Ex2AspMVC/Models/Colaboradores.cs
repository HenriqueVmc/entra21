using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ex2AspMVC.Models
{
    public class Colaboradores
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }

    }
}