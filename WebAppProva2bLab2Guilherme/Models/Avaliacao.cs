using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2Guilherme.Models
{
    public class Avaliacao
    {
        public int AvalicaoId { get; set; }
        public DateTime Data { get; set; }
        public Boolean Aprovado { get; set; }
        public virtual ICollection<Trabalho> Trabalhos { get; set; }
    }
}