using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_Financeiro.Models
{
    public class Login
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(150)]
        public string Nome { get; set; }

        [MaxLength(8)]
        public string Senha { get; set; }

        public bool Ativo { get; set; }

    }
}
