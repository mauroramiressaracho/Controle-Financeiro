using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_Financeiro.Models
{
    public class Clientes
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(150)]
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public double Valor_Emprestimo { get; set; }

        public double Saldo { get; set; }

        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }
        
        public bool Ativo { get; set; }
    }
}
